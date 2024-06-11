namespace PowerAutomation.Controls.Interfaces
{
    public interface IEditControl<TModel> : IEditControl, IViewControl<TModel>, IViewControl, IControl
    {
    }

    public interface IEditControl : IViewControl, IControl
    {
        public void UpdateModelFromGui();
    }
}