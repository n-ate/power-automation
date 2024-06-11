using PowerAutomation.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PowerAutomation.Models
{
    public class ActionProcedure : IProcedure
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
        public IDetection? Postcondition { get; set; }

        [JsonIgnore]
        public string PostconditionKey
        { get { return Precondition?.Key ?? string.Empty; } }

        /// <summary>
        /// A condition that must be met before the action is simulated.
        /// </summary>
        [Required]
        public IDetection? Precondition { get; set; }

        [JsonIgnore]
        public string PreconditionKey
        { get { return Precondition?.Key ?? string.Empty; } }

        public string Title { get; set; } = string.Empty;
    }
}