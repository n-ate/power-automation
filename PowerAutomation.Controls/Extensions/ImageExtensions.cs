using SimpleImageComparisonClassLibrary.ExtensionMethods;

namespace PowerAutomation.Controls.Extensions
{
    public static class ImageExtensions
    {
        public static Image GetResizedImage(this Image subject, int maxWidth, int maxHeight, bool maintainAspectRation = true)
        {
            if (maintainAspectRation)
            {
                var widthRatio = subject.Width / (float)maxWidth;
                var heighthRatio = subject.Height / (float)maxHeight;
                var maxRatio = Math.Max(widthRatio, heighthRatio);
                maxWidth = (int)(subject.Width / maxRatio);
                maxHeight = (int)(subject.Height / maxRatio);
            }
            return subject.GetResizedVersion(maxWidth, maxHeight);
        }
    }
}