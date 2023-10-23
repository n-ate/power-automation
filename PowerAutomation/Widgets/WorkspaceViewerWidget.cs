using PowerAutomation.Controls;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceViewerWidget : Widget
    {
        private Workspace Model;
        public WorkspaceViewerWidget(Widget caller, Workspace model) : base("Workspace", caller)
        {
            Model = model;
            InitializeComponent();
            UpdateFromModel(Model);
        }

        private void UpdateFromModel(Workspace model)
        {
            IconImage.Image = model.Application.Icon;
            ClassValueLabel.Text = model.Application.Class;
            TitlebarValueLabel.Text = model.Application.Titlebar;
            TitleLabel.Text = model.Title;
            DescriptionValueLabel.Text = model.Description;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var widget = new WorkspaceEditorWidget(this, Model);
            NavigateForward(widget);
        }

        private void DetectionsButton_Click(object sender, EventArgs e)
        {
            var widget = new DetectionsWidget(this, Model);
            NavigateForward(widget);
        }

        private void ProceduresButton_Click(object sender, EventArgs e)
        {

        }

        public override void OnNavigationReturnedBack()
        {
            base.OnNavigationReturnedBack();

            UpdateFromModel(Model);
        }

        public override void OnBeforeNavigate()
        {
            base.OnBeforeNavigate();
        }
    }
}
