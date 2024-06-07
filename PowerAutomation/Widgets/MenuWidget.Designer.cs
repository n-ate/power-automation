namespace PowerAutomation
{
    partial class MenuWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SettingsButton = new Button();
            WorkspacesButton = new Button();
            MinimizeButton = new Button();
            SuspendLayout();
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SettingsButton.Font = new Font("Tahoma", 12F);
            SettingsButton.Location = new Point(16, 171);
            SettingsButton.Margin = new Padding(16, 8, 16, 16);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(148, 40);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // WorkspacesButton
            // 
            WorkspacesButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WorkspacesButton.Font = new Font("Tahoma", 12F);
            WorkspacesButton.Location = new Point(16, 52);
            WorkspacesButton.Margin = new Padding(16, 8, 16, 8);
            WorkspacesButton.Name = "WorkspacesButton";
            WorkspacesButton.Size = new Size(148, 40);
            WorkspacesButton.TabIndex = 1;
            WorkspacesButton.Text = "Workspaces";
            WorkspacesButton.UseVisualStyleBackColor = true;
            WorkspacesButton.Click += WorkspacesButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MinimizeButton.Font = new Font("Tahoma", 12F);
            MinimizeButton.Location = new Point(16, 227);
            MinimizeButton.Margin = new Padding(16, 8, 16, 8);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(148, 40);
            MinimizeButton.TabIndex = 5;
            MinimizeButton.Text = "Minimize";
            MinimizeButton.UseVisualStyleBackColor = true;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // MenuWidget
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(MinimizeButton);
            Controls.Add(SettingsButton);
            Controls.Add(WorkspacesButton);
            Name = "MenuWidget";
            Size = new Size(180, 288);
            Controls.SetChildIndex(WorkspacesButton, 0);
            Controls.SetChildIndex(SettingsButton, 0);
            Controls.SetChildIndex(MinimizeButton, 0);
            ResumeLayout(false);
        }

        #endregion
        private Button SettingsButton;
        private Button WorkspacesButton;
        private Button MinimizeButton;
    }
}
