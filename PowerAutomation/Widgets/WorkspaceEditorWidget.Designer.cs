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
            TitleTextbox = new TextBox();
            TitleLabel = new Label();
            DescriptionLabel = new Label();
            DescriptionTextbox = new TextBox();
            IconImage = new PictureBox();
            ClassLabel = new Label();
            ClassTextbox = new TextBox();
            TitlebarLabel = new Label();
            TitlebarTextbox = new TextBox();
            ContinueButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // SelectApplicationButton
            // 
            SelectApplicationButton.BackColor = SystemColors.ButtonFace;
            SelectApplicationButton.FlatStyle = FlatStyle.Flat;
            SelectApplicationButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectApplicationButton.Location = new Point(149, 61);
            SelectApplicationButton.Name = "SelectApplicationButton";
            SelectApplicationButton.Size = new Size(162, 32);
            SelectApplicationButton.TabIndex = 1001;
            SelectApplicationButton.Text = "Select Application";
            SelectApplicationButton.UseVisualStyleBackColor = false;
            SelectApplicationButton.Click += SelectApplicationButton_Click;
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(82, 204);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(252, 23);
            TitleTextbox.TabIndex = 1002;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(13, 208);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(40, 19);
            TitleLabel.TabIndex = 1003;
            TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(13, 252);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 19);
            DescriptionLabel.TabIndex = 1004;
            DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(13, 274);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextbox.Size = new Size(324, 153);
            DescriptionTextbox.TabIndex = 1005;
            // 
            // IconImage
            // 
            IconImage.Location = new Point(69, 61);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(32, 32);
            IconImage.TabIndex = 1006;
            IconImage.TabStop = false;
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassLabel.Location = new Point(13, 163);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(45, 19);
            ClassLabel.TabIndex = 1008;
            ClassLabel.Text = "Class";
            // 
            // ClassTextbox
            // 
            ClassTextbox.BackColor = SystemColors.ControlLight;
            ClassTextbox.Location = new Point(85, 159);
            ClassTextbox.Name = "ClassTextbox";
            ClassTextbox.ReadOnly = true;
            ClassTextbox.Size = new Size(252, 23);
            ClassTextbox.TabIndex = 1007;
            ClassTextbox.Click += AppInfoTextbox_Click;
            // 
            // TitlebarLabel
            // 
            TitlebarLabel.AutoSize = true;
            TitlebarLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitlebarLabel.Location = new Point(13, 118);
            TitlebarLabel.Name = "TitlebarLabel";
            TitlebarLabel.Size = new Size(63, 19);
            TitlebarLabel.TabIndex = 1010;
            TitlebarLabel.Text = "Titlebar";
            // 
            // TitlebarTextbox
            // 
            TitlebarTextbox.BackColor = SystemColors.ControlLight;
            TitlebarTextbox.Location = new Point(85, 114);
            TitlebarTextbox.Name = "TitlebarTextbox";
            TitlebarTextbox.ReadOnly = true;
            TitlebarTextbox.Size = new Size(252, 23);
            TitlebarTextbox.TabIndex = 1009;
            TitlebarTextbox.Click += AppInfoTextbox_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = SystemColors.ButtonFace;
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContinueButton.Location = new Point(225, 442);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(109, 32);
            ContinueButton.TabIndex = 1011;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // WorkspaceEditorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(ContinueButton);
            Controls.Add(TitlebarLabel);
            Controls.Add(TitlebarTextbox);
            Controls.Add(ClassLabel);
            Controls.Add(ClassTextbox);
            Controls.Add(IconImage);
            Controls.Add(DescriptionTextbox);
            Controls.Add(DescriptionLabel);
            Controls.Add(TitleLabel);
            Controls.Add(TitleTextbox);
            Controls.Add(SelectApplicationButton);
            Name = "WorkspaceEditorWidget";
            Size = new Size(350, 490);
            Controls.SetChildIndex(SelectApplicationButton, 0);
            Controls.SetChildIndex(TitleTextbox, 0);
            Controls.SetChildIndex(TitleLabel, 0);
            Controls.SetChildIndex(DescriptionLabel, 0);
            Controls.SetChildIndex(DescriptionTextbox, 0);
            Controls.SetChildIndex(IconImage, 0);
            Controls.SetChildIndex(ClassTextbox, 0);
            Controls.SetChildIndex(ClassLabel, 0);
            Controls.SetChildIndex(TitlebarTextbox, 0);
            Controls.SetChildIndex(TitlebarLabel, 0);
            Controls.SetChildIndex(ContinueButton, 0);
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ApplicationInfoTextbox;
        private Button SelectApplicationButton;
        private TextBox TitleTextbox;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private TextBox DescriptionTextbox;
        private PictureBox IconImage;
        private Label ClassLabel;
        private TextBox ClassTextbox;
        private Label TitlebarLabel;
        private TextBox TitlebarTextbox;
        private Button ContinueButton;
    }
}
