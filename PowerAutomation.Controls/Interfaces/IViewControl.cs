namespace PowerAutomation.Controls.Interfaces
{
    public interface IViewControl<TModel> : IViewControl, IControl
    {
        public TModel Model { get; }
    }

    public interface IViewControl : IControl
    {
        public void UpdateGuiFromModel();
    }
}