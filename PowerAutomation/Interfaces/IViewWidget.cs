namespace PowerAutomation.Interfaces
{
    public interface IViewWidget<TModel> : IViewWidget
    {
        public void UpdateFromModel(TModel model);
    }

    public interface IViewWidget
    {
        public void UpdateFromModel(object model);

        void OnBeforeNavigate(IViewWidget destination);
    }
}