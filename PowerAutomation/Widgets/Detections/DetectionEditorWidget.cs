using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;
using Vanara.PInvoke;

namespace PowerAutomation.Widgets
{
    public partial class DetectionEditorWidget : Widget, IEditWidget<ImageDetection>
    {
        private string autoKey = string.Empty;

        public DetectionEditorWidget(ApplicationInformation appInfo, ImageDetection model) : base("Detection Task")
        {
            AppInfo = appInfo;
            Model = model;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public ApplicationInformation AppInfo { get; }
        public ImageDetection Model { get; }

        public Bounds SelectionLocation { get; private set; }

        public override void OnBeforeNavigation(Widget destination)
        {
            base.OnBeforeNavigation(destination);
            UpdateModelFromGui(); //may not need..
            App.SaveCurrentState();
        }

        public override void OnNavigationArrivedBack(Widget source)
        {
            base.OnNavigationArrivedBack(source);
            UpdateGuiFromModel(); //model may have changed while away
        }

        public void UpdateGuiFromModel()
        {
            SelectedImage.Image = Model.MatchImage;
            SelectionLocation = Model.Location;
            LocationLabel.Text = $"top:{SelectionLocation.Top}, left:{SelectionLocation.Left}, h:{SelectionLocation.Height}, w:{SelectionLocation.Width}";
            TitleTextbox.Text = Model.Title;
            KeyTextbox.Text = Model.Key;
            DescriptionTextbox.Text = Model.Description;
            if (Model.Location.Top == 0 && Model.Location.Left == 0 && Model.Location.Bottom == 0 && Model.Location.Right == 0)
            { //default values
                LocationLabel.Text = string.Empty;
            }
            else LocationLabel.Text = $"top:{Model.Location.Top}, left:{Model.Location.Left}, h:{Model.Location.Height}, w:{Model.Location.Width}";
            MatchPercentTrackbar.Value = (int)(Model.MinMatchPercentage * 100);
            MatchPercentLabel.Text = $"{MatchPercentTrackbar.Value}%";
            ToleranceTrackbar.Value = Model.MatchTolerance;
            ToleranceNumberLabel.Text = Model.MatchTolerance.ToString();
            RetriesNumeric.Value = Model.MatchAttempts;
            MSRetryWaitNumeric.Value = Model.MatchAttemptDelayMS;
        }

        public void UpdateModelFromGui()
        {
            Model.MatchImage = (SelectedImage.Image as Bitmap)!;
            Model.Location = SelectionLocation;
            Model.Key = KeyTextbox.Text;
            Model.Title = TitleTextbox.Text;
            Model.Description = DescriptionTextbox.Text;
            Model.MinMatchPercentage = MatchPercentTrackbar.Value / 100f;
            Model.MatchTolerance = ToleranceTrackbar.Value;
            Model.MatchAttempts = (int)RetriesNumeric.Value;
            Model.MatchAttemptDelayMS = (int)MSRetryWaitNumeric.Value;
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
                var widget = new ImageToolsWidget(handle, Model);
                NavigateForward(widget);
            }
        }

        private void TitleTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyTextbox.Text == autoKey) //user has not changed the key
            {
                autoKey = KeyTextbox.Text = TitleTextbox.Text.Replace(" ", "");
                UpdateModelFromGui();
            }
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