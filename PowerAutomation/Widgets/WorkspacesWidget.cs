using PowerAutomation.Controls;
using PowerAutomation.Extensions;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspacesWidget : Widget, IViewWidget<WorkspaceCollection>
    {
        public WorkspaceCollection Model{ get; }

        public WorkspacesWidget(WorkspaceCollection model) : base("Workspaces")
        {
            Model = model;
            InitializeComponent();
        }

        public void UpdateGuiFromModel()
        {
            WorkspacesListview.Items.Clear();
            WorkspacesListview.SmallImageList = new ImageList();
            foreach (var workspace in Model.Where(w => ShowInactiveCheckbox.Checked || w.Active))
            {
                var icon = workspace.Active ? workspace.Application.Icon : workspace.Application.Icon.AdjustSaturation(0);
                WorkspacesListview.SmallImageList.Images.Add(workspace.Title, icon);
                var item = new ListViewItem()
                {
                    Text = workspace.Title,
                    Tag = workspace,
                    Name = workspace.Title,
                    ImageKey = workspace.Title
                };
                item.SubItems.Add(workspace.Application.Titlebar);
                if(!workspace.Active) item.ForeColor = Color.Gray;
                WorkspacesListview.Items.Add(item);
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

        private void ShowInactiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuiFromModel();
        }
    }
}