namespace PowerAutomation.Widgets
{
    partial class WorkspaceViewerWidget
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
            TitleLabel = new Label();
            TitlebarLabel = new Label();
            IconImage = new PictureBox();
            ClassLabel = new Label();
            DescriptionLabel = new Label();
            DescriptionValueLabel = new Label();
            TitlebarValueLabel = new Label();
            ClassValueLabel = new Label();
            EditButton = new Button();
            DetectionsButton = new Button();
            ProceduresButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(57, 52);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(54, 27);
            TitleLabel.TabIndex = 1013;
            TitleLabel.Text = "Title";
            // 
            // TitlebarLabel
            // 
            TitlebarLabel.AutoSize = true;
            TitlebarLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TitlebarLabel.ForeColor = Color.FromArgb(64, 64, 64);
            TitlebarLabel.Location = new Point(13, 91);
            TitlebarLabel.Name = "TitlebarLabel";
            TitlebarLabel.Size = new Size(52, 17);
            TitlebarLabel.TabIndex = 1020;
            TitlebarLabel.Text = "Titlebar";
            // 
            // IconImage
            // 
            IconImage.Location = new Point(13, 47);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(32, 32);
            IconImage.TabIndex = 1016;
            IconImage.TabStop = false;
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ClassLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ClassLabel.Location = new Point(13, 117);
            ClassLabel.Margin = new Padding(5, 0, 5, 0);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(38, 17);
            ClassLabel.TabIndex = 1018;
            ClassLabel.Text = "Class";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DescriptionLabel.Location = new Point(13, 144);
            DescriptionLabel.Margin = new Padding(5, 0, 5, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(76, 17);
            DescriptionLabel.TabIndex = 1021;
            DescriptionLabel.Text = "Description";
            // 
            // DescriptionValueLabel
            // 
            DescriptionValueLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DescriptionValueLabel.Location = new Point(93, 144);
            DescriptionValueLabel.Margin = new Padding(5, 0, 5, 0);
            DescriptionValueLabel.Name = "DescriptionValueLabel";
            DescriptionValueLabel.Size = new Size(238, 112);
            DescriptionValueLabel.TabIndex = 1024;
            DescriptionValueLabel.Text = "{description}";
            // 
            // TitlebarValueLabel
            // 
            TitlebarValueLabel.AutoSize = true;
            TitlebarValueLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TitlebarValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            TitlebarValueLabel.Location = new Point(93, 91);
            TitlebarValueLabel.Name = "TitlebarValueLabel";
            TitlebarValueLabel.Size = new Size(63, 17);
            TitlebarValueLabel.TabIndex = 1023;
            TitlebarValueLabel.Text = "{titlebar}";
            // 
            // ClassValueLabel
            // 
            ClassValueLabel.AutoSize = true;
            ClassValueLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ClassValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ClassValueLabel.Location = new Point(93, 117);
            ClassValueLabel.Margin = new Padding(5, 0, 5, 0);
            ClassValueLabel.Name = "ClassValueLabel";
            ClassValueLabel.Size = new Size(50, 17);
            ClassValueLabel.TabIndex = 1022;
            ClassValueLabel.Text = "{class}";
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.ButtonFace;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(13, 284);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(100, 32);
            EditButton.TabIndex = 1025;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DetectionsButton
            // 
            DetectionsButton.BackColor = SystemColors.ButtonFace;
            DetectionsButton.FlatStyle = FlatStyle.Flat;
            DetectionsButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetectionsButton.Location = new Point(125, 284);
            DetectionsButton.Name = "DetectionsButton";
            DetectionsButton.Size = new Size(100, 32);
            DetectionsButton.TabIndex = 1026;
            DetectionsButton.Text = "Detections";
            DetectionsButton.UseVisualStyleBackColor = false;
            DetectionsButton.Click += DetectionsButton_Click;
            // 
            // ProceduresButton
            // 
            ProceduresButton.BackColor = SystemColors.ButtonFace;
            ProceduresButton.FlatStyle = FlatStyle.Flat;
            ProceduresButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProceduresButton.Location = new Point(237, 284);
            ProceduresButton.Name = "ProceduresButton";
            ProceduresButton.Size = new Size(100, 32);
            ProceduresButton.TabIndex = 1027;
            ProceduresButton.Text = "Procedures";
            ProceduresButton.UseVisualStyleBackColor = false;
            ProceduresButton.Click += ProceduresButton_Click;
            // 
            // WorkspaceViewerWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProceduresButton);
            Controls.Add(DetectionsButton);
            Controls.Add(EditButton);
            Controls.Add(DescriptionValueLabel);
            Controls.Add(TitlebarValueLabel);
            Controls.Add(ClassValueLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(TitlebarLabel);
            Controls.Add(ClassLabel);
            Controls.Add(IconImage);
            Controls.Add(TitleLabel);
            Name = "WorkspaceViewerWidget";
            Size = new Size(350, 331);
            Controls.SetChildIndex(TitleLabel, 0);
            Controls.SetChildIndex(IconImage, 0);
            Controls.SetChildIndex(ClassLabel, 0);
            Controls.SetChildIndex(TitlebarLabel, 0);
            Controls.SetChildIndex(DescriptionLabel, 0);
            Controls.SetChildIndex(ClassValueLabel, 0);
            Controls.SetChildIndex(TitlebarValueLabel, 0);
            Controls.SetChildIndex(DescriptionValueLabel, 0);
            Controls.SetChildIndex(EditButton, 0);
            Controls.SetChildIndex(DetectionsButton, 0);
            Controls.SetChildIndex(ProceduresButton, 0);
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TitleLabel;
        private Label TitlebarLabel;
        private PictureBox IconImage;
        private Label ClassLabel;
        private Label DescriptionLabel;
        private Label DescriptionValueLabel;
        private Label TitlebarValueLabel;
        private Label ClassValueLabel;
        private Button EditButton;
        private Button DetectionsButton;
        private Button ProceduresButton;
    }
}
