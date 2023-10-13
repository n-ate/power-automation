﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PowerAutomation
{
    public partial class MainForm : Form
    {
        private static MainForm? _form = null;
        public static MainForm Form
        {
            get
            {
                if (_form is null) throw new InvalidOperationException("Cannot access form before it has been constructed.");
                return _form;
            }
        }
        public MainForm()
        {

            this.TransparencyKey = this.BackColor = Color.Magenta; //makes window background transparent and click-through
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
            mainMenuWidget.Hide();

            this.TopMost = true; //keeps window on top even when other windows are activated
            this.ShowInTaskbar = false;
            //this.ControlBox = false; //removes maximize, minimize, and close buttons from titlebar
            this.FormBorderStyle = FormBorderStyle.None; //removes window chrome

            this.Resize += async (s, e) => await this.EnqueUIChangeToRunAfterDelay("MainForm.Init", 500, c => mainMenuWidget.Show());
            this.Paint += async (s, e) => await this.EnqueUIChangeToRunAfterDelay("MainForm.Init", 500, c => mainMenuWidget.Show());

            _form = this;
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
    }
}
