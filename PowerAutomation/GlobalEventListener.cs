using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerAutomation
{
    public class GlobalEventListener : IDisposable
    {
        private readonly IKeyboardMouseEvents hook;

        public string Handle { get; internal set; } = string.Empty
            ;

        public GlobalEventListener()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            //hook = Hook.GlobalEvents();

            hook.MouseClick += Hook_MouseClick;
        }

        private void Hook_MouseClick(object? sender, MouseEventArgs e)
        {
            //var s = sender as Gma.System.MouseKeyHook.Implementation.GlobalMouseListener;
            //var args = e as Gma.System.MouseKeyHook.MouseEventExtArgs;

        }

        //public void Subscribe()
        //{
        //    m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
        //    m_GlobalHook.KeyPress += GlobalHookKeyPress;
        //}

        //private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        //{
        //    Console.WriteLine("KeyPress: \t{0}", e.KeyChar);
        //}

        //private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        //{
        //    Console.WriteLine("MouseDown: \t{0}; \t System Timestamp: \t{1}", e.Button, e.Timestamp);

        //    // uncommenting the following line will suppress the middle mouse button click
        //    // if (e.Buttons == MouseButtons.Middle) { e.Handled = true; }
        //}

        //public void Unsubscribe()
        //{
        //    m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
        //    m_GlobalHook.KeyPress -= GlobalHookKeyPress;

        //}

        public void Dispose()
        {
            hook.MouseClick -= Hook_MouseClick;
            hook.Dispose();
        }
    }
}
