using PowerAutomation.Controls;

namespace PowerAutomation.Widgets
{
    public partial class ImageAnnotationWidget : Widget
    {
        public ImageAnnotationWidget(Widget caller) : base("Annotation", caller)
        {
            InitializeComponent();
        }
    }
}