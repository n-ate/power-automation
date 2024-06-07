namespace PowerAutomation.Controls.Interfaces
{
    public interface IEditWidget<TModel> : IEditWidget, IViewWidget<TModel>, IViewWidget, IWidget
    {
    }

    public interface IEditWidget : IViewWidget, IWidget
    {
        public void UpdateModelFromGui();
    }
}