using System.Collections.Concurrent;

namespace PowerAutomation
{
    public static class ControlExtensions
    {
        private static ConcurrentDictionary<string, CancellationTokenSource> _enquedUIChanges = new ConcurrentDictionary<string, CancellationTokenSource>();

        /// <summary>
        /// Runs the action after the delay has occured. If called again during the delay, the delay is restarted.
        /// </summary>
        /// <param name="key">A unique key to isolate this action run from others.</param>
        /// <param name="delay">How long to wait for additional calls before firing the action.</param>
        /// <param name="action">The action to perform.</param>
        public static async Task EnqueUIChangeToRunAfterDelay<T>(this T control, string key, int delay, Action<T> action)
            where T : Control
        {
            var source = _enquedUIChanges.AddOrUpdate(key, new CancellationTokenSource(), (k, s) => { s.Cancel(false); return new CancellationTokenSource(); });
            try
            {
                await Task.Factory.StartNew(async () =>
                {
                    await Task.Delay(delay);
                    if (_enquedUIChanges.TryRemove(key, out var source))
                    {
                        if (source.Token.IsCancellationRequested) return;
                        control.ExecuteOnUIThread(action); //only run if delay has passed and no new actions are fired
                    }
                }, source.Token);
            }
            catch (TaskCanceledException) { }
        }

        /// <summary>
        /// Executes the Action asynchronously on the UI thread, does not block execution on the calling thread.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="action"></param>
        public static void ExecuteOnUIThread<T>(this T control, Action<T> action)
            where T : Control
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(() => action(control));
            }
            else
            {
                action.Invoke(control);
            }
        }

        /// <summary>
        /// Flashes the control to draw attention.
        /// </summary>
        public static void Flash(this Control control, int flashCount = 2)
        {
            switch (control)
            {
                case Label label:
                    FlashLabel(label, Color.Red, flashCount * 2);
                    break;

                case Button button:
                    FlashButton(button, FlatStyle.Flat, Color.LightYellow, Color.DarkGray, flashCount * 2);
                    break;

                default: throw new NotImplementedException();
            }

            static void FlashLabel(Label label, Color foreColor, int iterations, int count = 1)
            {
                var xForeColor = label.ForeColor;

                label.ExecuteOnUIThread(l =>
                {
                    l.ForeColor = foreColor;
                });

                if (count < iterations)
                {
                    Task.Run(async () =>
                    {
                        if (count % 2 == 0) await Task.Delay(300);
                        else await Task.Delay(300);
                        FlashLabel(label, xForeColor, iterations, count + 1);
                    });
                }
            }

            static void FlashButton(Button button, FlatStyle style, Color backColor, Color borderColor, int iterations, int count = 1)
            {
                var xBackColor = button.BackColor;
                var xBorderColor = button.FlatAppearance.BorderColor;
                var xStyle = button.FlatStyle;

                button.ExecuteOnUIThread(b =>
                {
                    b.BackColor = backColor;
                    b.FlatAppearance.BorderColor = borderColor;
                    b.FlatStyle = style;
                });

                if (count < iterations)
                {
                    Task.Run(async () =>
                    {
                        if (count % 2 == 0) await Task.Delay(300);
                        else await Task.Delay(50);
                        FlashButton(button, xStyle, xBackColor, xBorderColor, iterations, count + 1);
                    });
                }
            }
        }

        /// <summary>
        /// Gets the current z-order of the control amongst its siblings
        /// </summary>
        public static int GetZOrder(this Control control)
        {
            return control.Parent.Controls.GetChildIndex(control);
        }

        public static bool IsChildOf(this Control child, Control parent)
        {
            while (child.Parent is not null)
            {
                if (child.Parent == parent) return true;
                else child = child.Parent;
            }
            return false;
        }

        public static bool IsParentOf(this Control parent, Control child)
        {
            return child.IsChildOf(parent);
        }

        /// <summary>
        /// Gets the current z-order of the control amongst its siblings
        /// </summary>
        public static void SetZOrder(this Control control, int zOrder)
        {
            control.Parent.Controls.SetChildIndex(control, zOrder);
        }
    }
}