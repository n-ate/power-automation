namespace PowerAutomation.Controls.Procedures
{
    partial class CompositeProcedureEditorWidget
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
            KeyLabel = new Label();
            KeyTextbox = new TextBox();
            DescriptionTextbox = new TextBox();
            DescriptionLabel = new Label();
            TitleLabel = new Label();
            TitleTextbox = new TextBox();
            ScrollAreaPanel = new Panel();
            PreconditionImage = new PictureBox();
            ProcedureTemplate = new Panel();
            ActionImage = new PictureBox();
            PostconditionImage = new PictureBox();
            DragHandleButton = new ImageButton();
            DeleteButton = new ImageButton();
            PreconditionLabel = new Label();
            ActionLabel = new Label();
            PostconditionLabel = new Label();
            ScrollAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PreconditionImage).BeginInit();
            ProcedureTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActionImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PostconditionImage).BeginInit();
            SuspendLayout();
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Font = new Font("Tahoma", 12F);
            KeyLabel.Location = new Point(13, 54);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(34, 19);
            KeyLabel.TabIndex = 1031;
            KeyLabel.Text = "Key";
            // 
            // KeyTextbox
            // 
            KeyTextbox.Location = new Point(82, 50);
            KeyTextbox.Name = "KeyTextbox";
            KeyTextbox.Size = new Size(255, 23);
            KeyTextbox.TabIndex = 1030;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(13, 112);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextbox.Size = new Size(324, 89);
            DescriptionTextbox.TabIndex = 1029;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Tahoma", 12F);
            DescriptionLabel.Location = new Point(10, 90);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 19);
            DescriptionLabel.TabIndex = 1028;
            DescriptionLabel.Text = "Description";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 12F);
            TitleLabel.Location = new Point(13, 16);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(40, 19);
            TitleLabel.TabIndex = 1027;
            TitleLabel.Text = "Title";
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(82, 12);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(255, 23);
            TitleTextbox.TabIndex = 1026;
            // 
            // ScrollAreaPanel
            // 
            ScrollAreaPanel.AutoScroll = true;
            ScrollAreaPanel.AutoScrollMinSize = new Size(0, 457);
            ScrollAreaPanel.BorderStyle = BorderStyle.Fixed3D;
            ScrollAreaPanel.Controls.Add(PostconditionLabel);
            ScrollAreaPanel.Controls.Add(ActionLabel);
            ScrollAreaPanel.Controls.Add(PreconditionLabel);
            ScrollAreaPanel.Controls.Add(ProcedureTemplate);
            ScrollAreaPanel.Controls.Add(DescriptionTextbox);
            ScrollAreaPanel.Controls.Add(TitleTextbox);
            ScrollAreaPanel.Controls.Add(KeyLabel);
            ScrollAreaPanel.Controls.Add(TitleLabel);
            ScrollAreaPanel.Controls.Add(KeyTextbox);
            ScrollAreaPanel.Controls.Add(DescriptionLabel);
            ScrollAreaPanel.Location = new Point(8, 51);
            ScrollAreaPanel.Margin = new Padding(8);
            ScrollAreaPanel.Name = "ScrollAreaPanel";
            ScrollAreaPanel.Size = new Size(366, 460);
            ScrollAreaPanel.TabIndex = 1032;
            // 
            // PreconditionImage
            // 
            PreconditionImage.Location = new Point(40, 0);
            PreconditionImage.Margin = new Padding(0);
            PreconditionImage.Name = "PreconditionImage";
            PreconditionImage.Size = new Size(83, 83);
            PreconditionImage.TabIndex = 1040;
            PreconditionImage.TabStop = false;
            // 
            // ProcedureTemplate
            // 
            ProcedureTemplate.BackColor = SystemColors.ControlLight;
            ProcedureTemplate.BorderStyle = BorderStyle.FixedSingle;
            ProcedureTemplate.Controls.Add(DeleteButton);
            ProcedureTemplate.Controls.Add(DragHandleButton);
            ProcedureTemplate.Controls.Add(PostconditionImage);
            ProcedureTemplate.Controls.Add(ActionImage);
            ProcedureTemplate.Controls.Add(PreconditionImage);
            ProcedureTemplate.Font = new Font("Tahoma", 12F);
            ProcedureTemplate.ForeColor = SystemColors.ControlText;
            ProcedureTemplate.Location = new Point(7, 241);
            ProcedureTemplate.Margin = new Padding(8);
            ProcedureTemplate.Name = "ProcedureTemplate";
            ProcedureTemplate.Size = new Size(330, 85);
            ProcedureTemplate.TabIndex = 1001;
            ProcedureTemplate.TabStop = true;
            // 
            // ActionImage
            // 
            ActionImage.Location = new Point(123, 0);
            ActionImage.Margin = new Padding(0);
            ActionImage.Name = "ActionImage";
            ActionImage.Size = new Size(83, 83);
            ActionImage.TabIndex = 1041;
            ActionImage.TabStop = false;
            // 
            // PostconditionImage
            // 
            PostconditionImage.Location = new Point(206, 0);
            PostconditionImage.Margin = new Padding(0);
            PostconditionImage.Name = "PostconditionImage";
            PostconditionImage.Size = new Size(83, 83);
            PostconditionImage.TabIndex = 1042;
            PostconditionImage.TabStop = false;
            // 
            // DragHandleButton
            // 
            DragHandleButton.BackColor = Color.Transparent;
            DragHandleButton.FlatAppearance.BorderSize = 0;
            DragHandleButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DragHandleButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            DragHandleButton.FlatStyle = FlatStyle.Flat;
            DragHandleButton.Location = new Point(-1, -1);
            DragHandleButton.MouseOverImage = null;
            DragHandleButton.Name = "DragHandleButton";
            DragHandleButton.Size = new Size(40, 85);
            DragHandleButton.TabIndex = 1043;
            DragHandleButton.Text = "==";
            DragHandleButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DeleteButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(286, 0);
            DeleteButton.MouseOverImage = null;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(40, 83);
            DeleteButton.TabIndex = 1044;
            DeleteButton.Text = "Del";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // PreconditionLabel
            // 
            PreconditionLabel.AutoSize = true;
            PreconditionLabel.Location = new Point(52, 226);
            PreconditionLabel.Name = "PreconditionLabel";
            PreconditionLabel.Size = new Size(75, 15);
            PreconditionLabel.TabIndex = 1032;
            PreconditionLabel.Text = "Precondition";
            // 
            // ActionLabel
            // 
            ActionLabel.AutoSize = true;
            ActionLabel.Location = new Point(151, 226);
            ActionLabel.Name = "ActionLabel";
            ActionLabel.Size = new Size(42, 15);
            ActionLabel.TabIndex = 1033;
            ActionLabel.Text = "Action";
            // 
            // PostconditionLabel
            // 
            PostconditionLabel.AutoSize = true;
            PostconditionLabel.Location = new Point(214, 226);
            PostconditionLabel.Name = "PostconditionLabel";
            PostconditionLabel.Size = new Size(81, 15);
            PostconditionLabel.TabIndex = 1034;
            PostconditionLabel.Text = "Postcondition";
            // 
            // CompositeProcedureEditorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ScrollAreaPanel);
            Name = "CompositeProcedureEditorWidget";
            Size = new Size(383, 522);
            Controls.SetChildIndex(ScrollAreaPanel, 0);
            ScrollAreaPanel.ResumeLayout(false);
            ScrollAreaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PreconditionImage).EndInit();
            ProcedureTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ActionImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PostconditionImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label KeyLabel;
        private TextBox KeyTextbox;
        private TextBox DescriptionTextbox;
        private Label DescriptionLabel;
        private Label TitleLabel;
        private TextBox TitleTextbox;
        private Panel ScrollAreaPanel;
        private Panel ProcedureTemplate;
        private ImageButton DragHandleButton;
        private PictureBox PostconditionImage;
        private PictureBox ActionImage;
        private PictureBox PreconditionImage;
        private ImageButton DeleteButton;
        private Label PostconditionLabel;
        private Label ActionLabel;
        private Label PreconditionLabel;
    }
}
