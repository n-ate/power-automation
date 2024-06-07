using PowerAutomation.Models;
using System.Text.Json;

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
                    var json = File.ReadAllText(@"C:\_\workspaces.json");
                    _workspaces = JsonSerializer.Deserialize<WorkspaceCollection>(json, SerializerOptions)!;
                }
                return _workspaces;
            }
            set
            {
                _workspaces = value;
            }
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
            if (Form.Width > control.Width) control.Left = (Form.Width - control.Width) / 2;
            if (Form.Height > control.Height) control.Top = (Form.Height - control.Height) / 2;
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
                if (control.Tag.ToString() == nameof(RemoveImageWithMaskedBackground)) toRemove.Add(control);
            }
            foreach (var control in toRemove) Form.Controls.Remove(control);
        }
    }
}