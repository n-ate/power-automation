namespace PowerAutomation.Controls
{
    partial class DetectionsWidget
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
            CreateDetectionButton = new Button();
            DetectionsListview = new ListView();
            TitleColumnHeader = new ColumnHeader();
            LocationColumnHeader = new ColumnHeader();
            AttemptsColumnHeader = new ColumnHeader();
            IntervalColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // CreateDetectionButton
            // 
            CreateDetectionButton.BackColor = SystemColors.ButtonFace;
            CreateDetectionButton.FlatStyle = FlatStyle.Flat;
            CreateDetectionButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateDetectionButton.Location = new Point(221, 43);
            CreateDetectionButton.Name = "CreateDetectionButton";
            CreateDetectionButton.Size = new Size(114, 32);
            CreateDetectionButton.TabIndex = 1027;
            CreateDetectionButton.Text = "Create New";
            CreateDetectionButton.UseVisualStyleBackColor = false;
            CreateDetectionButton.Click += CreateDetectionButton_Click;
            // 
            // DetectionsListview
            // 
            DetectionsListview.Columns.AddRange(new ColumnHeader[] { TitleColumnHeader, LocationColumnHeader, AttemptsColumnHeader, IntervalColumnHeader });
            DetectionsListview.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DetectionsListview.Location = new Point(16, 91);
            DetectionsListview.Name = "DetectionsListview";
            DetectionsListview.Size = new Size(319, 327);
            DetectionsListview.TabIndex = 1028;
            DetectionsListview.UseCompatibleStateImageBehavior = false;
            DetectionsListview.View = View.Details;
            DetectionsListview.ItemSelectionChanged += DetectionsListview_ItemSelectionChanged;
            // 
            // TitleColumnHeader
            // 
            TitleColumnHeader.Text = "Title";
            TitleColumnHeader.Width = 205;
            // 
            // LocationColumnHeader
            // 
            LocationColumnHeader.Text = "Location";
            // 
            // AttemptsColumnHeader
            // 
            AttemptsColumnHeader.Text = "Attempts";
            AttemptsColumnHeader.TextAlign = HorizontalAlignment.Right;
            AttemptsColumnHeader.Width = 65;
            // 
            // IntervalColumnHeader
            // 
            IntervalColumnHeader.Text = "Interval";
            IntervalColumnHeader.TextAlign = HorizontalAlignment.Right;
            IntervalColumnHeader.Width = 55;
            // 
            // DetectionsWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DetectionsListview);
            Controls.Add(CreateDetectionButton);
            Name = "DetectionsWidget";
            Size = new Size(350, 433);
            Controls.SetChildIndex(CreateDetectionButton, 0);
            Controls.SetChildIndex(DetectionsListview, 0);
            ResumeLayout(false);
        }

        #endregion
        private Button CreateDetectionButton;
        private ListView DetectionsListview;
        private ColumnHeader TitleColumnHeader;
        private ColumnHeader LocationColumnHeader;
        private ColumnHeader AttemptsColumnHeader;
        private ColumnHeader IntervalColumnHeader;
    }
}
