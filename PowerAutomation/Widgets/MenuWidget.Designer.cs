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
            SettingsButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.Location = new Point(16, 171);
            SettingsButton.Margin = new Padding(16, 8, 16, 16);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(168, 40);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // WorkspacesButton
            // 
            WorkspacesButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WorkspacesButton.Location = new Point(16, 59);
            WorkspacesButton.Margin = new Padding(16, 8, 16, 8);
            WorkspacesButton.Name = "WorkspacesButton";
            WorkspacesButton.Size = new Size(168, 40);
            WorkspacesButton.TabIndex = 1;
            WorkspacesButton.Text = "Workspaces";
            WorkspacesButton.UseVisualStyleBackColor = true;
            WorkspacesButton.Click += WorkspacesButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeButton.Location = new Point(16, 227);
            MinimizeButton.Margin = new Padding(16, 8, 16, 8);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(168, 40);
            MinimizeButton.TabIndex = 1000;
            MinimizeButton.Text = "Minimize";
            MinimizeButton.UseVisualStyleBackColor = true;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // MenuWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(MinimizeButton);
            Controls.Add(SettingsButton);
            Controls.Add(WorkspacesButton);
            Name = "MenuWidget";
            Size = new Size(200, 288);
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
