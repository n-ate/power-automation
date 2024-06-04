using PowerAutomation.Controls;
using PowerAutomation.Interfaces;
using PowerAutomation.Models;
using System.Drawing.Imaging;
using Vanara.PInvoke;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceEditorWidget : Widget, IViewWidget<Workspace>
    {
        private Workspace Model;

        public WorkspaceEditorWidget(Widget caller, Workspace model) : base("Workspace", caller)
        {
            Model = model;
            InitializeComponent();
            UpdateFromModel(Model);
        }

        public override void OnBeforeNavigate(IViewWidget destination)
        {
            if (string.IsNullOrEmpty(TitleTextbox.Text))
            {
                TitleTextbox.Text = "AutoSaved";
            }

            UpdateModel();
            App.SaveCurrentState();
            destination.UpdateFromModel(Model);
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
            if (!User32.GetWindowRect(handle, out var bounds)) throw new NotImplementedException();

            await Task.Delay(200); //give time to the window to open; may have selected from taskbar
            using (var image = App.CaptureImage(bounds))
            {
                Directory.CreateDirectory("C:\\_\\temp\\");
                image.Save("C:\\_\\temp\\test.png", ImageFormat.Png);
                //var difference = image.GetPercentageDifference(image, 0);
            }

            var icon = WinOS.GetIconForWindow(handle);
            if (icon is not null)
            {
                IconImage.Image = icon.ToBitmap();
                using (var stream = File.Create(@"C:\_\temp\app.ico"))
                {
                    icon.Save(stream);
                }
            }

            ClassTextbox.Text = WinOS.GetClassNameForWindow(handle) ?? "<unknown>";
            TitlebarTextbox.Text = WinOS.GetWindowTitlebarTextForWindow(handle) ?? "<unknown>";

            Show();
            App.SetNotice("");
            //NavigateForward(new ImageAnnotationWidget(this));
        }

        public void UpdateFromModel(Workspace model)
        {
            IconImage.Image = model.Application.Icon;
            ClassTextbox.Text = model.Application.Class;
            TitlebarTextbox.Text = model.Application.Titlebar;
            TitleTextbox.Text = model.Title;
            DescriptionTextbox.Text = model.Description;
        }

        public override void UpdateFromModel(object model)
        {
            if (model is Workspace m) UpdateFromModel(m);
            else throw new ArgumentException($"Model argument is not correct type. Expected:{nameof(Workspace)}, Actual:{model.GetType().Name}");
        }

        private void UpdateModel()
        {
            var icon = IconImage.Image as Bitmap;
            if (icon is not null) Model.Application.Icon = icon;
            Model.Application.Class = ClassTextbox.Text;
            Model.Application.Titlebar = TitlebarTextbox.Text;
            Model.Title = TitleTextbox.Text;
            Model.Description = DescriptionTextbox.Text;
        }
    }
}