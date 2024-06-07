using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;

namespace PowerAutomation.Widgets
{
    public partial class DetectionsWidget : Widget, IViewWidget<Workspace>
    {
        public DetectionsWidget(Workspace model) : base("Detections")
        {
            Model = model;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public void UpdateGuiFromModel()
        {
            DetectionsListview.Items.Clear();
            DetectionsListview.SmallImageList = new ImageList();
            foreach (var detection in Model.Detections.OrderBy(d => d.Title))
            {
                DetectionsListview.SmallImageList.Images.Add(detection.Key, detection.MatchImage);
                var item = new ListViewItem();
                item.Text = detection.Title;
                item.Tag = detection;
                item.Name = detection.Key;
                item.ImageKey = detection.Key;
                DetectionsListview.Items.Add(item);
                item.SubItems.Add($"t:{detection.Location.Top}, l:{detection.Location.Left}, h:{detection.Location.Height}, w:{detection.Location.Width}");
                item.SubItems.Add(detection.MatchAttempts.ToString());
                item.SubItems.Add($"{detection.MatchAttemptDelayMS}ms");
            }
        }

        public Workspace Model { get; }

        private void CreateDetectionButton_Click(object sender, EventArgs e)
        {
            var detection = Model.Detections.FirstOrDefault(d => d.Key == "AutoSaved");
            if (detection is null)
            {
                detection = new ImageDetection();
                Model.Detections = Model.Detections.Concat(new[] { detection }).OrderBy(d => d.Key).ToArray();
            }
            var widget = new DetectionEditorWidget(Model.Application, detection);
            NavigateForward(widget);
        }

        private void DetectionsListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var detection = DetectionsListview.FocusedItem?.Tag as ImageDetection;
            if (detection is not null)
            {
                var widget = new DetectionEditorWidget(Model.Application, detection);
                NavigateForward(widget);
            }
        }

        public override void OnNavigationArrivedBack(Widget source)
        {
            base.OnNavigationArrivedBack(source);
            UpdateGuiFromModel();
        }
    }
}