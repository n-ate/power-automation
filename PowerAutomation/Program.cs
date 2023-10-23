namespace PowerAutomation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.SetDefaultFont(new Font(new FontFamily("Tahoma"), 12f));

            Application.Run(new MainForm());
        }
    }

    //class CaptureEvents : IMessageFilter
    //{
    //    #region IMessageFilter Members
    //    public delegate void Callback(int message);
    //    public event Callback MessageReceived;

    //    IntPtr ownerWindow;
    //    Hashtable interestedMessages = null;
    //    CaptureEvents(IntPtr handle, int[] messages)
    //    {
    //        ownerWindow = handle;
    //        for (int c = 0; c < messages.Length; c++)
    //        {
    //            interestedMessages[messages[c]] = 0;
    //        }
    //    }
    //    public bool PreFilterMessage(ref Message m)
    //    {
    //        if (m.HWnd == ownerWindow && interestedMessages.ContainsKey(m.Msg))
    //        {
    //            MessageReceived(m.Msg);
    //        }
    //        return true;
    //    }

    //    #endregion
    //}
}