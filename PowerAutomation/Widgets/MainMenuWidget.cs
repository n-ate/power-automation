using PowerAutomation.Controls;

namespace PowerAutomation
{
    public partial class MainMenuWidget : Widget
    {
        public MainMenuWidget() : base("Power Automation", null)
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            NavigateForward(new CreateTaskWidget(this));
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
        }
    }
}