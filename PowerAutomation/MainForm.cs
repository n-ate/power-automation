using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerAutomation
{
    public partial class MainForm : Form
    {
        private readonly GlobalEventListener listener;

        public MainForm()
        {
            this.TransparencyKey = this.BackColor = Color.Magenta; //makes window background transparent and click-through

            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

            this.TopMost = true; //keeps window on top even when other windows are activated


            this.ShowInTaskbar = false;
            //this.ControlBox = false; //removes maximize, minimize, and close buttons from titlebar
            this.FormBorderStyle = FormBorderStyle.None; //removes window chrome

            this.MainMenuPanel.EnableDragging(); //makes the panel behave like a draggable widget
            this.MainMenuHeader.EnableDragging(MainMenuPanel); //makes the header of the panel draggable

            //listener = new GlobalEventListener();
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
                    Application.Exit();
                    break;
                default: throw new NotImplementedException();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
