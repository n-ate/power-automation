// Ignore Spelling: Ctrl

using PowerAutomation.Interfaces;

namespace PowerAutomation.Models.Imitation
{
    public class KeyImitation : IImitation
    {
        public bool Alt { get; set; }
        public int Code { get; set; }
        public bool Ctrl { get; set; }
        public KeyActions KeyAction { get; set; }
        public bool Shift { get; set; }
    }
}