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
            mainMenuWidget = new MainMenuWidget();
            TopNotice = new Label();
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
            // mainMenuWidget
            // 
            mainMenuWidget.BackColor = SystemColors.ActiveCaption;
            mainMenuWidget.Location = new Point(343, 102);
            mainMenuWidget.Name = "mainMenuWidget";
            mainMenuWidget.Size = new Size(200, 233);
            mainMenuWidget.TabIndex = 1;
            // 
            // TopNotice
            // 
            TopNotice.BackColor = Color.Transparent;
            TopNotice.Dock = DockStyle.Top;
            TopNotice.Enabled = false;
            TopNotice.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TopNotice.ForeColor = Color.DodgerBlue;
            TopNotice.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            TopNotice.Location = new Point(0, 0);
            TopNotice.Name = "TopNotice";
            TopNotice.Size = new Size(884, 50);
            TopNotice.TabIndex = 2;
            TopNotice.Text = "Top Notice";
            TopNotice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(TopNotice);
            Controls.Add(mainMenuWidget);
            Name = "MainForm";
            TrayIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem AutoHideWidgetsMenuItem;
        private MainMenuWidget mainMenuWidget;
        public Label TopNotice;
    }
}