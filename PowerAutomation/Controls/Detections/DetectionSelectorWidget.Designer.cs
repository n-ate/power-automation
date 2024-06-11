namespace PowerAutomation.Controls.Detections
{
    partial class DetectionSelectorWidget
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
            ImageDetectionTemplate = new Panel();
            TitleValueLabel = new Label();
            RetriesValueLabel = new Label();
            RetryDelayValueLabel = new Label();
            ToleranceValueLabel = new Label();
            MinMatchValueLabel = new Label();
            RetryDelayLabel = new Label();
            RetriesLabel = new Label();
            DetectionImage = new PictureBox();
            ToleranceLabel = new Label();
            MinMatchLabel = new Label();
            ScrollAreaPanel = new Panel();
            ImageDetectionTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DetectionImage).BeginInit();
            ScrollAreaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TemplateButtonPanel
            // 
            ImageDetectionTemplate.BackColor = SystemColors.ControlLight;
            ImageDetectionTemplate.BorderStyle = BorderStyle.FixedSingle;
            ImageDetectionTemplate.Controls.Add(TitleValueLabel);
            ImageDetectionTemplate.Controls.Add(RetriesValueLabel);
            ImageDetectionTemplate.Controls.Add(RetryDelayValueLabel);
            ImageDetectionTemplate.Controls.Add(ToleranceValueLabel);
            ImageDetectionTemplate.Controls.Add(MinMatchValueLabel);
            ImageDetectionTemplate.Controls.Add(RetryDelayLabel);
            ImageDetectionTemplate.Controls.Add(RetriesLabel);
            ImageDetectionTemplate.Controls.Add(DetectionImage);
            ImageDetectionTemplate.Controls.Add(ToleranceLabel);
            ImageDetectionTemplate.Controls.Add(MinMatchLabel);
            ImageDetectionTemplate.Font = new Font("Tahoma", 12F);
            ImageDetectionTemplate.ForeColor = SystemColors.ControlText;
            ImageDetectionTemplate.Location = new Point(7, 8);
            ImageDetectionTemplate.Margin = new Padding(8);
            ImageDetectionTemplate.Name = "TemplateButtonPanel";
            ImageDetectionTemplate.Size = new Size(354, 85);
            ImageDetectionTemplate.TabIndex = 1001;
            ImageDetectionTemplate.TabStop = true;
            ImageDetectionTemplate.Click += Option_Click;
            // 
            // TitleValueLabel
            // 
            TitleValueLabel.AutoSize = true;
            TitleValueLabel.Font = new Font("Tahoma", 12F);
            TitleValueLabel.Location = new Point(93, 5);
            TitleValueLabel.Margin = new Padding(5);
            TitleValueLabel.Name = "TitleValueLabel";
            TitleValueLabel.Size = new Size(66, 19);
            TitleValueLabel.TabIndex = 1052;
            TitleValueLabel.Text = "{ Title }";
            // 
            // RetriesValueLabel
            // 
            RetriesValueLabel.AutoSize = true;
            RetriesValueLabel.Font = new Font("Tahoma", 10F);
            RetriesValueLabel.Location = new Point(309, 34);
            RetriesValueLabel.Margin = new Padding(5);
            RetriesValueLabel.Name = "RetriesValueLabel";
            RetriesValueLabel.Size = new Size(24, 17);
            RetriesValueLabel.TabIndex = 1051;
            RetriesValueLabel.Text = "35";
            // 
            // RetryDelayValueLabel
            // 
            RetryDelayValueLabel.AutoSize = true;
            RetryDelayValueLabel.Font = new Font("Tahoma", 10F);
            RetryDelayValueLabel.Location = new Point(309, 61);
            RetryDelayValueLabel.Margin = new Padding(5);
            RetryDelayValueLabel.Name = "RetryDelayValueLabel";
            RetryDelayValueLabel.Size = new Size(42, 17);
            RetryDelayValueLabel.TabIndex = 1050;
            RetryDelayValueLabel.Text = "35ms";
            // 
            // ToleranceValueLabel
            // 
            ToleranceValueLabel.AutoSize = true;
            ToleranceValueLabel.Font = new Font("Tahoma", 10F);
            ToleranceValueLabel.Location = new Point(174, 61);
            ToleranceValueLabel.Margin = new Padding(5);
            ToleranceValueLabel.Name = "ToleranceValueLabel";
            ToleranceValueLabel.Size = new Size(24, 17);
            ToleranceValueLabel.TabIndex = 1049;
            ToleranceValueLabel.Text = "35";
            // 
            // MinMatchValueLabel
            // 
            MinMatchValueLabel.AutoSize = true;
            MinMatchValueLabel.Font = new Font("Tahoma", 10F);
            MinMatchValueLabel.Location = new Point(174, 34);
            MinMatchValueLabel.Margin = new Padding(5);
            MinMatchValueLabel.Name = "MinMatchValueLabel";
            MinMatchValueLabel.Size = new Size(38, 17);
            MinMatchValueLabel.TabIndex = 1048;
            MinMatchValueLabel.Text = "90%";
            // 
            // RetryDelayLabel
            // 
            RetryDelayLabel.AutoSize = true;
            RetryDelayLabel.Font = new Font("Tahoma", 10F);
            RetryDelayLabel.Location = new Point(219, 61);
            RetryDelayLabel.Margin = new Padding(5);
            RetryDelayLabel.Name = "RetryDelayLabel";
            RetryDelayLabel.Size = new Size(80, 17);
            RetryDelayLabel.TabIndex = 1047;
            RetryDelayLabel.Text = "Retry Delay";
            // 
            // RetriesLabel
            // 
            RetriesLabel.AutoSize = true;
            RetriesLabel.Font = new Font("Tahoma", 10F);
            RetriesLabel.Location = new Point(250, 34);
            RetriesLabel.Margin = new Padding(5);
            RetriesLabel.Name = "RetriesLabel";
            RetriesLabel.Size = new Size(49, 17);
            RetriesLabel.TabIndex = 1045;
            RetriesLabel.Text = "Retries";
            // 
            // DetectionImage
            // 
            DetectionImage.Location = new Point(0, 0);
            DetectionImage.Margin = new Padding(0);
            DetectionImage.Name = "DetectionImage";
            DetectionImage.Size = new Size(83, 83);
            DetectionImage.TabIndex = 1040;
            DetectionImage.TabStop = false;
            // 
            // ToleranceLabel
            // 
            ToleranceLabel.AutoSize = true;
            ToleranceLabel.Font = new Font("Tahoma", 10F);
            ToleranceLabel.Location = new Point(97, 61);
            ToleranceLabel.Margin = new Padding(5);
            ToleranceLabel.Name = "ToleranceLabel";
            ToleranceLabel.Size = new Size(67, 17);
            ToleranceLabel.TabIndex = 1042;
            ToleranceLabel.Text = "Tolerance";
            // 
            // MinMatchLabel
            // 
            MinMatchLabel.AutoSize = true;
            MinMatchLabel.Font = new Font("Tahoma", 10F);
            MinMatchLabel.Location = new Point(95, 34);
            MinMatchLabel.Margin = new Padding(5);
            MinMatchLabel.Name = "MinMatchLabel";
            MinMatchLabel.Size = new Size(69, 17);
            MinMatchLabel.TabIndex = 1039;
            MinMatchLabel.Text = "Min Match";
            // 
            // ScrollAreaPanel
            // 
            ScrollAreaPanel.AutoScroll = true;
            ScrollAreaPanel.AutoScrollMinSize = new Size(0, 457);
            ScrollAreaPanel.BorderStyle = BorderStyle.Fixed3D;
            ScrollAreaPanel.Controls.Add(ImageDetectionTemplate);
            ScrollAreaPanel.Location = new Point(11, 51);
            ScrollAreaPanel.Margin = new Padding(8);
            ScrollAreaPanel.Name = "ScrollAreaPanel";
            ScrollAreaPanel.Size = new Size(388, 460);
            ScrollAreaPanel.TabIndex = 1002;
            // 
            // DetectionSelectorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ScrollAreaPanel);
            Name = "DetectionSelectorWidget";
            Padding = new Padding(16);
            Size = new Size(410, 526);
            Controls.SetChildIndex(ScrollAreaPanel, 0);
            ImageDetectionTemplate.ResumeLayout(false);
            ImageDetectionTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DetectionImage).EndInit();
            ScrollAreaPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel ImageDetectionTemplate;
        private Label RetryDelayLabel;
        private Label RetriesLabel;
        private PictureBox DetectionImage;
        private Label ToleranceLabel;
        private Label MinMatchLabel;
        private Label ToleranceValueLabel;
        private Label MinMatchValueLabel;
        private Label RetriesValueLabel;
        private Label RetryDelayValueLabel;
        private Label TitleValueLabel;
        private Panel ScrollAreaPanel;
    }
}
