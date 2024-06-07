using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Widgets.Procedures;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceViewerWidget : Widget, IViewWidget<Workspace>
    {
        public Workspace Model { get; }

        public WorkspaceViewerWidget(Workspace model) : base("Workspace")
        {
            Model = model;
            InitializeComponent();
            //UpdateGuiFromModel();
        }

        public void UpdateGuiFromModel()
        {
            IconImage.Image = Model.Application.Icon;
            TitleLabel.Text = Model.Title;
            AppTypeValueLabel.Text = Model.Application.IsWinStoreApp ? "Windows Store" : "Default";
            ProcessNameValueLabel.Text = Model.Application.ProcessName;
            ModuleNameValueLabel.Text = Model.Application.ModuleName;
            ClassValueLabel.Text = Model.Application.Class;
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
            var widget = new ProceduresWidget(Model);
            NavigateForward(widget);
        }

        public override void OnNavigationArrivedBack(Widget source)
        {
            base.OnNavigationArrivedBack(source);
            UpdateGuiFromModel();
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