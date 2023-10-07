using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerAutomation
{
    public static class DraggableControlExtensions
    {
        // TKey is control to drag, TValue is a flag used while dragging
        private static Dictionary<Control, (bool IsDragging, Control Target)> draggable = new Dictionary<Control, (bool, Control)>();
        private static Point mouseOffset; //mouse location is relative to control
        private static Point targetsOffset; //targets location is relative to handle location
        private static Cursor? defaultCurrentCursor = null;
        private static List<Action<string>> capturedEventsHandlers = new List<Action<string>>();

        public static void HandleCapturedEvents(Action<string> capturedEventsHandler)
        {
            capturedEventsHandlers.Add(capturedEventsHandler);
        }

        /// <summary>
        /// Enable dragging for control
        /// </summary>
        public static void EnableDragging(this Control handle, Control? target = null)
        {
            if (draggable.ContainsKey(handle)) return;

            draggable.Add(handle, (false, target ?? handle));
            //// assign required event handlersnnn
            //handle.MouseClick += new MouseEventHandler((s, e) => { foreach (var handler in capturedEventsHandlers) handler("mouse click"); });
            //handle.Click += new EventHandler((s, e) => { foreach (var handler in capturedEventsHandlers) handler("       click"); });
            ////handle.
            handle.MouseDown += new MouseEventHandler(control_MouseDown);
            handle.MouseUp += new MouseEventHandler(control_MouseUp);
            handle.MouseMove += new MouseEventHandler(control_MouseMove);
        }

        /// <summary>
        /// Disable dragging for control
        /// </summary>
        public static void DisableDragging(this Control handle)
        {
            if (!draggable.ContainsKey(handle)) return;

            handle.MouseDown -= control_MouseDown;
            handle.MouseUp -= control_MouseUp;
            handle.MouseMove -= control_MouseMove;
            draggable.Remove(handle);
        }

        private static void control_MouseDown(object? sender, MouseEventArgs e)
        {
            var handle = sender as Control;
            if (handle is not null)
            {
                var value = draggable[handle];
                foreach (var handler in capturedEventsHandlers) handler("mouse down");
                mouseOffset = e.Location;
                targetsOffset = new Point(value.Target.Location.X - handle.Location.X, value.Target.Location.Y - handle.Location.Y);
                draggable[handle] = (true, value.Target);
                defaultCurrentCursor = Cursor.Current;
                Cursor.Current = Cursors.SizeAll;
            }
        }
        private static void control_MouseUp(object? sender, MouseEventArgs e)
        {
            var handle = sender as Control;
            if (handle is not null)
            {
                if (draggable[handle].IsDragging)
                {
                    var value = draggable[handle];
                    foreach (var handler in capturedEventsHandlers) handler("mouse  up ");
                    draggable[handle] = (false, value.Target);
                    Cursor.Current = defaultCurrentCursor;
                    defaultCurrentCursor = null;
                }
            }
        }
        private static void control_MouseMove(object? sender, MouseEventArgs e)
        {
            var handle = sender as Control;
            if (handle is not null)
            {
                // only if dragging is turned on
                if (draggable[handle].IsDragging)
                {
                    var value = draggable[handle];
                    foreach (var handler in capturedEventsHandlers) handler("mouse move");
                    var mousePositionChangeRelativeToHandle = new Point(e.Location.X - mouseOffset.X, e.Location.Y - mouseOffset.Y); // calculate mouse position change since dragging began
                    if (handle == value.Target || handle.IsChildOf(value.Target))
                    {
                        value.Target.Left += mousePositionChangeRelativeToHandle.X;
                        value.Target.Top += mousePositionChangeRelativeToHandle.Y;
                    }
                    else
                    {
                        handle.Left += mousePositionChangeRelativeToHandle.X;
                        handle.Top += mousePositionChangeRelativeToHandle.Y;
                        value.Target.Left = handle.Left + targetsOffset.X;
                        value.Target.Top = handle.Top + targetsOffset.Y;
                    }
                }
            }
        }
    }
}
