using PowerAutomation.Controls;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspacesWidget : Widget
    {
        public WorkspacesWidget(Widget caller) : base("Workspaces", caller)
        {
            InitializeComponent();
            UpdateFromModel(App.Workspaces);
        }

        private void UpdateFromModel(Workspace[] model)
        {
            WorkspacesListview.SmallImageList = new ImageList();
            foreach (var workspace in App.Workspaces.OrderBy(d => d.Title))
            {
                WorkspacesListview.SmallImageList.Images.Add(workspace.Title, workspace.Application.Icon);
                var item = new ListViewItem();
                item.Text = workspace.Title;
                item.Tag = workspace;
                item.Name = workspace.Title;
                item.ImageKey = workspace.Title;
                WorkspacesListview.Items.Add(item);
                item.SubItems.Add(workspace.Application.Titlebar);
            }
        }

        private void CreateWorkspaceButton_Click(object sender, EventArgs e)
        {
            var workspace = App.Workspaces.FirstOrDefault(d => d.Title == "AutoSaved");
            if (workspace is null)
            {
                workspace = new Workspace();
                App.Workspaces = App.Workspaces.Concat(new[] { workspace }).OrderBy(d => d.Title).ToArray();
            }
            var widget = new WorkspaceEditorWidget(this, workspace);
            NavigateForward(widget);
        }

        private void WorkspacesListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var workspace = WorkspacesListview.FocusedItem?.Tag as Workspace;
            if (workspace is not null)
            {
                var widget = new WorkspaceViewerWidget(this, workspace);
                NavigateForward(widget);
            }
        }

        public void OnBeforeNavigate(Widget destination)
        {
        }

        public override void OnNavigationReturnedBack()
        {
            UpdateFromModel(App.Workspaces);

            base.OnNavigationReturnedBack();
        }
    }
}