
namespace PowerAutomation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            TransparencyKey = BackColor = Color.Magenta; //makes window background transparent and click-through
            WindowState = FormWindowState.Maximized;

            InitializeComponent();
            mainMenuWidget.Hide();

            TopMost = true; //keeps window on top even when other windows are activated
            ShowInTaskbar = false;
            //ControlBox = false; //removes maximize, minimize, and close buttons from titlebar
            FormBorderStyle = FormBorderStyle.None; //removes window chrome

            Resize += async (s, e) => await this.EnqueUIChangeToRunAfterDelay("MainForm.Init", 500, c => { mainMenuWidget.Show(); mainMenuWidget.Invalidate(); mainMenuWidget.Update(); });
            Paint += async (s, e) => await this.EnqueUIChangeToRunAfterDelay("MainForm.Init", 500, c => { mainMenuWidget.Show(); mainMenuWidget.Invalidate(); mainMenuWidget.Update(); });

            TopNotice.Text = "";

            App.Initialize(this);
        }

        private void TrayIconContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem)
            {
                case var clicked when clicked == AutoHideWidgetsMenuItem:
                    if (AutoHideWidgetsMenuItem.Checked)
                    {
                        //NOTE: don't need this here, instead just subscribe to the checkchanged event
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
    }
}
