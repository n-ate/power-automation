namespace PowerAutomation.Controls.Models
{
    /// <summary>
    /// Simple class for treating a value type like a reference type.
    /// </summary>
    /// <typeparam name="TValue">They type of value.</typeparam>
    public class ValuePot<TValue>
    {
        public ValuePot(TValue value)
        {
            Value = value;
        }

        public TValue Value { get; set; }
    }
}