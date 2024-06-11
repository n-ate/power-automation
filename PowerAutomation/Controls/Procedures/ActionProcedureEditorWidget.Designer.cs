namespace PowerAutomation.Controls.Procedures
{
    partial class ActionProcedureEditorWidget
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
            KeyLabel = new Label();
            KeyTextbox = new TextBox();
            PreconditionImage = new PictureBox();
            SelectPreconditionDetectionButton = new Button();
            PreconditionGroupbox = new GroupBox();
            PostconditionGroupbox = new GroupBox();
            SelectPostconditionDetectionButton = new Button();
            PostconditionImage = new PictureBox();
            SimulatedActionGroupbox = new GroupBox();
            SelectActionTypeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PreconditionImage).BeginInit();
            PreconditionGroupbox.SuspendLayout();
            PostconditionGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PostconditionImage).BeginInit();
            SimulatedActionGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(13, 153);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextbox.Size = new Size(321, 89);
            DescriptionTextbox.TabIndex = 1016;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 12F);
            DescriptionLabel.Location = new Point(10, 131);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 19);
            DescriptionLabel.TabIndex = 1015;
            DescriptionLabel.Text = "Description";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 12F);
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
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Font = new Font("Tahoma", 12F);
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
            // PreconditionImage
            // 
            PreconditionImage.Location = new Point(13, 22);
            PreconditionImage.Name = "PreconditionImage";
            PreconditionImage.Size = new Size(80, 80);
            PreconditionImage.TabIndex = 1029;
            PreconditionImage.TabStop = false;
            // 
            // SelectPreconditionDetectionButton
            // 
            SelectPreconditionDetectionButton.BackColor = SystemColors.ButtonFace;
            SelectPreconditionDetectionButton.FlatStyle = FlatStyle.Flat;
            SelectPreconditionDetectionButton.Font = new Font("Tahoma", 12F);
            SelectPreconditionDetectionButton.Location = new Point(110, 22);
            SelectPreconditionDetectionButton.Name = "SelectPreconditionDetectionButton";
            SelectPreconditionDetectionButton.Size = new Size(141, 32);
            SelectPreconditionDetectionButton.TabIndex = 1032;
            SelectPreconditionDetectionButton.Text = "Select Detection";
            SelectPreconditionDetectionButton.UseVisualStyleBackColor = false;
            SelectPreconditionDetectionButton.Click += SelectPreconditionDetectionButton_Click;
            // 
            // PreconditionGroupbox
            // 
            PreconditionGroupbox.Controls.Add(SelectPreconditionDetectionButton);
            PreconditionGroupbox.Controls.Add(PreconditionImage);
            PreconditionGroupbox.Location = new Point(13, 249);
            PreconditionGroupbox.Name = "PreconditionGroupbox";
            PreconditionGroupbox.Size = new Size(321, 117);
            PreconditionGroupbox.TabIndex = 1030;
            PreconditionGroupbox.TabStop = false;
            PreconditionGroupbox.Text = "Pre-condition";
            // 
            // PostconditionGroupbox
            // 
            PostconditionGroupbox.Anchor = AnchorStyles.Bottom;
            PostconditionGroupbox.Controls.Add(SelectPostconditionDetectionButton);
            PostconditionGroupbox.Controls.Add(PostconditionImage);
            PostconditionGroupbox.Location = new Point(13, 476);
            PostconditionGroupbox.Name = "PostconditionGroupbox";
            PostconditionGroupbox.Size = new Size(321, 117);
            PostconditionGroupbox.TabIndex = 1031;
            PostconditionGroupbox.TabStop = false;
            PostconditionGroupbox.Text = "Post-condition";
            // 
            // SelectPostconditionDetectionButton
            // 
            SelectPostconditionDetectionButton.BackColor = SystemColors.ButtonFace;
            SelectPostconditionDetectionButton.FlatStyle = FlatStyle.Flat;
            SelectPostconditionDetectionButton.Font = new Font("Tahoma", 12F);
            SelectPostconditionDetectionButton.Location = new Point(110, 22);
            SelectPostconditionDetectionButton.Name = "SelectPostconditionDetectionButton";
            SelectPostconditionDetectionButton.Size = new Size(141, 32);
            SelectPostconditionDetectionButton.TabIndex = 1032;
            SelectPostconditionDetectionButton.Text = "Select Detection";
            SelectPostconditionDetectionButton.UseVisualStyleBackColor = false;
            SelectPostconditionDetectionButton.Click += SelectPostconditionDetectionButton_Click;
            // 
            // PostconditionImage
            // 
            PostconditionImage.Location = new Point(13, 22);
            PostconditionImage.Name = "PostconditionImage";
            PostconditionImage.Size = new Size(80, 80);
            PostconditionImage.TabIndex = 1029;
            PostconditionImage.TabStop = false;
            // 
            // SimulatedActionGroupbox
            // 
            SimulatedActionGroupbox.Controls.Add(SelectActionTypeButton);
            SimulatedActionGroupbox.Location = new Point(13, 372);
            SimulatedActionGroupbox.Name = "SimulatedActionGroupbox";
            SimulatedActionGroupbox.Size = new Size(321, 96);
            SimulatedActionGroupbox.TabIndex = 1033;
            SimulatedActionGroupbox.TabStop = false;
            SimulatedActionGroupbox.Text = "Simulated Action";
            // 
            // SelectActionTypeButton
            // 
            SelectActionTypeButton.BackColor = SystemColors.ButtonFace;
            SelectActionTypeButton.FlatStyle = FlatStyle.Flat;
            SelectActionTypeButton.Font = new Font("Tahoma", 12F);
            SelectActionTypeButton.Location = new Point(80, 32);
            SelectActionTypeButton.Name = "SelectActionTypeButton";
            SelectActionTypeButton.Size = new Size(162, 32);
            SelectActionTypeButton.TabIndex = 1033;
            SelectActionTypeButton.Text = "Select Action Type";
            SelectActionTypeButton.UseVisualStyleBackColor = false;
            SelectActionTypeButton.Click += SelectActionTypeButton_Click;
            // 
            // ActionProcedureEditorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SimulatedActionGroupbox);
            Controls.Add(PostconditionGroupbox);
            Controls.Add(PreconditionGroupbox);
            Controls.Add(KeyLabel);
            Controls.Add(KeyTextbox);
            Controls.Add(DescriptionTextbox);
            Controls.Add(DescriptionLabel);
            Controls.Add(TitleLabel);
            Controls.Add(TitleTextbox);
            Name = "ActionProcedureEditorWidget";
            Size = new Size(350, 606);
            Controls.SetChildIndex(TitleTextbox, 0);
            Controls.SetChildIndex(TitleLabel, 0);
            Controls.SetChildIndex(DescriptionLabel, 0);
            Controls.SetChildIndex(DescriptionTextbox, 0);
            Controls.SetChildIndex(KeyTextbox, 0);
            Controls.SetChildIndex(KeyLabel, 0);
            Controls.SetChildIndex(PreconditionGroupbox, 0);
            Controls.SetChildIndex(PostconditionGroupbox, 0);
            Controls.SetChildIndex(SimulatedActionGroupbox, 0);
            ((System.ComponentModel.ISupportInitialize)PreconditionImage).EndInit();
            PreconditionGroupbox.ResumeLayout(false);
            PostconditionGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PostconditionImage).EndInit();
            SimulatedActionGroupbox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox DescriptionTextbox;
        private Label DescriptionLabel;
        private Label TitleLabel;
        private TextBox TitleTextbox;
        private Label KeyLabel;
        private TextBox KeyTextbox;
        private PictureBox PreconditionImage;
        private Button SelectPreconditionDetectionButton;
        private GroupBox PreconditionGroupbox;
        private GroupBox PostconditionGroupbox;
        private Button SelectPostconditionDetectionButton;
        private PictureBox PostconditionImage;
        private GroupBox SimulatedActionGroupbox;
        private Button SelectActionTypeButton;
    }
}
