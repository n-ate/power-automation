using PowerAutomation.Models.Detection;
using PowerAutomation.Models.Imitation;
using System.ComponentModel.DataAnnotations;

namespace PowerAutomation.Models
{
    public class SimulatedAction : IProcedure
    {
        /// <summary>
        /// The action to perform that simulates a legitimate user interaction.
        /// </summary>
        [Required]
        public IImitation? Action { get; set; }

        public string Description { get; set; } = string.Empty;

        [Required]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// A condition that must be met after the action is simulated to consider the act a success.
        /// </summary>
        [Required]
        public ImageDetection? Postcondition { get; set; }

        /// <summary>
        /// A condition that must be met before the action is simulated.
        /// </summary>
        [Required]
        public ImageDetection? Precondition { get; set; }

        public string Title { get; set; } = string.Empty;
    }
}