using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;

namespace PowerAutomation.Controls
{
    public partial class DetectionsWidget : Widget, IViewControl<DetectionCollection>
    {
        public DetectionsWidget(ApplicationInformation appInfo, DetectionCollection model) : base("Detections")
        {
            AppInfo = appInfo;
            Model = model;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public ApplicationInformation AppInfo { get; }

        public DetectionCollection Model { get; }

        public override void OnNavigationArrivedBack(Widget source)
        {
            base.OnNavigationArrivedBack(source);
            UpdateGuiFromModel();
        }

        public void UpdateGuiFromModel()
        {
            DetectionsListview.Items.Clear();
            DetectionsListview.SmallImageList = new ImageList();
            foreach (var detection in Model)
            {
                if (detection is ImageDetection imageDetection)
                {
                    DetectionsListview.SmallImageList.Images.Add(detection.Key, imageDetection.MatchImage);
                    var item = new ListViewItem();
                    item.Text = detection.Title;
                    item.Tag = detection;
                    item.Name = detection.Key;
                    item.ImageKey = detection.Key;
                    DetectionsListview.Items.Add(item);
                    item.SubItems.Add($"t:{imageDetection.Location.Top}, l:{imageDetection.Location.Left}, h:{imageDetection.Location.Height}, w:{imageDetection.Location.Width}");
                    item.SubItems.Add(imageDetection.MatchAttempts.ToString());
                    item.SubItems.Add($"{imageDetection.MatchAttemptDelayMS}ms");
                }
                else throw new NotImplementedException();
            }
        }

        private void CreateDetectionButton_Click(object sender, EventArgs e)
        {//TODO: if other detection types are added, rework this image specific logic.
            var detection = Model.FirstOrDefault(d => d.Key == "AutoSaved"); //TODO: rework auto-save logic
            if (detection is null)
            {
                detection = new ImageDetection();
                Model.Add(detection);
            }
            var widget = new ImageDetectionEditorWidget(AppInfo, (ImageDetection)detection);
            NavigateForward(widget);
        }

        private void DetectionsListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var detection = DetectionsListview.FocusedItem?.Tag as ImageDetection;
            if (detection is not null)
            {
                var widget = new ImageDetectionEditorWidget(AppInfo, detection);
                NavigateForward(widget);
            }
        }
    }
}