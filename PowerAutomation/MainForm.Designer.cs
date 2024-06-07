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
            MaximizeMenuItem = new ToolStripMenuItem();
            TopNotice = new Label();
            mainMenuWidget = new MenuWidget();
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
            TrayIconContextMenu.Items.AddRange(new ToolStripItem[] { ExitMenuItem, AutoHideWidgetsMenuItem, MaximizeMenuItem });
            TrayIconContextMenu.Name = "TrayIconContextMenu";
            TrayIconContextMenu.Size = new Size(173, 70);
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
            // MaximizeMenuItem
            // 
            MaximizeMenuItem.Name = "MaximizeMenuItem";
            MaximizeMenuItem.Size = new Size(172, 22);
            MaximizeMenuItem.Text = "Maximize";
            // 
            // TopNotice
            // 
            TopNotice.Dock = DockStyle.Top;
            TopNotice.Font = new Font("Tahoma", 28F, FontStyle.Bold);
            TopNotice.ForeColor = Color.Firebrick;
            TopNotice.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            TopNotice.Location = new Point(0, 0);
            TopNotice.Name = "TopNotice";
            TopNotice.Size = new Size(884, 50);
            TopNotice.TabIndex = 2;
            TopNotice.Text = "{notice}";
            TopNotice.TextAlign = ContentAlignment.MiddleCenter;
            TopNotice.MouseEnter += TopNotice_MouseEnter;
            TopNotice.MouseLeave += TopNotice_MouseLeave;
            // 
            // mainMenuWidget
            // 
            mainMenuWidget.BackColor = SystemColors.ActiveCaption;
            mainMenuWidget.Location = new Point(334, 93);
            mainMenuWidget.Name = "mainMenuWidget";
            mainMenuWidget.Size = new Size(200, 288);
            mainMenuWidget.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(884, 661);
            Controls.Add(mainMenuWidget);
            Controls.Add(TopNotice);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            TrayIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem AutoHideWidgetsMenuItem;
        public Label TopNotice;
        private ToolStripMenuItem MaximizeMenuItem;
        private MenuWidget mainMenuWidget;
    }
}