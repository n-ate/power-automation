using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspacesWidget : Widget, IViewWidget<WorkspaceCollection>
    {
        public WorkspaceCollection Model { get; }

        public WorkspacesWidget(WorkspaceCollection model) : base("Workspaces")
        {
            Model = model;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public void UpdateGuiFromModel()
        {
            WorkspacesListview.Items.Clear();
            WorkspacesListview.SmallImageList = new ImageList();
            foreach (var workspace in Model.OrderBy(d => d.Title))
            {
                WorkspacesListview.SmallImageList.Images.Add(workspace.Title, workspace.Application.Icon);
                var item = new ListViewItem();
                item.Text = workspace.Title;
                item.Tag = workspace;
                item.Name = workspace.Title;
                item.ImageKey = workspace.Title;
                WorkspacesListview.Items.Add(item);
                item.SubItems.Add(workspace.Application.ProcessName);
            }
        }

        private void CreateWorkspaceButton_Click(object sender, EventArgs e)
        {
            var workspace = Model.FirstOrDefault(d => d.Title == "AutoSaved");
            if (workspace is null)
            {
                workspace = new Workspace();
                Model.Add(workspace);
            }
            var widget = new WorkspaceEditorWidget(workspace);
            NavigateForward(widget);
        }

        private void WorkspacesListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var workspace = WorkspacesListview.FocusedItem?.Tag as Workspace;
            if (workspace is not null)
            {
                var widget = new WorkspaceViewerWidget(workspace);
                NavigateForward(widget);
            }
        }

        public override void OnNavigationArrivedBack(Widget source)
        {
            UpdateGuiFromModel();
            base.OnNavigationArrivedBack(source);
        }
    }
}