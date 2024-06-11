namespace PowerAutomation.Controls.Imitations
{
    partial class ClickImitationControl
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
            label1 = new Label();
            ClickImitationGroupbox = new GroupBox();
            YOffsetTextbox = new MaskedTextBox();
            LeftClickRadio = new RadioButton();
            DoubleClickRadio = new RadioButton();
            YOffsetLabel = new Label();
            XOffsetTextbox = new MaskedTextBox();
            XOffsetLabel = new Label();
            ClickImitationGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ClickImitationGroupbox
            // 
            ClickImitationGroupbox.Controls.Add(YOffsetTextbox);
            ClickImitationGroupbox.Controls.Add(LeftClickRadio);
            ClickImitationGroupbox.Controls.Add(DoubleClickRadio);
            ClickImitationGroupbox.Controls.Add(YOffsetLabel);
            ClickImitationGroupbox.Controls.Add(XOffsetTextbox);
            ClickImitationGroupbox.Controls.Add(XOffsetLabel);
            ClickImitationGroupbox.Font = new Font("Tahoma", 12F);
            ClickImitationGroupbox.Location = new Point(0, 0);
            ClickImitationGroupbox.Name = "ClickImitationGroupbox";
            ClickImitationGroupbox.Size = new Size(325, 96);
            ClickImitationGroupbox.TabIndex = 1034;
            ClickImitationGroupbox.TabStop = false;
            ClickImitationGroupbox.Text = "Click Imitation";
            // 
            // YOffsetTextbox
            // 
            YOffsetTextbox.Location = new Point(230, 56);
            YOffsetTextbox.Name = "YOffsetTextbox";
            YOffsetTextbox.Size = new Size(49, 27);
            YOffsetTextbox.TabIndex = 6;
            YOffsetTextbox.Text = "0";
            YOffsetTextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // LeftClickRadio
            // 
            LeftClickRadio.AutoSize = true;
            LeftClickRadio.Checked = true;
            LeftClickRadio.Location = new Point(8, 26);
            LeftClickRadio.Name = "LeftClickRadio";
            LeftClickRadio.Size = new Size(108, 23);
            LeftClickRadio.TabIndex = 1;
            LeftClickRadio.TabStop = true;
            LeftClickRadio.Text = "Single Click";
            LeftClickRadio.UseVisualStyleBackColor = true;
            // 
            // DoubleClickRadio
            // 
            DoubleClickRadio.AutoSize = true;
            DoubleClickRadio.Location = new Point(122, 26);
            DoubleClickRadio.Name = "DoubleClickRadio";
            DoubleClickRadio.Size = new Size(115, 23);
            DoubleClickRadio.TabIndex = 0;
            DoubleClickRadio.Text = "Double Click";
            DoubleClickRadio.UseVisualStyleBackColor = true;
            // 
            // YOffsetLabel
            // 
            YOffsetLabel.AutoSize = true;
            YOffsetLabel.Location = new Point(205, 59);
            YOffsetLabel.Name = "YOffsetLabel";
            YOffsetLabel.Size = new Size(19, 19);
            YOffsetLabel.TabIndex = 3;
            YOffsetLabel.Text = "Y";
            // 
            // XOffsetTextbox
            // 
            XOffsetTextbox.Location = new Point(133, 56);
            XOffsetTextbox.Name = "XOffsetTextbox";
            XOffsetTextbox.Size = new Size(49, 27);
            XOffsetTextbox.TabIndex = 5;
            XOffsetTextbox.Text = "0";
            XOffsetTextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // XOffsetLabel
            // 
            XOffsetLabel.AutoSize = true;
            XOffsetLabel.Location = new Point(8, 59);
            XOffsetLabel.Name = "XOffsetLabel";
            XOffsetLabel.Size = new Size(119, 19);
            XOffsetLabel.TabIndex = 2;
            XOffsetLabel.Text = "Click Offset:   X";
            // 
            // ClickImitationControl
            // 
            Controls.Add(ClickImitationGroupbox);
            Font = new Font("Tahoma", 14F);
            Name = "ClickImitationControl";
            Size = new Size(328, 311);
            ClickImitationGroupbox.ResumeLayout(false);
            ClickImitationGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox ClickImitationGroupbox;
        private RadioButton DoubleClickRadio;
        private RadioButton LeftClickRadio;
        private Label XOffsetLabel;
        private Label YOffsetLabel;
        private MaskedTextBox XOffsetTextbox;
        private MaskedTextBox YOffsetTextbox;
    }
}
