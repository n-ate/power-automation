using System.Text;
using Vanara.PInvoke;

namespace PowerAutomation
{
    public static class WinOS
    {
        public static string? GetClassNameForWindow(HWND handle)
        {
            var builder = new StringBuilder(9999);
            var r = User32.GetClassName(handle, builder, 9999);
            if (r > 0) return builder.ToString();
            return null;
        }

        public static Icon? GetIconForWindow(HWND handle)
        {
            const int GCL_HICON = -14;
            const int GCL_HICONSM = -34;
            const int ICON_BIG = 1;
            const int ICON_SMALL = 0;
            const int ICON_SMALL2 = 2;
            const int WM_GETICON = 0x7F;

            IntPtr iconHandle = User32.SendMessage(handle, WM_GETICON, (IntPtr)ICON_SMALL2, 0);

            if (iconHandle == IntPtr.Zero) iconHandle = User32.GetClassLong(handle, GCL_HICON);
            if (iconHandle == IntPtr.Zero) iconHandle = User32.GetClassLong(handle, GCL_HICONSM);
            if (iconHandle == IntPtr.Zero) iconHandle = User32.SendMessage(handle, WM_GETICON, (IntPtr)ICON_BIG, 0);
            if (iconHandle == IntPtr.Zero) iconHandle = User32.SendMessage(handle, WM_GETICON, (IntPtr)ICON_SMALL, 0);
            if (iconHandle == IntPtr.Zero) return null;

            return Icon.FromHandle(iconHandle);
        }

        public static string? GetWindowTitlebarTextForWindow(HWND handle)
        {
            var builder = new StringBuilder(9999);
            var r = User32.GetWindowText(handle, builder, 9999);
            if (r > 0) return builder.ToString();
            return null;
        }

        public static async Task<HWND> GetWindowUserActivates(UserControl currentControl)
        {
            var currentWindowHandle = currentControl.ParentForm.Handle;
            var activeWindowHandle = await Task.Run(async () =>
            {
                HWND foregroundWindowHandle;
                do
                {
                    await Task.Delay(50);
                    foregroundWindowHandle = User32.GetForegroundWindow();
                }
                while (foregroundWindowHandle == currentWindowHandle || foregroundWindowHandle == IntPtr.Zero);
                return foregroundWindowHandle;
            });
            return activeWindowHandle;
        }
    }
}