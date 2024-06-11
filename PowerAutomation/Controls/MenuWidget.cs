using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Controls;

namespace PowerAutomation
{
    public partial class MenuWidget : Widget, IControl
    {
        public MenuWidget() : base("Start")
        {
            Caller = Widget.ApplicationRoot;
            InitializeComponent();
        }

        private void WorkspacesButton_Click(object sender, EventArgs e)
        {
            var widget = new WorkspacesWidget(App.Workspaces);
            NavigateForward(widget);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            App.SetNotice("Settings not implemented!", 2400);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            App.Minimize();
        }
    }
}