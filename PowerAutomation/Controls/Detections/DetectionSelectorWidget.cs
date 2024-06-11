using n_ate.Essentials;
using PowerAutomation.Controls.Extensions;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Controls.Models;
using PowerAutomation.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;

namespace PowerAutomation.Controls.Detections
{
    public partial class DetectionSelectorWidget : Widget, ISelectControl<DetectionCollection, IDetection?>
    {
        public DetectionSelectorWidget(DetectionCollection options, ValuePot<IDetection?> model) : base("Select Detection")
        {
            Options = options;
            Model = model;
            InitializeComponent();
        }

        public ValuePot<IDetection?> Model { get; }

        public DetectionCollection Options { get; }

        public void UpdateGuiFromModel()
        {
            var controlCollection = ImageDetectionTemplate.Parent!.Controls;
            int locationY = 16;
            ImageDetectionTemplate.Show();
            foreach (var option in Options)
            {
                Control panel;
                if (option is ImageDetection imageDetection)
                {
                    var spacingY = ImageDetectionTemplate.Height + Math.Max(ImageDetectionTemplate.Margin.Top, ImageDetectionTemplate.Margin.Bottom);
                    panel = ImageDetectionTemplate.Copy(option.Key + "__");
                    panel.Location = new Point { X = ImageDetectionTemplate.Location.X, Y = locationY };
                    locationY += spacingY;
                    var pictureBox = panel.Controls.First<PictureBox>(l => l.Name.EndsWith(DetectionImage.Name));
                    pictureBox.Image = imageDetection.MatchImage.GetResizedImage(pictureBox.Width, pictureBox.Height);
                    panel.Controls.First<Label>(l => l.Name.EndsWith(MinMatchValueLabel.Name)).Text = $"{imageDetection.MinMatchPercentage}%";
                    panel.Controls.First<Label>(l => l.Name.EndsWith(ToleranceValueLabel.Name)).Text = imageDetection.MatchTolerance.ToString();
                    panel.Controls.First<Label>(l => l.Name.EndsWith(RetriesValueLabel.Name)).Text = imageDetection.MatchAttempts.ToString();
                    panel.Controls.First<Label>(l => l.Name.EndsWith(RetryDelayValueLabel.Name)).Text = $"{imageDetection.MatchAttemptDelayMS}ms";
                }
                else throw new NotImplementedException();
                panel.Tag = option;
                panel.Click += Option_Click;
                foreach (Control control in panel.Controls) control.Click += (s, e) => Option_Click(panel, e);
                panel.Controls.First<Label>(l => l.Name.EndsWith(TitleValueLabel.Name)).Text = option.Title;
                controlCollection.Add(panel);
            }
            ImageDetectionTemplate.Hide();
        }

        public void UpdateModelFromGui()
        {
            //Nothing to do; handled in the button click events..
        }

        private void Option_Click(object? sender, EventArgs e)
        {
            if (sender is Panel panel && panel.Tag is IDetection detection)
            {
                Model.Value = detection;
            }
            else throw new NotImplementedException();
            NavigateBackward();
        }
    }
}