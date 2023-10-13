using PowerAutomation.Controls;
using SharpHook;
using Vanara.PInvoke;

namespace PowerAutomation
{
    public partial class CreateTaskWidget : Widget
    {
        //private readonly TaskPoolGlobalHook hook;

        public CreateTaskWidget(Widget caller) : base("Create Task", caller)
        {
            //this.hook = new TaskPoolGlobalHook();

            //hook.HookEnabled += OnHookEnabled;     // EventHandler<HookEventArgs>
            //hook.HookDisabled += OnHookDisabled;   // EventHandler<HookEventArgs>

            //hook.KeyTyped += OnKeyTyped;           // EventHandler<KeyboardHookEventArgs>
            //hook.KeyPressed += OnKeyPressed;       // EventHandler<KeyboardHookEventArgs>
            //hook.KeyReleased += OnKeyReleased;     // EventHandler<KeyboardHookEventArgs>

            //hook.MouseClicked += OnMouseClicked;   // EventHandler<MouseHookEventArgs>
            //hook.MousePressed += OnMousePressed;   // EventHandler<MouseHookEventArgs>
            //hook.MouseReleased += OnMouseReleased; // EventHandler<MouseHookEventArgs>
            //hook.MouseMoved += OnMouseMoved;       // EventHandler<MouseHookEventArgs>
            //hook.MouseDragged += OnMouseDragged;   // EventHandler<MouseHookEventArgs>

            //hook.MouseWheel += OnMouseWheel;       // EventHandler<MouseWheelHookEventArgs>

            //Task.Run(() => hook.Run());
            // or
            //await hook.RunAsync();

            InitializeComponent();
        }

        public async Task<IntPtr> GetWindowUserActivates()
        {
            var currentWindowHandle = this.ParentForm.Handle;
            var activeWindowHandle = await Task.Run(async () =>
            {
                IntPtr foregroundWindowHandle;
                do
                {
                    await Task.Delay(50);
                    foregroundWindowHandle = (IntPtr)User32.GetForegroundWindow();
                }
                while (foregroundWindowHandle == currentWindowHandle || foregroundWindowHandle == IntPtr.Zero);
                return foregroundWindowHandle;
            });
            return activeWindowHandle;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var success = TryNavigateBack();
            if (!success) throw new InvalidOperationException();
        }

        private async void DetectionTaskButton_Click(object sender, EventArgs e)
        {
            var handle = await GetWindowUserActivates();
            ManipulationTaskButton.Text = handle.ToString() ?? "";
        }
    }
}