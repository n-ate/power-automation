using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Widgets;

namespace PowerAutomation
{
    public partial class MenuWidget : Widget, IWidget
    {
        public MenuWidget() : base("Start")
        {
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