using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceViewerWidget : Widget, IViewWidget<Workspace>
    {
        public Workspace Model { get; }

        public WorkspaceViewerWidget(Workspace model) : base("Workspace")
        {
            Model = model;
            InitializeComponent();
        }

        public void UpdateGuiFromModel()
        {
            IconImage.Image = Model.Application.Icon;
            ClassValueLabel.Text = Model.Application.Class;
            TitlebarValueLabel.Text = Model.Application.Titlebar;
            TitleLabel.Text = Model.Title;
            DescriptionValueLabel.Text = Model.Description;
            DeleteButton.Text = Model.Active ? "Delete" : "Undo Delete";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var widget = new WorkspaceEditorWidget(Model);
            NavigateForward(widget);
        }

        private void DetectionsButton_Click(object sender, EventArgs e)
        {
            var widget = new DetectionsWidget(Model);
            NavigateForward(widget);
        }

        private void ProceduresButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Model.Active = !Model.Active;
            App.SaveCurrentState();
            NavigateBackward();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            NavigateBackward();
        }
    }
}