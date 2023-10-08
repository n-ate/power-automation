namespace PowerAutomation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TrayIcon = new NotifyIcon(components);
            TrayIconContextMenu = new ContextMenuStrip(components);
            ExitMenuItem = new ToolStripMenuItem();
            AutoHideWidgetsMenuItem = new ToolStripMenuItem();
            mainMenuWidget1 = new MainMenuWidget();
            TrayIconContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TrayIcon
            // 
            TrayIcon.BalloonTipIcon = ToolTipIcon.Warning;
            TrayIcon.BalloonTipText = "Text";
            TrayIcon.BalloonTipTitle = "Title";
            TrayIcon.ContextMenuStrip = TrayIconContextMenu;
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Tag = "Tag";
            TrayIcon.Text = "Power Automation";
            TrayIcon.Visible = true;
            // 
            // TrayIconContextMenu
            // 
            TrayIconContextMenu.Items.AddRange(new ToolStripItem[] { ExitMenuItem, AutoHideWidgetsMenuItem });
            TrayIconContextMenu.Name = "TrayIconContextMenu";
            TrayIconContextMenu.Size = new Size(173, 48);
            TrayIconContextMenu.ItemClicked += TrayIconContextMenu_ItemClicked;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(172, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.ToolTipText = "Exits Power Automation";
            // 
            // AutoHideWidgetsMenuItem
            // 
            AutoHideWidgetsMenuItem.CheckOnClick = true;
            AutoHideWidgetsMenuItem.Name = "AutoHideWidgetsMenuItem";
            AutoHideWidgetsMenuItem.Size = new Size(172, 22);
            AutoHideWidgetsMenuItem.Text = "Auto-hide widgets";
            // 
            // mainMenuWidget1
            // 
            mainMenuWidget1.BackColor = SystemColors.ActiveCaption;
            mainMenuWidget1.Location = new Point(210, 104);
            mainMenuWidget1.Name = "mainMenuWidget1";
            mainMenuWidget1.Size = new Size(200, 233);
            mainMenuWidget1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuWidget1);
            Name = "MainForm";
            Text = "Form2";
            TrayIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem AutoHideWidgetsMenuItem;
        private MainMenuWidget createTaskWidget1;
        private MainMenuWidget mainMenuWidget1;
    }
}