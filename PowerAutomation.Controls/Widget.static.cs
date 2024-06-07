namespace PowerAutomation.Controls
{
    public partial class Widget
    {
        public static readonly Widget ApplicationRoot = new Widget(nameof(ApplicationRoot));
        public static readonly Widget NotInitialized = new Widget(nameof(NotInitialized));
    }
}