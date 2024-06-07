using System.ComponentModel.DataAnnotations;
using System.Drawing.Imaging;
using System.Text.Json.Serialization;

namespace PowerAutomation.Models.Detection
{
    public class ImageDetection
    {
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Key { get; set; } = string.Empty;

        [Required]
        public Bounds Location { get; set; } = new Bounds();

        [Required]
        public int MatchAttemptDelayMS { get; set; } = 30;

        [Required]
        public int MatchAttempts { get; set; } = 1;

        [Required]
        public string matchImage { get; set; }

        [JsonIgnore]
        public Bitmap MatchImage
        {
            get
            {
                if (string.IsNullOrEmpty(matchImage)) return new Bitmap(1, 1);
                var bytes = Convert.FromBase64String(matchImage);
                using (var stream = new MemoryStream(bytes))
                {
                    stream.Flush();
                    stream.Position = 0;
                    return new Bitmap(stream);
                }
            }
            set
            {
                using (var stream = new MemoryStream())
                {
                    value.Save(stream, ImageFormat.Png);
                    stream.Flush();
                    stream.Position = 0;
                    matchImage = Convert.ToBase64String(stream.ToArray());
                }
            }
        }

        public int MatchTolerance { get; set; } = 3;

        public float MinMatchPercentage { get; set; } = 0.99f;
        public string Title { get; set; } = string.Empty;
    }
}