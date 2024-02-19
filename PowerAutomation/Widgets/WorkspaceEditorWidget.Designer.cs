namespace PowerAutomation.Widgets
{
    partial class WorkspaceEditorWidget
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
            SelectApplicationButton = new Button();
            DescriptionLabel = new Label();
            DescriptionTextbox = new TextBox();
            IconImage = new PictureBox();
            ClassLabel = new Label();
            ClassTextbox = new TextBox();
            ProcessNameLabel = new Label();
            ProcessNameTextbox = new TextBox();
            ContinueButton = new Button();
            ModuleNameLabel = new Label();
            ModuleNameTextbox = new TextBox();
            ApplicationGroupbox = new GroupBox();
            AppTypeLabel = new Label();
            AppTypeTextbox = new TextBox();
            TitleLabel = new Label();
            TitleTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            ApplicationGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectApplicationButton
            // 
            SelectApplicationButton.BackColor = SystemColors.ButtonFace;
            SelectApplicationButton.FlatStyle = FlatStyle.Flat;
            SelectApplicationButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectApplicationButton.Location = new Point(156, 22);
            SelectApplicationButton.Name = "SelectApplicationButton";
            SelectApplicationButton.Size = new Size(162, 32);
            SelectApplicationButton.TabIndex = 1001;
            SelectApplicationButton.Text = "Select Application";
            SelectApplicationButton.UseVisualStyleBackColor = false;
            SelectApplicationButton.Click += SelectApplicationButton_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(13, 311);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 19);
            DescriptionLabel.TabIndex = 1004;
            DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(13, 333);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextbox.Size = new Size(324, 153);
            DescriptionTextbox.TabIndex = 1005;
            // 
            // IconImage
            // 
            IconImage.Location = new Point(19, 22);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(32, 32);
            IconImage.TabIndex = 1006;
            IconImage.TabStop = false;
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassLabel.Location = new Point(6, 185);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(45, 19);
            ClassLabel.TabIndex = 1008;
            ClassLabel.Text = "Class";
            // 
            // ClassTextbox
            // 
            ClassTextbox.BackColor = SystemColors.ControlLight;
            ClassTextbox.Location = new Point(120, 181);
            ClassTextbox.Name = "ClassTextbox";
            ClassTextbox.ReadOnly = true;
            ClassTextbox.Size = new Size(198, 23);
            ClassTextbox.TabIndex = 1007;
            ClassTextbox.Click += AppInfoTextbox_Click;
            // 
            // ProcessNameLabel
            // 
            ProcessNameLabel.AutoSize = true;
            ProcessNameLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessNameLabel.Location = new Point(6, 110);
            ProcessNameLabel.Name = "ProcessNameLabel";
            ProcessNameLabel.Size = new Size(108, 19);
            ProcessNameLabel.TabIndex = 1010;
            ProcessNameLabel.Text = "Process Name";
            // 
            // ProcessNameTextbox
            // 
            ProcessNameTextbox.BackColor = SystemColors.ControlLight;
            ProcessNameTextbox.Location = new Point(120, 106);
            ProcessNameTextbox.Name = "ProcessNameTextbox";
            ProcessNameTextbox.ReadOnly = true;
            ProcessNameTextbox.Size = new Size(198, 23);
            ProcessNameTextbox.TabIndex = 1009;
            ProcessNameTextbox.Click += AppInfoTextbox_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = SystemColors.ButtonFace;
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContinueButton.Location = new Point(225, 501);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(109, 32);
            ContinueButton.TabIndex = 1011;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // ModuleNameLabel
            // 
            ModuleNameLabel.AutoSize = true;
            ModuleNameLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModuleNameLabel.Location = new Point(6, 148);
            ModuleNameLabel.Name = "ModuleNameLabel";
            ModuleNameLabel.Size = new Size(106, 19);
            ModuleNameLabel.TabIndex = 1013;
            ModuleNameLabel.Text = "Module Name";
            // 
            // ModuleNameTextbox
            // 
            ModuleNameTextbox.BackColor = SystemColors.ControlLight;
            ModuleNameTextbox.Location = new Point(120, 144);
            ModuleNameTextbox.Name = "ModuleNameTextbox";
            ModuleNameTextbox.ReadOnly = true;
            ModuleNameTextbox.Size = new Size(198, 23);
            ModuleNameTextbox.TabIndex = 1012;
            // 
            // ApplicationGroupbox
            // 
            ApplicationGroupbox.Controls.Add(AppTypeTextbox);
            ApplicationGroupbox.Controls.Add(AppTypeLabel);
            ApplicationGroupbox.Controls.Add(ModuleNameLabel);
            ApplicationGroupbox.Controls.Add(IconImage);
            ApplicationGroupbox.Controls.Add(ClassLabel);
            ApplicationGroupbox.Controls.Add(ProcessNameLabel);
            ApplicationGroupbox.Controls.Add(ClassTextbox);
            ApplicationGroupbox.Controls.Add(ModuleNameTextbox);
            ApplicationGroupbox.Controls.Add(ProcessNameTextbox);
            ApplicationGroupbox.Controls.Add(SelectApplicationButton);
            ApplicationGroupbox.Location = new Point(13, 83);
            ApplicationGroupbox.Name = "ApplicationGroupbox";
            ApplicationGroupbox.Size = new Size(324, 219);
            ApplicationGroupbox.TabIndex = 1014;
            ApplicationGroupbox.TabStop = false;
            ApplicationGroupbox.Text = "Choose Application";
            // 
            // AppTypeLabel
            // 
            AppTypeLabel.AutoSize = true;
            AppTypeLabel.Enabled = false;
            AppTypeLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AppTypeLabel.Location = new Point(6, 73);
            AppTypeLabel.Name = "AppTypeLabel";
            AppTypeLabel.Size = new Size(78, 19);
            AppTypeLabel.TabIndex = 1015;
            AppTypeLabel.Text = "App Type";
            // 
            // AppTypeTextbox
            // 
            AppTypeTextbox.BackColor = SystemColors.ControlLight;
            AppTypeTextbox.Location = new Point(120, 69);
            AppTypeTextbox.Name = "AppTypeTextbox";
            AppTypeTextbox.ReadOnly = true;
            AppTypeTextbox.Size = new Size(198, 23);
            AppTypeTextbox.TabIndex = 1016;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(13, 49);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(40, 19);
            TitleLabel.TabIndex = 1016;
            TitleLabel.Text = "Title";
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(82, 45);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(252, 23);
            TitleTextbox.TabIndex = 1015;
            // 
            // WorkspaceEditorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(TitleLabel);
            Controls.Add(TitleTextbox);
            Controls.Add(ContinueButton);
            Controls.Add(DescriptionTextbox);
            Controls.Add(DescriptionLabel);
            Controls.Add(ApplicationGroupbox);
            Name = "WorkspaceEditorWidget";
            Size = new Size(350, 549);
            Controls.SetChildIndex(ApplicationGroupbox, 0);
            Controls.SetChildIndex(DescriptionLabel, 0);
            Controls.SetChildIndex(DescriptionTextbox, 0);
            Controls.SetChildIndex(ContinueButton, 0);
            Controls.SetChildIndex(TitleTextbox, 0);
            Controls.SetChildIndex(TitleLabel, 0);
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ApplicationGroupbox.ResumeLayout(false);
            ApplicationGroupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ApplicationInfoTextbox;
        private Button SelectApplicationButton;
        private Label DescriptionLabel;
        private TextBox DescriptionTextbox;
        private PictureBox IconImage;
        private Label ClassLabel;
        private TextBox ClassTextbox;
        private Label ProcessNameLabel;
        private TextBox ProcessNameTextbox;
        private Button ContinueButton;
        private Label ModuleNameLabel;
        private TextBox ModuleNameTextbox;
        private GroupBox ApplicationGroupbox;
        private TextBox AppTypeTextbox;
        private Label AppTypeLabel;
        private Label TitleLabel;
        private TextBox TitleTextbox;
    }
}
