using PowerAutomation.Models.Detection;
using System.ComponentModel.DataAnnotations;

namespace PowerAutomation.Models
{
    public class Workspace
    {
        [Required]
        public ApplicationInformation Application { get; set; } = new ApplicationInformation();

        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Detection operations return true if the condition to detect is found.
        /// </summary>
        [Required]
        public ImageDetection[] Detections { get; set; } = new ImageDetection[0];

        [Required]
        public IProcedure[] Procedures { get; set; } = new IProcedure[0];

        [Required]
        public string Title { get; set; } = string.Empty;
    }
}