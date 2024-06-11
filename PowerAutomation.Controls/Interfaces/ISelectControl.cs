using PowerAutomation.Controls.Models;

namespace PowerAutomation.Controls.Interfaces
{
    public interface ISelectControl<TOptions, TSelection> : IEditControl<ValuePot<TSelection>>, IEditControl, IViewControl<ValuePot<TSelection>>, IViewControl, IControl
    {
        TOptions Options { get; }
    }

    public interface ISelectControl : IEditControl, IViewControl, IControl
    {
        //object GetValue();
        //T GetValue<T>();
    }
}