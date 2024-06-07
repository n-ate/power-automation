
namespace PowerAutomation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            TransparencyKey = BackColor = App.TransparencyColor; //makes window background transparent and click-through
            WindowState = FormWindowState.Maximized;

            InitializeComponent();
            //mainMenuWidget.Hide();

            TopMost = true; //keeps window on top even when other windows are activated
            ShowInTaskbar = false;
            //ControlBox = false; //removes maximize, minimize, and close buttons from titlebar
            //FormBorderStyle = FormBorderStyle.None; //removes window chrome <-- seems to have been causing controls to resize..

            //Resize += async (s, e) => await this.EnqueueUIChangeToRunAfterDelay("MainForm.Init", 500, c => { mainMenuWidget.Show(); mainMenuWidget.Invalidate(); mainMenuWidget.Update(); });
            //Paint += async (s, e) => await this.EnqueueUIChangeToRunAfterDelay("MainForm.Init", 500, c => { mainMenuWidget.Show(); mainMenuWidget.Invalidate(); mainMenuWidget.Update(); });

            TopNotice.Text = "";
            //TopNotice.SendToBack();

            App.Initialize(this);
        }

        private void TrayIconContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem)
            {
                case var clicked when clicked == AutoHideWidgetsMenuItem:
                    if (AutoHideWidgetsMenuItem.Checked)
                    {
                        //NOTE: don't need this here, instead just subscribe to the check-changed event
                    }
                    else
                    {

                    }
                    break;

                case var clicked when clicked == ExitMenuItem:
                    App.SaveCurrentState();
                    Application.Exit();
                    break;

                case var clicked when clicked == MaximizeMenuItem:
                    WindowState = FormWindowState.Maximized;
                    App.Form.Controls[0].Show();
                    break;

                default: throw new NotImplementedException();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            ////e.Graphics.Clear(Color.Red);
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 2f), 1, 1, this.panel1.Width-2, this.panel1.Height-2);
            ////ControlPaint.DrawBorder(e.Graphics, selectionTool.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);

        }

        private void TopNotice_MouseEnter(object sender, EventArgs e)
        {
            TopNotice.ForeColor = TransparencyKey;
        }

        private void TopNotice_MouseLeave(object sender, EventArgs e)
        {
            TopNotice.ForeColor = Color.Firebrick;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) //toggles window visibility..
        {
            if (App.Form.Controls[0].Visible && WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
                App.Form.Controls[0].Hide();
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                App.Form.Controls[0].Show();
            }
        }
    }
}
