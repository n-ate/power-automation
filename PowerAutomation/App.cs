using PowerAutomation.Extensions;
using PowerAutomation.Models;
using System.Drawing.Imaging;
using System.Text.Json;
using Vanara.PInvoke;

namespace PowerAutomation
{
    public static class App
    {
        private static MainForm? _form = null;

        private static WorkspaceCollection? _workspaces = null;

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

        public static WorkspaceCollection Workspaces
        {
            get
            {
                if (_workspaces is null)
                {
                    const string path = @"C:\_\workspaces.json";
                    var json = "[]";
                    if (File.Exists(path)) json = File.ReadAllText(path);
                    _workspaces = JsonSerializer.Deserialize<WorkspaceCollection>(json, SerializerOptions)!;
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
            if (bounds.Left == bounds.Right) throw new ArgumentException("Bounds left and right cannot have the same value.", nameof(bounds));
            if (bounds.Top == bounds.Bottom) throw new ArgumentException("Bounds top and bottom cannot have the same value.", nameof(bounds));
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
            var dragStart = Point.Empty;
            var dragCurrent = Point.Empty;

            var screen = App.CaptureImage(App.Form.Bounds);
            App.SetNotice("Click and drag to select area to match.");
            App.Form.BackgroundImage = (Bitmap)screen.AdjustSaturation(0.4f);

            //App.Form.ExecuteOnUIThread(f => f.BackgroundImage = test);// Image.FromFile("C:\\_\\temp\\screen.png"));// screen);
            var selectionTool = new Panel()
            {
                AutoSize = false,
                Visible = false,
                BackColor = Color.Transparent
            };
            selectionTool.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.Red, 2f), 1, 1, selectionTool.Width - 2, selectionTool.Height - 2);
            };
            App.Form.Controls.Add(selectionTool);
            selectionTool.SetZOrder(0);

            App.Form.MouseDown += StartImageSelection;
            App.Form.MouseMove += ChangeImageSelection;
            App.Form.MouseUp += FinishImageSelection;

            Rectangle GetSelectionBounds()
            {
                var x = Math.Min(dragStart.X, dragCurrent.X);
                var y = Math.Min(dragStart.Y, dragCurrent.Y);
                var w = Math.Max(dragStart.X, dragCurrent.X) - x;
                var h = Math.Max(dragStart.Y, dragCurrent.Y) - y;
                if (w == 0) w = 1;
                if (h == 0) h = 1;
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
            void StartImageSelection(object? s, MouseEventArgs e)
            {
                dragStart = dragCurrent = e.Location;
                SetSelectionTool();
                selectionTool.Show();
            };
            void ChangeImageSelection(object? s, MouseEventArgs e)
            {
                dragCurrent = e.Location;
                SetSelectionTool();
            };
            void FinishImageSelection(object? s, MouseEventArgs e)
            {
                //unbind event handlers//
                App.Form.MouseDown -= StartImageSelection;
                App.Form.MouseMove -= ChangeImageSelection;
                App.Form.MouseUp -= FinishImageSelection;
                //remove capture specific elements//
                App.Form.Controls.Remove(selectionTool);
                App.SetNotice("");
                //dispose of background image//
                var image = App.Form.BackgroundImage;
                App.Form.BackgroundImage = null;
                image?.Dispose();
                //get captured snippet//
                dragCurrent = e.Location;
                bounds = GetSelectionBounds();
                selection = screen.Clone(bounds.Value, PixelFormat.Format32bppArgb);
                screen?.Dispose();
            };

            while (bounds is null || selection is null) await Task.Delay(50);
            return (selection, bounds.Value);
        }
    }
}