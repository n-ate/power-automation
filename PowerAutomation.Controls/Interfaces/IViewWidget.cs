namespace PowerAutomation.Controls.Interfaces
{
    public interface IViewWidget<TModel> : IViewWidget, IWidget
    {
        public TModel Model { get; }
    }

    public interface IViewWidget : IWidget
    {
        public void UpdateGuiFromModel();
    }
}