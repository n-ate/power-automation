using PowerAutomation.Controls;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;

namespace PowerAutomation.Widgets
{
    public partial class DetectionEditorWidget : Widget
    {
        private string autoKey = string.Empty;

        public DetectionEditorWidget(Widget caller, ImageDetection model) : base("Detection Task", caller)
        {
            Model = model;
            InitializeComponent();
            UpdateFromModel(Model);
        }

        public ImageDetection Model { get; }

        public Bounds SelectionLocation { get; private set; }

        public override void OnBeforeNavigate()
        {
            UpdateModel(Model);
            App.SaveCurrentState();
            base.OnBeforeNavigate();
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
            Hide();
            var selection = await App.UserImageSelect();
            SelectedImage.Image = selection.Image;
            SelectionLocation = new Bounds()
            {
                Top = selection.Bounds.Top,
                Left = selection.Bounds.Left,
                Height = selection.Bounds.Height,
                Width = selection.Bounds.Width
            };
            LocationLabel.Text = $"top:{SelectionLocation.Top}, left:{SelectionLocation.Left}, h:{SelectionLocation.Height}, w:{SelectionLocation.Width}";
            Show();
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
    }
}