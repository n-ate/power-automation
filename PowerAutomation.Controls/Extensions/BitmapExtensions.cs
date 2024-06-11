using SimpleImageComparisonClassLibrary.ExtensionMethods;
using System.Drawing.Imaging;

namespace PowerAutomation.Extensions
{
    public static class BitmapExtensions
    {
        // Luminance vector for linear RGB //
        private const float bwgt = 0.0820f;

        private const float gwgt = 0.6094f;

        private const float rwgt = 0.3086f;

        /// <summary>
        /// Creates a new bitmap with the saturation adjusted.
        /// </summary>
        /// <param name="desiredSaturationPercentage">A non-negative decimal percentage indicating the desired saturation percentage. 1f is 100% and will result in no change. 1.2f is a 20% increase. 0.4f is 40% saturation which is a 60% decrease. </param>
        /// <returns>The saturation adjusted bitmap.</returns>
        public static Bitmap AdjustSaturation(this Bitmap value, float desiredSaturationPercentage)
        {
            var result = new Bitmap(value.Width, value.Height);
            var matrix = new ColorMatrix();
            var baseSat = 1.0f - desiredSaturationPercentage;
            matrix[0, 0] = baseSat * rwgt + desiredSaturationPercentage;
            matrix[0, 1] = baseSat * rwgt;
            matrix[0, 2] = baseSat * rwgt;
            matrix[1, 0] = baseSat * gwgt;
            matrix[1, 1] = baseSat * gwgt + desiredSaturationPercentage;
            matrix[1, 2] = baseSat * gwgt;
            matrix[2, 0] = baseSat * bwgt;
            matrix[2, 1] = baseSat * bwgt;
            matrix[2, 2] = baseSat * bwgt + desiredSaturationPercentage;
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var rectangle = new Rectangle(0, 0, value.Width, value.Height);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(
                    value,
                    rectangle,
                    rectangle.X,
                    rectangle.Y,
                    rectangle.Width,
                    rectangle.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }
            return result;
        }

        public static Image GetResizedImage(this Bitmap subject, int maxWidth, int maxHeight, bool maintainAspectRation = true)
        {
            return subject.GetResizedImage(maxWidth, maxHeight, maintainAspectRation);
        }
    }
}