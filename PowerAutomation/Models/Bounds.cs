using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PowerAutomation.Models
{
    public class Bounds
    {
        [Required]
        public int Bottom { get; set; }

        [JsonIgnore]
        public int Height
        {
            get { return Bottom - Top; }
            set { Bottom = Top + value; }
        }

        [Required]
        public int Left { get; set; }

        [Required]
        public int Right { get; set; }

        [Required]
        public int Top { get; set; }

        [JsonIgnore]
        public int Width
        {
            get { return Right - Left; }
            set { Right = Left + value; }
        }
    }
}