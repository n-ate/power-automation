using PowerAutomation.Models;
using System.Drawing.Imaging;
using System.Text.Json;
using Vanara.PInvoke;

namespace PowerAutomation
{
    public static class App
    {
        private static MainForm? _form = null;

        private static Workspace[]? _workspaces = null;

        private static JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        public static MainForm Form
        {
            get
            {
                if (_form is null) throw new InvalidOperationException("Cannot access form before it has been constructed.");
                return _form;
            }
        }

        public static Workspace[] Workspaces
        {
            get
            {
                if (_workspaces is null)
                {
                    var json = File.ReadAllText(@"C:\_\workspaces.json");
                    _workspaces = JsonSerializer.Deserialize<Workspace[]>(json, SerializerOptions)!;
                }
                return _workspaces;
            }
            set
            {
                _workspaces = value;
            }
        }

        public static Bitmap CaptureImage(RECT bounds)
        {
            var snippet = new Bitmap(bounds.Right - bounds.Left, bounds.Bottom - bounds.Top, PixelFormat.Format32bppArgb);
            using (var graphics = Graphics.FromImage(snippet))
            {
                graphics.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, snippet.Size, CopyPixelOperation.SourceCopy);
            }
            return snippet;
        }

        public static void Initialize(MainForm form)
        {
            _form = form;
            form.FormClosed += (s, e) => SaveCurrentState(); //saves on close
        }

        public static void Minimize()
        {
            Form.WindowState = FormWindowState.Minimized;
            SaveCurrentState();
        }

        public static void SaveCurrentState()
        {
            var json = JsonSerializer.Serialize(Workspaces, SerializerOptions);
            File.WriteAllText(@"C:\_\workspaces.json", json);
        }

        public static void SetNotice(string message)
        {
            Form.TopNotice.ExecuteOnUIThread(n => n.Text = message);
            if (!string.IsNullOrEmpty(message)) Form.TopNotice.Flash(7);
        }

        public static void SetNotice(string message, int expiresMS)
        {
            SetNotice(message);
            Task.Run(async () =>
            {
                await Task.Delay(expiresMS);
                if (Form.TopNotice.Text == message) SetNotice(string.Empty);
            });
        }

        public static async Task<(Bitmap Image, Rectangle Bounds)> UserImageSelect()
        {
            Bitmap? selection = null;
            Rectangle? bounds = null;

            App.SetNotice("Click and drag to selet area to match.");

            using (var screen = App.CaptureImage(App.Form.Bounds))
            {
                Directory.CreateDirectory("C:\\_\\temp\\");
                screen.Save("C:\\_\\temp\\screen.png", ImageFormat.Png);
                //TODO: try to keep image in memory
                App.Form.ExecuteOnUIThread(f => f.BackgroundImage = Image.FromFile("C:\\_\\temp\\screen.png"));// screen);
                var selectionTool = new Panel()
                {
                    AutoSize = false,
                    Visible = false
                };
                selectionTool.Paint += (s, e) =>
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 2f), 1, 1, selectionTool.Width - 2, selectionTool.Height - 2);
                };
                App.Form.Controls.Add(selectionTool);
                //selectionTool.SetZOrder(1000);

                var dragStart = Point.Empty;
                var dragCurrent = Point.Empty;

                Rectangle GetSelectionBounds()
                {
                    var x = Math.Min(dragStart.X, dragCurrent.X);
                    var y = Math.Min(dragStart.Y, dragCurrent.Y);
                    var w = Math.Max(dragStart.X, dragCurrent.X) - x;
                    var h = Math.Max(dragStart.Y, dragCurrent.Y) - y;
                    return new Rectangle() { X = x, Y = y, Width = w, Height = h };
                }

                void SetSelectionTool()
                {
                    var bounds = GetSelectionBounds();
                    selectionTool.Top = bounds.Y - 2;
                    selectionTool.Left = bounds.X - 2;
                    selectionTool.Height = bounds.Height + 4;
                    selectionTool.Width = bounds.Width + 4;
                    selectionTool.Invalidate();
                }

                App.Form.MouseDown += (object? s, MouseEventArgs e) =>
                {
                    App.SetNotice("");
                    dragStart = dragCurrent = e.Location;
                    SetSelectionTool();
                    selectionTool.Show();
                };
                App.Form.MouseMove += (object? s, MouseEventArgs e) =>
                {
                    dragCurrent = e.Location;
                    SetSelectionTool();
                };
                App.Form.MouseUp += (object? s, MouseEventArgs e) =>
                {
                    dragCurrent = e.Location;
                    bounds = GetSelectionBounds();
                    selection = App.CaptureImage(bounds.Value);
                    Directory.CreateDirectory("C:\\_\\temp\\");
                    selection.Save("C:\\_\\temp\\selection.png", ImageFormat.Png);
                    App.Form.Controls.Remove(selectionTool);
                };
            }

            while (bounds is null || selection is null) await Task.Delay(50);

            var image = App.Form.BackgroundImage;
            App.Form.BackgroundImage = null;
            image.Dispose();

            App.SetNotice("");
            return (selection, bounds.Value);
        }
    }
}