using static System.Windows.Forms.Control;

namespace PowerAutomation.Controls.Extensions
{
    public static class ControlCollectionExtensions
    {
        public static Control[] AsArray(this ControlCollection subject)
        {
            var result = new Control[subject.Count];
            subject.CopyTo(result, 0);
            return result;
        }

        public static Control First(this ControlCollection subject, Func<Control, bool> predicate)
            => subject.AsArray().First(predicate);

        public static TControl First<TControl>(this ControlCollection subject, Func<TControl, bool> predicate) where TControl : Control
            => (TControl)subject.AsArray().First(c => c is TControl tc && predicate(tc));

        public static TControl First<TControl>(this ControlCollection subject) where TControl : Control
            => (TControl)subject.AsArray().First(c => c is TControl);

        public static Control? FirstOrDefault(this ControlCollection subject, Func<Control, bool> predicate)
            => subject.AsArray().FirstOrDefault(predicate);

        public static TControl? FirstOrDefault<TControl>(this ControlCollection subject, Func<TControl, bool> predicate) where TControl : Control
            => (TControl?)subject.AsArray().FirstOrDefault(c => c is TControl tc && predicate(tc));

        public static TControl? FirstOrDefault<TControl>(this ControlCollection subject) where TControl : Control
            => (TControl?)subject.AsArray().FirstOrDefault(c => c is TControl);

        public static IEnumerable<Control> Where(this ControlCollection subject, Func<Control, bool> predicate)
            => subject.AsArray().Where(predicate);

        public static IEnumerable<TControl> Where<TControl>(this ControlCollection subject, Func<TControl, bool> predicate) where TControl : Control
            => subject.AsArray().Where(c => c is TControl tc && predicate(tc)).Cast<TControl>();

        public static IEnumerable<TControl> Where<TControl>(this ControlCollection subject) where TControl : Control
            => subject.AsArray().Where(c => c is TControl).Cast<TControl>();
    }
}