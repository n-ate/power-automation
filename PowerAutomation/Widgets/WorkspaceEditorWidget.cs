using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;
using System.Drawing.Imaging;
using Vanara.PInvoke;

namespace PowerAutomation.Widgets
{
    public partial class WorkspaceEditorWidget : Widget, IEditWidget<Workspace>
    {
        public WorkspaceEditorWidget(Workspace model) : base("Workspace")
        {
            Model = model;
            InitializeComponent();
        }

        public Workspace Model { get; }

        public override void OnBeforeNavigation(Widget destination)
        {
            if (string.IsNullOrEmpty(TitleTextbox.Text))
            {
                TitleTextbox.Text = "AutoSaved";
            }

            UpdateModelFromGui();
            App.SaveCurrentState();
        }

        public override void OnNavigationArrivedBack(Widget source)
        {
            base.OnNavigationArrivedBack(source);
            UpdateGuiFromModel();
        }

        public void UpdateGuiFromModel()
        {
            IconImage.Image = Model.Application.Icon;
            ClassTextbox.Text = Model.Application.Class;
            TitlebarTextbox.Text = Model.Application.Titlebar;
            TitleTextbox.Text = Model.Title;
            DescriptionTextbox.Text = Model.Description;
        }

        public void UpdateModelFromGui()
        {
            var icon = IconImage.Image as Bitmap;
            if (icon is not null) Model.Application.Icon = icon;
            Model.Application.Class = ClassTextbox.Text;
            Model.Application.Titlebar = TitlebarTextbox.Text;
            Model.Title = TitleTextbox.Text;
            Model.Description = DescriptionTextbox.Text;
        }

        private void AppInfoTextbox_Click(object sender, EventArgs e)
        {
            SelectApplicationButton.Flash();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            //TODO: Navigate forward should set the caller, also navigate replace..~
            var widget = new WorkspaceViewerWidget(Model); //use call so that navigate backward will skip this control
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
                image.Save("C:\\_\\temp\\test.png", ImageFormat.Png);//TODO: keep images in memory and saved to workspace..
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
    }
}