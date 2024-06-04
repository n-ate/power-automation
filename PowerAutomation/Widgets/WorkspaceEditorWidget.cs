using PowerAutomation.Controls;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceEditorWidget : Widget
    {
        private Workspace Model;

        public WorkspaceEditorWidget(Widget caller, Workspace model) : base("Workspace", caller)
        {
            Model = model;
            InitializeComponent();
            UpdateFromModel(Model);
        }

        public override void OnBeforeNavigate(Widget destination)
        {
            if (string.IsNullOrEmpty(TitleTextbox.Text))
            {
                TitleTextbox.Text = "AutoSaved";
            }

            UpdateModel(Model);
            App.SaveCurrentState();

            base.OnBeforeNavigate(destination);
        }

        public override void OnNavigationReturnedBack()
        {
            base.OnNavigationReturnedBack();

            UpdateFromModel(Model);
        }

        private void AppInfoTextbox_Click(object sender, EventArgs e)
        {
            SelectApplicationButton.Flash();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            var widget = new WorkspaceViewerWidget(this, Model);
            NavigateForward(widget);
        }

        private async void SelectApplicationButton_Click(object sender, EventArgs e)
        {
            App.SetNotice("Select the application to automate.");
            Hide();

            var handle = await WinOS.GetWindowUserActivates(this);
            //if (!User32.GetWindowRect(handle, out var bounds)) throw new NotImplementedException();
            //await Task.Delay(200); //give time to the window to open; may have selected from taskbar
            //using (var image = App.CaptureImage(bounds))
            //{
            //    Directory.CreateDirectory("C:\\_\\temp\\");
            //    image.Save("C:\\_\\temp\\test.png", ImageFormat.Png);
            //    //var difference = image.GetPercentageDifference(image, 0);
            //}

            var info = await WinOS.GetApplicationInformation(handle);
            IconImage.Image = info.Icon;
            AppTypeTextbox.Text = info.IsWinStoreApp ? "Windows Store" : "Default";
            ProcessNameTextbox.Text = info.ProcessName;
            ModuleNameTextbox.Text = info.ModuleName;
            ClassTextbox.Text = info.Class;

            Show();
            App.SetNotice("");
            //NavigateForward(new ImageAnnotationWidget(this));
        }

        private void UpdateFromModel(Workspace model)
        {
            TitleTextbox.Text = model.Title;
            IconImage.Image = model.Application.Icon;
            AppTypeTextbox.Text = model.Application.IsWinStoreApp ? "Windows Store" : "Default";
            ProcessNameTextbox.Text = model.Application.ProcessName;
            ModuleNameTextbox.Text = model.Application.ModuleName;
            ClassTextbox.Text = model.Application.Class;
            DescriptionTextbox.Text = model.Description;
        }

        private void UpdateModel(Workspace model)
        {
            model.Title = TitleTextbox.Text;
            var icon = IconImage.Image as Bitmap;
            if (icon is not null) model.Application.Icon = icon;
            model.Application.IsWinStoreApp = AppTypeTextbox.Text == "Windows Store";
            model.Application.ProcessName = ProcessNameTextbox.Text;
            model.Application.ModuleName = ModuleNameTextbox.Text;
            model.Application.Class = ClassTextbox.Text;
            model.Description = DescriptionTextbox.Text;
        }
    }
}