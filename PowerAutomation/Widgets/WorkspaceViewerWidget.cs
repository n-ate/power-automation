using PowerAutomation.Controls;
using PowerAutomation.Models;
using PowerAutomation.Widgets.Procedures;

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
            TitleLabel.Text = model.Title;
            AppTypeValueLabel.Text = model.Application.IsWinStoreApp ? "Windows Store" : "Default";
            ProcessNameValueLabel.Text = model.Application.ProcessName;
            ModuleNameValueLabel.Text = model.Application.ModuleName;
            ClassValueLabel.Text = model.Application.Class;
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
            var widget = new ProceduresWidget(this, Model);
            NavigateForward(widget);
        }

        public override void OnNavigationReturnedBack()
        {
            base.OnNavigationReturnedBack();

            UpdateFromModel(Model);
        }

        public override void OnBeforeNavigate(Widget destination)
        {
            base.OnBeforeNavigate(destination);
        }
    }
}