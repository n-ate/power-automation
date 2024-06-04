using PowerAutomation.Controls;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;
using System.Reflection;
using Vanara.PInvoke;

namespace PowerAutomation.Widgets
{
    public partial class DetectionEditorWidget : Widget
    {
        private string autoKey = string.Empty;

        public DetectionEditorWidget(Widget caller, ApplicationInformation appInfo, ImageDetection model) : base("Detection Task", caller)
        {
            AppInfo = appInfo;
            Model = model;
            InitializeComponent();
            UpdateFromModel(Model);
        }

        public ApplicationInformation AppInfo { get; }
        public ImageDetection Model { get; }

        public Bounds SelectionLocation { get; private set; }

        public override void OnBeforeNavigate(Widget destination)
        {
            UpdateModel(Model);
            App.SaveCurrentState();
            base.OnBeforeNavigate(destination);
        }

        public override void OnNavigationReturnedBack()
        {
            base.OnNavigationReturnedBack();
            UpdateFromModel(Model); //model may have changed while away
        }

        private void MatchPercentTrackbar_Scroll(object sender, EventArgs e)
        {
            MatchPercentLabel.Text = $"{MatchPercentTrackbar.Value}%";
        }

        private async void SelectImageButton_Click(object sender, EventArgs e)
        {
            var handle = await WinOS.FindBestHwndMatch(AppInfo);
            if (handle == HWND.NULL)
            {
                App.SetNotice("Could not find the application window. Is the application running?");
            }
            else
            {
                var widget = new ImageToolsWidget(this, handle, Model);
                NavigateForward(widget);
            }
        }

        private void TitleTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyTextbox.Text == autoKey) //user has not changed the key
            {
                autoKey = KeyTextbox.Text = TitleTextbox.Text.Replace(" ", "");
                UpdateModel(Model);
            }
        }

        private void UpdateFromModel(ImageDetection model)
        {
            SelectedImage.Image = Model.MatchImage;
            SelectionLocation = model.Location;
            LocationLabel.Text = $"top:{SelectionLocation.Top}, left:{SelectionLocation.Left}, h:{SelectionLocation.Height}, w:{SelectionLocation.Width}";
            TitleTextbox.Text = model.Title;
            KeyTextbox.Text = model.Key;
            DescriptionTextbox.Text = model.Description;
            if (model.Location.Top == 0 && model.Location.Left == 0 && model.Location.Bottom == 0 && model.Location.Right == 0)
            { //default values
                LocationLabel.Text = string.Empty;
            }
            else LocationLabel.Text = $"top:{model.Location.Top}, left:{model.Location.Left}, h:{model.Location.Height}, w:{model.Location.Width}";
            MatchPercentTrackbar.Value = (int)(model.MinMatchPercentage * 100);
            MatchPercentLabel.Text = $"{MatchPercentTrackbar.Value}%";
            ToleranceTrackbar.Value = model.MatchTolerance;
            ToleranceNumberLabel.Text = model.MatchTolerance.ToString();
            RetriesNumeric.Value = model.MatchAttempts;
            MSRetryWaitNumeric.Value = model.MatchAttemptDelayMS;
        }

        private void UpdateModel(ImageDetection model)
        {
            Model.MatchImage = (SelectedImage.Image as Bitmap)!;
            Model.Location = SelectionLocation;
            model.Key = KeyTextbox.Text;
            model.Title = TitleTextbox.Text;
            Model.Description = DescriptionTextbox.Text;
            Model.MinMatchPercentage = MatchPercentTrackbar.Value / 100f;
            Model.MatchTolerance = ToleranceTrackbar.Value;
            Model.MatchAttempts = (int)RetriesNumeric.Value;
            Model.MatchAttemptDelayMS = (int)MSRetryWaitNumeric.Value;
        }

        //public ImageDetection Model { get; }

        //private void TitleTextbox_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (KeyTextbox.Text == autoKey) //user has not changed the key
        //    {
        //        autoKey = KeyTextbox.Text = TitleTextbox.Text.Replace(" ", "");
        //        UpdateModel(Model);
        //    }
        //}

        //private async void SelectImageButton_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    var selection = await App.UserImageSelect();
        //    SelectedImage.Image = Model.MatchImage = selection.Image;
        //    Model.Location.Top = selection.Bounds.Top;
        //    Model.Location.Left = selection.Bounds.Left;
        //    Model.Location.Height = selection.Bounds.Height;
        //    Model.Location.Width = selection.Bounds.Width;
        //    LocationLabel.Text = $"top:{Model.Location.Top}, left:{Model.Location.Left}, h:{Model.Location.Height}, w:{Model.Location.Width}";
        //    Show();
        //}

        //private void MatchPercentTrackbar_Scroll(object sender, EventArgs e)
        //{
        //    MatchPercentLabel.Text = $"{MatchPercentTrackbar.Value}%";
        //}

        //public override void OnBeforeNavigate(Widget destination)
        //{
        //    UpdateModel(Model);
        //    App.SaveCurrentState();
        //    base.OnBeforeNavigate(destination);
        //}

        //public override void OnNavigationReturnedBack()
        //{
        //    base.OnNavigationReturnedBack();
        //    UpdateFromModel(Model); //model may have changed while away
        //}
    }
}