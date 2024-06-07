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
            //UpdateGuiFromModel();
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
            TitleTextbox.Text = Model.Title;
            IconImage.Image = Model.Application.Icon;
            AppTypeTextbox.Text = Model.Application.IsWinStoreApp ? "Windows Store" : "Default";
            ProcessNameTextbox.Text = Model.Application.ProcessName;
            ModuleNameTextbox.Text = Model.Application.ModuleName;
            ClassTextbox.Text = Model.Application.Class;
            DescriptionTextbox.Text = Model.Description;
        }

        public void UpdateModelFromGui()
        {
            Model.Title = TitleTextbox.Text;
            var icon = IconImage.Image as Bitmap;
            if (icon is not null) Model.Application.Icon = icon;
            Model.Application.IsWinStoreApp = AppTypeTextbox.Text == "Windows Store";
            Model.Application.ProcessName = ProcessNameTextbox.Text;
            Model.Application.ModuleName = ModuleNameTextbox.Text;
            Model.Application.Class = ClassTextbox.Text;
            Model.Description = DescriptionTextbox.Text;
        }

        private void AppInfoTextbox_Click(object sender, EventArgs e)
        {
            SelectApplicationButton.Flash();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            var widget = new WorkspaceViewerWidget(Model);
            NavigateReplace(widget);
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

            //var icon = WinOS.GetIconForWindow(handle);
            //if (icon is not null)
            //{
            //    IconImage.Image = icon.ToBitmap();
            //    using (var stream = File.Create(@"C:\_\temp\app.ico"))
            //    {
            //        icon.Save(stream);
            //    }
            //}

            //ClassTextbox.Text = WinOS.GetClassNameForWindow(handle) ?? "<unknown>";
            //TitlebarTextbox.Text = WinOS.GetWindowTitlebarTextForWindow(handle) ?? "<unknown>";

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
    }
}