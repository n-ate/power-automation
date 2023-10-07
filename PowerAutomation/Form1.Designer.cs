namespace PowerAutomation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SettingsButton = new Button();
            comboBox1 = new ComboBox();
            MainMenuPanel = new Panel();
            CreateButton = new Button();
            LoadButton = new Button();
            MainMenuHeader = new Label();
            xLabel1 = new Controls.XLabel();
            button1 = new Button();
            MainMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top;
            SettingsButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.Location = new Point(16, 156);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(152, 33);
            SettingsButton.TabIndex = 3;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(575, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // MainMenuPanel
            // 
            MainMenuPanel.BackColor = Color.Beige;
            MainMenuPanel.BorderStyle = BorderStyle.Fixed3D;
            MainMenuPanel.Controls.Add(button1);
            MainMenuPanel.Controls.Add(CreateButton);
            MainMenuPanel.Controls.Add(LoadButton);
            MainMenuPanel.Controls.Add(SettingsButton);
            MainMenuPanel.Location = new Point(157, 163);
            MainMenuPanel.Margin = new Padding(0);
            MainMenuPanel.Name = "MainMenuPanel";
            MainMenuPanel.Size = new Size(186, 205);
            MainMenuPanel.TabIndex = 0;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Top;
            CreateButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.Location = new Point(16, 51);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(152, 33);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Anchor = AnchorStyles.Top;
            LoadButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoadButton.Location = new Point(16, 105);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(152, 33);
            LoadButton.TabIndex = 2;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // MainMenuHeader
            // 
            MainMenuHeader.Anchor = AnchorStyles.Top;
            MainMenuHeader.BackColor = Color.Gold;
            MainMenuHeader.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuHeader.Location = new Point(406, 181);
            MainMenuHeader.Margin = new Padding(0);
            MainMenuHeader.Name = "MainMenuHeader";
            MainMenuHeader.Size = new Size(182, 47);
            MainMenuHeader.TabIndex = 999;
            MainMenuHeader.Text = "Power Automation";
            MainMenuHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xLabel1
            // 
            xLabel1.AutoSize = true;
            xLabel1.Interactive = false;
            xLabel1.Location = new Point(486, 257);
            xLabel1.Name = "xLabel1";
            xLabel1.Size = new Size(47, 15);
            xLabel1.TabIndex = 3;
            xLabel1.Text = "xLabel1";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(182, 45);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LawnGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(MainMenuHeader);
            Controls.Add(xLabel1);
            Controls.Add(MainMenuPanel);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            MainMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SettingsButton;
        private ComboBox comboBox1;
        private Panel MainMenuPanel;
        private Button CreateButton;
        private Button LoadButton;
        private Controls.XLabel xLabel1;
        private Label MainMenuHeader;
        private Button button1;
    }
}