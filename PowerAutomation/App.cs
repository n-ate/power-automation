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
        public static readonly Color TransparencyColor = Color.Magenta;

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

        //public static Bitmap CaptureImage(RECT bounds)
        //{
        //    if (bounds.Left == bounds.Right) throw new ArgumentException("Bounds left and right cannot have the same value.", nameof(bounds));
        //    if (bounds.Top == bounds.Bottom) throw new ArgumentException("Bounds top and bottom cannot have the same value.", nameof(bounds));
        //    var snippet = new Bitmap(bounds.Right - bounds.Left, bounds.Bottom - bounds.Top, PixelFormat.Format32bppArgb);
        //    using (var graphics = Graphics.FromImage(snippet))
        //    {
        //        graphics.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, snippet.Size, CopyPixelOperation.SourceCopy);
        //    }
        //    return snippet;
        //}

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

        public static Panel AddImageWithMaskedBackground(Bitmap image)
        {
            var control = new Panel()
            {
                Top = 0,
                Left = 0,
                Height = image.Height,
                Width = image.Width,
                BackgroundImage = image,
                Tag = nameof(AddImageWithMaskedBackground)
            };
            if (Form.Width > control.Width) control.Left = (Form.Width - control.Width) / 2; //if smaller than screen center
            if (Form.Height > control.Height) control.Top = (Form.Height - control.Height) / 2; //if smaller than screen center
            Form.Controls.Add(control);
            control.SendToBack();
            Form.BackColor = Color.DarkGray;
            return control;
        }

        public static void Hide()
        {
            Form.WindowState = FormWindowState.Minimized;
        }

        public static void Show()
        {
            Form.WindowState = FormWindowState.Maximized;
        }

        public static void RemoveImageWithMaskedBackground()
        {
            var toRemove = new List<Control>();
            foreach (Control control in Form.Controls)
            {
                if (control.Tag?.ToString() == nameof(AddImageWithMaskedBackground)) toRemove.Add(control);
            }
            foreach (var control in toRemove) Form.Controls.Remove(control);
            Form.BackColor = App.TransparencyColor;
        }
    }
}