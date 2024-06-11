using PowerAutomation.Interfaces;

namespace PowerAutomation.Models.Imitation
{
    public class ClickImitation : IImitation
    {
        public ClickType Type { get; set; } = ClickType.LeftClick;
        public int XOffset { get; set; }
        public int YOffset { get; set; }
    }
}