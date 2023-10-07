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
            MainMenuPanel = new Panel();
            MainMenuHeader = new Label();
            SettingsButton = new Button();
            CreateButton = new Button();
            LoadButton = new Button();
            TrayIcon = new NotifyIcon(components);
            TrayIconContextMenu = new ContextMenuStrip(components);
            ExitMenuItem = new ToolStripMenuItem();
            AutoHideWidgetsMenuItem = new ToolStripMenuItem();
            MainMenuPanel.SuspendLayout();
            TrayIconContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuPanel
            // 
            MainMenuPanel.BackColor = SystemColors.ActiveCaption;
            MainMenuPanel.Controls.Add(MainMenuHeader);
            MainMenuPanel.Controls.Add(SettingsButton);
            MainMenuPanel.Controls.Add(CreateButton);
            MainMenuPanel.Controls.Add(LoadButton);
            MainMenuPanel.Location = new Point(311, 158);
            MainMenuPanel.Name = "MainMenuPanel";
            MainMenuPanel.Size = new Size(200, 229);
            MainMenuPanel.TabIndex = 0;
            // 
            // MainMenuHeader
            // 
            MainMenuHeader.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuHeader.Location = new Point(16, 5);
            MainMenuHeader.Margin = new Padding(16, 16, 16, 8);
            MainMenuHeader.Name = "MainMenuHeader";
            MainMenuHeader.Size = new Size(168, 40);
            MainMenuHeader.TabIndex = 0;
            MainMenuHeader.Text = "Power Automation";
            MainMenuHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsButton
            // 
            SettingsButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.Location = new Point(16, 173);
            SettingsButton.Margin = new Padding(16, 8, 16, 16);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(168, 40);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.Location = new Point(16, 61);
            CreateButton.Margin = new Padding(16, 8, 16, 8);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(168, 40);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoadButton.Location = new Point(16, 117);
            LoadButton.Margin = new Padding(16, 8, 16, 8);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(168, 40);
            LoadButton.TabIndex = 3;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
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
            TrayIconContextMenu.Size = new Size(181, 70);
            TrayIconContextMenu.ItemClicked += TrayIconContextMenu_ItemClicked;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(180, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.ToolTipText = "Exits Power Automation";
            // 
            // AutoHideWidgetsMenuItem
            // 
            AutoHideWidgetsMenuItem.CheckOnClick = true;
            AutoHideWidgetsMenuItem.Name = "AutoHideWidgetsMenuItem";
            AutoHideWidgetsMenuItem.Size = new Size(180, 22);
            AutoHideWidgetsMenuItem.Text = "Auto-hide widgets";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainMenuPanel);
            Name = "MainForm";
            Text = "Form2";
            MainMenuPanel.ResumeLayout(false);
            TrayIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainMenuPanel;
        private Label MainMenuHeader;
        private Button LoadButton;
        private Button CreateButton;
        private Button SettingsButton;
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem AutoHideWidgetsMenuItem;
    }
}