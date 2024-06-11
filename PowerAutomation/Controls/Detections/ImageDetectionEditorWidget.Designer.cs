namespace PowerAutomation.Controls
{
    partial class ImageDetectionEditorWidget
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
            DescriptionTextbox = new TextBox();
            DescriptionLabel = new Label();
            TitleLabel = new Label();
            TitleTextbox = new TextBox();
            MatchPercentTrackbar = new TrackBar();
            KeyLabel = new Label();
            KeyTextbox = new TextBox();
            MinMatchLabel = new Label();
            SelectedImage = new PictureBox();
            ImageMatchingGroupbox = new GroupBox();
            MSLabel = new Label();
            label1 = new Label();
            MSRetryWaitNumeric = new NumericUpDown();
            RetriesLabel = new Label();
            RetriesNumeric = new NumericUpDown();
            LocationLabel = new Label();
            SelectImageButton = new Button();
            ToleranceNumberLabel = new Label();
            ToleranceLabel = new Label();
            ToleranceTrackbar = new TrackBar();
            MatchPercentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MatchPercentTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectedImage).BeginInit();
            ImageMatchingGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MSRetryWaitNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RetriesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToleranceTrackbar).BeginInit();
            SuspendLayout();
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(10, 153);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextbox.Size = new Size(324, 153);
            DescriptionTextbox.TabIndex = 1016;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(10, 131);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 19);
            DescriptionLabel.TabIndex = 1015;
            DescriptionLabel.Text = "Description";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(13, 57);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(40, 19);
            TitleLabel.TabIndex = 1014;
            TitleLabel.Text = "Title";
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(82, 53);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(252, 23);
            TitleTextbox.TabIndex = 1013;
            TitleTextbox.KeyUp += TitleTextbox_KeyUp;
            // 
            // MatchPercentTrackbar
            // 
            MatchPercentTrackbar.Location = new Point(93, 109);
            MatchPercentTrackbar.Maximum = 100;
            MatchPercentTrackbar.Minimum = 60;
            MatchPercentTrackbar.Name = "MatchPercentTrackbar";
            MatchPercentTrackbar.Size = new Size(190, 45);
            MatchPercentTrackbar.TabIndex = 1023;
            MatchPercentTrackbar.Value = 90;
            MatchPercentTrackbar.Scroll += MatchPercentTrackbar_Scroll;
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KeyLabel.Location = new Point(13, 95);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(34, 19);
            KeyLabel.TabIndex = 1025;
            KeyLabel.Text = "Key";
            // 
            // KeyTextbox
            // 
            KeyTextbox.Location = new Point(82, 91);
            KeyTextbox.Name = "KeyTextbox";
            KeyTextbox.Size = new Size(252, 23);
            KeyTextbox.TabIndex = 1024;
            // 
            // MinMatchLabel
            // 
            MinMatchLabel.AutoSize = true;
            MinMatchLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinMatchLabel.Location = new Point(7, 109);
            MinMatchLabel.Name = "MinMatchLabel";
            MinMatchLabel.Size = new Size(80, 19);
            MinMatchLabel.TabIndex = 1027;
            MinMatchLabel.Text = "Min Match";
            // 
            // SelectedImage
            // 
            SelectedImage.Location = new Point(13, 22);
            SelectedImage.Name = "SelectedImage";
            SelectedImage.Size = new Size(80, 80);
            SelectedImage.TabIndex = 1029;
            SelectedImage.TabStop = false;
            // 
            // ImageMatchingGroupbox
            // 
            ImageMatchingGroupbox.Controls.Add(MSLabel);
            ImageMatchingGroupbox.Controls.Add(label1);
            ImageMatchingGroupbox.Controls.Add(MSRetryWaitNumeric);
            ImageMatchingGroupbox.Controls.Add(RetriesLabel);
            ImageMatchingGroupbox.Controls.Add(RetriesNumeric);
            ImageMatchingGroupbox.Controls.Add(LocationLabel);
            ImageMatchingGroupbox.Controls.Add(SelectImageButton);
            ImageMatchingGroupbox.Controls.Add(ToleranceNumberLabel);
            ImageMatchingGroupbox.Controls.Add(SelectedImage);
            ImageMatchingGroupbox.Controls.Add(ToleranceLabel);
            ImageMatchingGroupbox.Controls.Add(ToleranceTrackbar);
            ImageMatchingGroupbox.Controls.Add(MatchPercentLabel);
            ImageMatchingGroupbox.Controls.Add(MinMatchLabel);
            ImageMatchingGroupbox.Controls.Add(MatchPercentTrackbar);
            ImageMatchingGroupbox.Location = new Point(13, 330);
            ImageMatchingGroupbox.Name = "ImageMatchingGroupbox";
            ImageMatchingGroupbox.Size = new Size(321, 260);
            ImageMatchingGroupbox.TabIndex = 1030;
            ImageMatchingGroupbox.TabStop = false;
            ImageMatchingGroupbox.Text = "Image Matching";
            // 
            // MSLabel
            // 
            MSLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MSLabel.ImageAlign = ContentAlignment.TopRight;
            MSLabel.Location = new Point(286, 225);
            MSLabel.Name = "MSLabel";
            MSLabel.Size = new Size(29, 17);
            MSLabel.TabIndex = 1038;
            MSLabel.Text = "ms";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 223);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 1037;
            label1.Text = "Wait Before Retry";
            // 
            // MSRetryWaitNumeric
            // 
            MSRetryWaitNumeric.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            MSRetryWaitNumeric.Location = new Point(163, 223);
            MSRetryWaitNumeric.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            MSRetryWaitNumeric.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            MSRetryWaitNumeric.Name = "MSRetryWaitNumeric";
            MSRetryWaitNumeric.Size = new Size(120, 23);
            MSRetryWaitNumeric.TabIndex = 1036;
            MSRetryWaitNumeric.TextAlign = HorizontalAlignment.Right;
            MSRetryWaitNumeric.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // RetriesLabel
            // 
            RetriesLabel.AutoSize = true;
            RetriesLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RetriesLabel.Location = new Point(9, 185);
            RetriesLabel.Name = "RetriesLabel";
            RetriesLabel.Size = new Size(57, 19);
            RetriesLabel.TabIndex = 1035;
            RetriesLabel.Text = "Retries";
            // 
            // RetriesNumeric
            // 
            RetriesNumeric.Location = new Point(163, 185);
            RetriesNumeric.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            RetriesNumeric.Name = "RetriesNumeric";
            RetriesNumeric.Size = new Size(120, 23);
            RetriesNumeric.TabIndex = 1034;
            RetriesNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LocationLabel.Location = new Point(100, 70);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(80, 19);
            LocationLabel.TabIndex = 1033;
            LocationLabel.Text = "{location}";
            // 
            // SelectImageButton
            // 
            SelectImageButton.BackColor = SystemColors.ButtonFace;
            SelectImageButton.FlatStyle = FlatStyle.Flat;
            SelectImageButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectImageButton.Location = new Point(144, 22);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.Size = new Size(114, 32);
            SelectImageButton.TabIndex = 1032;
            SelectImageButton.Text = "Select Image";
            SelectImageButton.UseVisualStyleBackColor = false;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // ToleranceNumberLabel
            // 
            ToleranceNumberLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ToleranceNumberLabel.ImageAlign = ContentAlignment.TopRight;
            ToleranceNumberLabel.Location = new Point(280, 148);
            ToleranceNumberLabel.Name = "ToleranceNumberLabel";
            ToleranceNumberLabel.Size = new Size(29, 17);
            ToleranceNumberLabel.TabIndex = 1031;
            ToleranceNumberLabel.Text = "5";
            ToleranceNumberLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ToleranceLabel
            // 
            ToleranceLabel.AutoSize = true;
            ToleranceLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToleranceLabel.Location = new Point(7, 146);
            ToleranceLabel.Name = "ToleranceLabel";
            ToleranceLabel.Size = new Size(78, 19);
            ToleranceLabel.TabIndex = 1030;
            ToleranceLabel.Text = "Tolerance";
            // 
            // ToleranceTrackbar
            // 
            ToleranceTrackbar.Location = new Point(93, 146);
            ToleranceTrackbar.Maximum = 35;
            ToleranceTrackbar.Name = "ToleranceTrackbar";
            ToleranceTrackbar.Size = new Size(190, 45);
            ToleranceTrackbar.TabIndex = 1029;
            ToleranceTrackbar.Value = 5;
            // 
            // MatchPercentLabel
            // 
            MatchPercentLabel.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MatchPercentLabel.ImageAlign = ContentAlignment.TopRight;
            MatchPercentLabel.Location = new Point(278, 109);
            MatchPercentLabel.Name = "MatchPercentLabel";
            MatchPercentLabel.Size = new Size(44, 19);
            MatchPercentLabel.TabIndex = 1028;
            MatchPercentLabel.Text = "90%";
            MatchPercentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DetectionEditorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ImageMatchingGroupbox);
            Controls.Add(KeyLabel);
            Controls.Add(KeyTextbox);
            Controls.Add(DescriptionTextbox);
            Controls.Add(DescriptionLabel);
            Controls.Add(TitleLabel);
            Controls.Add(TitleTextbox);
            Name = "DetectionEditorWidget";
            Size = new Size(350, 603);
            Controls.SetChildIndex(TitleTextbox, 0);
            Controls.SetChildIndex(TitleLabel, 0);
            Controls.SetChildIndex(DescriptionLabel, 0);
            Controls.SetChildIndex(DescriptionTextbox, 0);
            Controls.SetChildIndex(KeyTextbox, 0);
            Controls.SetChildIndex(KeyLabel, 0);
            Controls.SetChildIndex(ImageMatchingGroupbox, 0);
            ((System.ComponentModel.ISupportInitialize)MatchPercentTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectedImage).EndInit();
            ImageMatchingGroupbox.ResumeLayout(false);
            ImageMatchingGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MSRetryWaitNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)RetriesNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToleranceTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox DescriptionTextbox;
        private Label DescriptionLabel;
        private Label TitleLabel;
        private TextBox TitleTextbox;
        private TrackBar MatchPercentTrackbar;
        private Label KeyLabel;
        private TextBox KeyTextbox;
        private Label MinMatchLabel;
        private PictureBox SelectedImage;
        private GroupBox ImageMatchingGroupbox;
        private Label MatchPercentLabel;
        private Label ToleranceNumberLabel;
        private Label ToleranceLabel;
        private TrackBar ToleranceTrackbar;
        private Button SelectImageButton;
        private Label LocationLabel;
        private Label label1;
        private NumericUpDown MSRetryWaitNumeric;
        private Label RetriesLabel;
        private NumericUpDown RetriesNumeric;
        private Label MSLabel;
    }
}
