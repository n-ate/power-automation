using PowerAutomation.Controls;
using PowerAutomation.Widgets;

namespace PowerAutomation
{
    public partial class MenuWidget : Widget
    {
        public MenuWidget() : base("Workspaces Start", null)
        {
            InitializeComponent();
        }

        private void WorkspacesButton_Click(object sender, EventArgs e)
        {
            var widget = new WorkspacesWidget(this);
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