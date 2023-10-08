namespace PowerAutomation
{
    partial class MainMenuWidget
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
            Header = new Label();
            SettingsButton = new Button();
            CreateButton = new Button();
            LoadButton = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(16, 3);
            Header.Margin = new Padding(16, 16, 16, 8);
            Header.Name = "Header";
            Header.Size = new Size(168, 40);
            Header.TabIndex = 0;
            Header.Text = "Power Automation";
            Header.TextAlign = ContentAlignment.MiddleCenter;
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
            // CreateButton
            // 
            CreateButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.Location = new Point(16, 59);
            CreateButton.Margin = new Padding(16, 8, 16, 8);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(168, 40);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoadButton.Location = new Point(16, 115);
            LoadButton.Margin = new Padding(16, 8, 16, 8);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(168, 40);
            LoadButton.TabIndex = 3;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(Header);
            Controls.Add(SettingsButton);
            Controls.Add(LoadButton);
            Controls.Add(CreateButton);
            Name = "MainMenuWidget";
            Size = new Size(200, 233);
            ResumeLayout(false);
        }

        #endregion
        private Label Header;
        private Button SettingsButton;
        private Button CreateButton;
        private Button LoadButton;
    }
}
