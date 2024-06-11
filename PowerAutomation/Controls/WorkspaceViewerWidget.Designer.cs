using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PowerAutomation.Controls
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
            ProcessNameLabel = new Label();
            IconImage = new PictureBox();
            ClassLabel = new Label();
            DescriptionLabel = new Label();
            DescriptionValueLabel = new Label();
            ProcessNameValueLabel = new Label();
            ClassValueLabel = new Label();
            EditButton = new Button();
            DetectionsButton = new Button();
            ProceduresButton = new Button();
            CloseButton = new Button();
            DeleteButton = new Button();
            AppTypeValueLabel = new Label();
            AppTypeLabel = new Label();
            ModuleNameValueLabel = new Label();
            ModuleNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 16F);
            TitleLabel.Location = new Point(57, 52);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(70, 27);
            TitleLabel.TabIndex = 1013;
            TitleLabel.Text = "{title}";
            // 
            // ProcessNameLabel
            // 
            ProcessNameLabel.AutoSize = true;
            ProcessNameLabel.Font = new Font("Tahoma", 10F);
            ProcessNameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ProcessNameLabel.Location = new Point(14, 124);
            ProcessNameLabel.Name = "ProcessNameLabel";
            ProcessNameLabel.Size = new Size(55, 17);
            ProcessNameLabel.TabIndex = 1020;
            ProcessNameLabel.Text = "Process";
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
            ClassLabel.Font = new Font("Tahoma", 10F);
            ClassLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ClassLabel.Location = new Point(14, 185);
            ClassLabel.Margin = new Padding(5, 0, 5, 0);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(38, 17);
            ClassLabel.TabIndex = 1018;
            ClassLabel.Text = "Class";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 10F);
            DescriptionLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DescriptionLabel.Location = new Point(14, 212);
            DescriptionLabel.Margin = new Padding(5, 0, 5, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(76, 17);
            DescriptionLabel.TabIndex = 1021;
            DescriptionLabel.Text = "Description";
            // 
            // DescriptionValueLabel
            // 
            DescriptionValueLabel.Font = new Font("Tahoma", 10F);
            DescriptionValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DescriptionValueLabel.Location = new Point(94, 212);
            DescriptionValueLabel.Margin = new Padding(5, 0, 5, 0);
            DescriptionValueLabel.Name = "DescriptionValueLabel";
            DescriptionValueLabel.Size = new Size(238, 112);
            DescriptionValueLabel.TabIndex = 1024;
            DescriptionValueLabel.Text = "{description}";
            // 
            // ProcessNameValueLabel
            // 
            ProcessNameValueLabel.AutoSize = true;
            ProcessNameValueLabel.Font = new Font("Tahoma", 10F);
            ProcessNameValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ProcessNameValueLabel.Location = new Point(94, 124);
            ProcessNameValueLabel.Name = "ProcessNameValueLabel";
            ProcessNameValueLabel.Size = new Size(69, 17);
            ProcessNameValueLabel.TabIndex = 1023;
            ProcessNameValueLabel.Text = "{process}";
            // 
            // ClassValueLabel
            // 
            ClassValueLabel.AutoSize = true;
            ClassValueLabel.Font = new Font("Tahoma", 10F);
            ClassValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ClassValueLabel.Location = new Point(94, 185);
            ClassValueLabel.Margin = new Padding(5, 0, 5, 0);
            ClassValueLabel.Name = "ClassValueLabel";
            ClassValueLabel.Size = new Size(50, 17);
            ClassValueLabel.TabIndex = 1022;
            ClassValueLabel.Text = "{class}";
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.BackColor = SystemColors.ButtonFace;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Tahoma", 12F);
            EditButton.Location = new Point(14, 431);
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
            DetectionsButton.Font = new Font("Tahoma", 12F);
            DetectionsButton.Location = new Point(57, 336);
            DetectionsButton.Name = "DetectionsButton";
            DetectionsButton.Size = new Size(226, 32);
            DetectionsButton.TabIndex = 1026;
            DetectionsButton.Text = "Detections";
            DetectionsButton.UseVisualStyleBackColor = false;
            DetectionsButton.Click += DetectionsButton_Click;
            // 
            // ProceduresButton
            // 
            ProceduresButton.BackColor = SystemColors.ButtonFace;
            ProceduresButton.FlatStyle = FlatStyle.Flat;
            ProceduresButton.Font = new Font("Tahoma", 12F);
            ProceduresButton.Location = new Point(57, 384);
            ProceduresButton.Name = "ProceduresButton";
            ProceduresButton.Size = new Size(226, 32);
            ProceduresButton.TabIndex = 1027;
            ProceduresButton.Text = "Procedures";
            ProceduresButton.UseVisualStyleBackColor = false;
            ProceduresButton.Click += ProceduresButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.BackColor = SystemColors.ButtonFace;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Tahoma", 12F);
            CloseButton.Location = new Point(237, 431);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(100, 32);
            CloseButton.TabIndex = 1025;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom;
            DeleteButton.BackColor = SystemColors.ButtonFace;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Tahoma", 12F);
            DeleteButton.ForeColor = Color.FromArgb(192, 0, 0);
            DeleteButton.Location = new Point(125, 431);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 32);
            DeleteButton.TabIndex = 1028;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AppTypeValueLabel
            // 
            AppTypeValueLabel.AutoSize = true;
            AppTypeValueLabel.Font = new Font("Tahoma", 10F);
            AppTypeValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AppTypeValueLabel.Location = new Point(94, 95);
            AppTypeValueLabel.Name = "AppTypeValueLabel";
            AppTypeValueLabel.Size = new Size(78, 17);
            AppTypeValueLabel.TabIndex = 1029;
            AppTypeValueLabel.Text = "{app-type}";
            // 
            // AppTypeLabel
            // 
            AppTypeLabel.AutoSize = true;
            AppTypeLabel.Font = new Font("Tahoma", 10F);
            AppTypeLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AppTypeLabel.Location = new Point(14, 95);
            AppTypeLabel.Name = "AppTypeLabel";
            AppTypeLabel.Size = new Size(67, 17);
            AppTypeLabel.TabIndex = 1028;
            AppTypeLabel.Text = "App Type";
            // 
            // ModuleNameValueLabel
            // 
            ModuleNameValueLabel.AutoSize = true;
            ModuleNameValueLabel.Font = new Font("Tahoma", 10F);
            ModuleNameValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ModuleNameValueLabel.Location = new Point(94, 155);
            ModuleNameValueLabel.Name = "ModuleNameValueLabel";
            ModuleNameValueLabel.Size = new Size(67, 17);
            ModuleNameValueLabel.TabIndex = 1031;
            ModuleNameValueLabel.Text = "{module}";
            // 
            // ModuleNameLabel
            // 
            ModuleNameLabel.AutoSize = true;
            ModuleNameLabel.Font = new Font("Tahoma", 10F);
            ModuleNameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ModuleNameLabel.Location = new Point(14, 155);
            ModuleNameLabel.Name = "ModuleNameLabel";
            ModuleNameLabel.Size = new Size(51, 17);
            ModuleNameLabel.TabIndex = 1030;
            ModuleNameLabel.Text = "Module";
            // 
            // WorkspaceViewerWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ModuleNameValueLabel);
            Controls.Add(ModuleNameLabel);
            Controls.Add(AppTypeValueLabel);
            Controls.Add(AppTypeLabel);
            Controls.Add(ProceduresButton);
            Controls.Add(DetectionsButton);
            Controls.Add(EditButton);
            Controls.Add(DescriptionValueLabel);
            Controls.Add(ProcessNameValueLabel);
            Controls.Add(ClassValueLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(ProcessNameLabel);
            Controls.Add(ClassLabel);
            Controls.Add(IconImage);
            Controls.Add(TitleLabel);
            Controls.Add(DeleteButton);
            Controls.Add(CloseButton);
            Name = "WorkspaceViewerWidget";
            Size = new Size(350, 475);
            Controls.SetChildIndex(CloseButton, 0);
            Controls.SetChildIndex(DeleteButton, 0);
            Controls.SetChildIndex(TitleLabel, 0);
            Controls.SetChildIndex(IconImage, 0);
            Controls.SetChildIndex(ClassLabel, 0);
            Controls.SetChildIndex(ProcessNameLabel, 0);
            Controls.SetChildIndex(DescriptionLabel, 0);
            Controls.SetChildIndex(ClassValueLabel, 0);
            Controls.SetChildIndex(ProcessNameValueLabel, 0);
            Controls.SetChildIndex(DescriptionValueLabel, 0);
            Controls.SetChildIndex(EditButton, 0);
            Controls.SetChildIndex(DetectionsButton, 0);
            Controls.SetChildIndex(ProceduresButton, 0);
            Controls.SetChildIndex(AppTypeLabel, 0);
            Controls.SetChildIndex(AppTypeValueLabel, 0);
            Controls.SetChildIndex(ModuleNameLabel, 0);
            Controls.SetChildIndex(ModuleNameValueLabel, 0);
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TitleLabel;
        private Label ProcessNameLabel;
        private PictureBox IconImage;
        private Label ClassLabel;
        private Label DescriptionLabel;
        private Label DescriptionValueLabel;
        private Label ProcessNameValueLabel;
        private Label ClassValueLabel;
        private Button EditButton;
        private Button DetectionsButton;
        private Button ProceduresButton;
        private Label AppTypeValueLabel;
        private Label AppTypeLabel;
        private Label ModuleNameValueLabel;
        private Label ModuleNameLabel;
        private Button CloseButton;
        private Button DeleteButton;
    }
}
