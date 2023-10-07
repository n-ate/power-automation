using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Vanara.PInvoke;

namespace PowerAutomation
{
    public partial class Form1 : Form
    {
        //protected override bool ShowWithoutActivation { get { return true; } }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        //make sure Top Most property on form is set to false
        //        //otherwise this doesn't work
        //        int WS_EX_TOPMOST = 0x00000008;
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= WS_EX_TOPMOST;
        //        return cp;
        //    }
        //}

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TOPMOST = 0x00000008;
                const int WS_EX_LAYERED = 0x80000;
                const int WS_EX_TRANSPARENT = 0x20;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TOPMOST;
                //cp.ExStyle |= WS_EX_LAYERED;
                //cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.Activated += Form1_Event;
            this.Click += Form1_Event;
            this.DoubleClick += Form1_Event;
            this.DragDrop += Form1_Event;
            this.DragOver += Form1_Event;
            this.Enter += Form1_Event;
            this.GotFocus += Form1_Event;
            this.KeyDown += Form1_Event;
            this.KeyPress += Form1_Event;
            this.KeyUp += Form1_Event;
            this.Leave += Form1_Event;
            this.LostFocus += Form1_Event;
            this.MouseCaptureChanged += Form1_Event;
            this.MouseClick += Form1_Event;
            this.MouseDoubleClick += Form1_Event;
            this.MouseDown += Form1_Event;
            this.MouseEnter += Form1_Event;
            this.MouseHover += Form1_Event;
            this.MouseLeave += Form1_Event;
            this.MouseMove += Form1_Event;
            this.MouseUp += Form1_Event;
            this.MouseWheel += Form1_Event;
            this.MouseEnter += Form1_Event;
            this.Move += Form1_Event;
            this.PreviewKeyDown += Form1_Event;
            this.Scroll += Form1_Event;
            this.Shown += Form1_Event;
            this.VisibleChanged += Form1_Event;

            //int initialStyle = GetWindowLong(this.Handle, -20);
            //SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20

            //Vanara.PInvoke.User32.GetActiveWindow;

            //var initialStyle = User32.GetWindowLong(this.Handle, Vanara.PInvoke.User32.WindowLongFlags.GWL_EXSTYLE);
            //var newStyle = initialStyle | User32.WindowStylesEx.WS_EX_LAYERED | User32.WindowStylesEx.WS_EX_TRANSPARENT;
            //User32.SetWindowLong(this.Handle, User32.WindowLongFlags.GWL_EXSTYLE, newStyle);

            this.MainMenuPanel.EnableDragging();
            this.MainMenuHeader.EnableDragging(MainMenuPanel);
            this.button1.EnableDragging(MainMenuPanel);

            this.ShowInTaskbar = true; //false
            this.TransparencyKey = this.BackColor = Color.Magenta;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow; //FormBorderStyle.None;
            this.Load += Form1_Load;

        }

        private void Form1_Event(object? sender, EventArgs e)
        {
            Debug.WriteLine("Event fired.");
        }

        public delegate bool WindowEnumCallback(int hwnd, int lparam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumWindows(WindowEnumCallback lpEnumFunc, int lParam);

        [DllImport("user32.dll")]
        public static extern void GetWindowText(int h, StringBuilder s, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(int h);

        private List<string> Windows = new List<string>();
        private bool AddWnd(int hwnd, int lparam)
        {
            if (IsWindowVisible(hwnd))
            {
                StringBuilder sb = new StringBuilder(255);
                GetWindowText(hwnd, sb, sb.Capacity);
                Windows.Add(sb.ToString());
            }
            return true;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            EnumWindows(new WindowEnumCallback(this.AddWnd), 0);
            this.comboBox1.Items.AddRange(Windows.ToArray());
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.Black;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

        }
    }
}