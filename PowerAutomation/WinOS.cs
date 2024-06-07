using PowerAutomation.Models;
using SimpleImageComparisonClassLibrary.ExtensionMethods;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using Vanara.PInvoke;

namespace PowerAutomation
{
    public static class WinOS
    {
        public static async Task<HWND> FindBestHwndMatch(ApplicationInformation appInfo)
        {
            var matches = new List<(HWND Handle, float MatchPercentage)>();
            foreach (var process in Process.GetProcessesByName(appInfo.ProcessName))
            {
                var points = 2000; //process name
                HWND handle = process.MainWindowHandle;
                var appInfo2 = await GetApplicationInformation(handle);
                points += (int)(2000 * appInfo.Icon.GetPercentageDifference(appInfo2.Icon)); //icon
                if (appInfo.IsWinStoreApp == appInfo2.IsWinStoreApp) points += 2000; //windows store app
                if (appInfo.ModuleName == appInfo2.ModuleName) points += 2000; //module name
                if (appInfo.Class == appInfo2.Class) points += 2000; //class
                matches.Add((handle, points / 10000f));
            }
            var max = matches.Max(m => m.MatchPercentage);
            return matches.Any() ? matches.Single(m => m.MatchPercentage == max).Handle : HWND.NULL;
        }

        public static async Task<ApplicationInformation> GetApplicationInformation(HWND handle)
        {
            var result = new ApplicationInformation();

            (result.ProcessName, result.ModuleName, result.IsWinStoreApp) = await WinOS.GetProcessInfo(handle);

            var icon = WinOS.GetIconForWindow(handle);
            if (icon is not null)
            {
                result.Icon = icon.ToBitmap();
                //using (var stream = File.Create(@"C:\_\temp\app.ico"))
                //{
                //    icon.Save(stream);
                //}
            }

            result.Class = WinOS.GetClassNameForWindow(handle) ?? "<unknown>";

            return result;
        }

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

        public static Process GetProcessFromWindow(HWND handle)
        {
            User32.GetWindowThreadProcessId(handle, out var processId);
            return Process.GetProcessById((int)processId);
        }

        public static async Task<(string Name, string ModuleName, bool IsWinStoreApp)> GetProcessInfo(HWND handle)
        {
            await Task.Delay(250); //application window must be activated..
            var process = WinOS.GetProcessFromWindow(handle);
            var isWinStoreApp = process.ProcessName == "ApplicationFrameHost";

            if (isWinStoreApp)
            {
                var processHandle = GetWindowsStoreAppProcess(handle);
                var processId = Kernel32.GetProcessId(processHandle);
                process = Process.GetProcessById((int)processId);
            }

            var processName = process.ProcessName ?? string.Empty;
            //var mainModuleFilePath = process.MainModule.FileName;
            var mainModuleName = process.MainModule?.ModuleName ?? string.Empty;
            //var mainWindowTitle = process.MainWindowTitle;

            return (processName, mainModuleName, isWinStoreApp);
        }

        public static string? GetWindowTitlebarTextForWindow(HWND handle)
        {
            var builder = new StringBuilder(9999);
            var r = User32.GetWindowText(handle, builder, 9999);
            if (r > 0) return builder.ToString();
            return null;
        }

        public static Bitmap CaptureImage(RECT bounds)
        {
            var snippet = new Bitmap(bounds.Right - bounds.Left, bounds.Bottom - bounds.Top, PixelFormat.Format32bppArgb);
            using (var graphics = Graphics.FromImage(snippet))
            {
                graphics.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, snippet.Size, CopyPixelOperation.SourceCopy);
            }
            return snippet;
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

        private static bool EnumChildWindowsCallback(HWND hWnd, IntPtr lParam)
        {
            var info = (WINDOWINFO2)Marshal.PtrToStructure(lParam, typeof(WINDOWINFO2));
            uint pID;
            User32.GetWindowThreadProcessId(hWnd, out pID);
            if (pID != info.ownerpid) info.childpid = pID;
            Marshal.StructureToPtr(info, lParam, true);
            return true;
        }

        private static Kernel32.SafeHPROCESS GetWindowsStoreAppProcess(HWND handle)
        {
            const UInt32 PROCESS_QUERY_INFORMATION = 0x400;
            const UInt32 PROCESS_VM_READ = 0x010;

            var process = WinOS.GetProcessFromWindow(handle);

            var windowinfo = new WINDOWINFO2();
            windowinfo.ownerpid = (uint)process.Id;
            windowinfo.childpid = windowinfo.ownerpid;

            IntPtr pWindowinfo = Marshal.AllocHGlobal(Marshal.SizeOf(windowinfo));
            Marshal.StructureToPtr(windowinfo, pWindowinfo, false);

            var lpEnumFunc = new User32.EnumWindowsProc(EnumChildWindowsCallback);
            User32.EnumChildWindows(handle, lpEnumFunc, pWindowinfo);

            windowinfo = (WINDOWINFO2)Marshal.PtrToStructure(pWindowinfo, typeof(WINDOWINFO2));

            var safeProcessHandle = Kernel32.OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, false, windowinfo.childpid);

            return safeProcessHandle;
        }

        public static async Task<Bitmap> CaptureImage(HWND handle)
        {
            User32.ShowWindow(handle, ShowWindowCommand.SW_RESTORE);
            User32.SetForegroundWindow(handle);
            //User32.SetActiveWindow(handle);
            //User32.SetFocus(handle);
            //User32.BringWindowToTop(handle);
            await Task.Delay(250);
            if (!User32.GetWindowRect(handle, out var bounds)) throw new NotImplementedException();
            return CaptureImage(bounds);
        }

        private struct WINDOWINFO2
        {
            public uint childpid;
            public uint ownerpid;
        }
    }
}