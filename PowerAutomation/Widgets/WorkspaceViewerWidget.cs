using n_ate.Essentials;
using PowerAutomation.Controls;
using PowerAutomation.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceViewerWidget : Widget, IViewWidget<Workspace>
    {
        private Workspace Model;

        public WorkspaceViewerWidget(Widget caller, Workspace model) : base("Workspace", caller)
        {
            Model = model;
            InitializeComponent();
            UpdateFromModel(Model);
        }

        public void UpdateFromModel(Workspace model)
        {
            model.MapTo(Model); // copies the value of each member from model to Model..

            IconImage.Image = model.Application.Icon;
            ClassValueLabel.Text = model.Application.Class;
            TitlebarValueLabel.Text = model.Application.Titlebar;
            TitleLabel.Text = model.Title;
            DescriptionValueLabel.Text = model.Description;
        }

        public override void UpdateFromModel(object model)
        {
            if (model is Workspace m) UpdateFromModel(m);
            else throw new ArgumentException($"Model argument is not correct type. Expected:{nameof(Workspace)}, Actual:{model.GetType().Name}");
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

        public override void OnBeforeNavigate(IViewWidget destination)
        {
        }
    }
}