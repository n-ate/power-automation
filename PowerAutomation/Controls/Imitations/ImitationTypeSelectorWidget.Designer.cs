namespace PowerAutomation.Controls.Imitations
{
    partial class ImitationTypeSelectorWidget
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
            ImitationTemplateButton = new Button();
            SuspendLayout();
            // 
            // ImitationTemplateButton
            // 
            ImitationTemplateButton.Font = new Font("Tahoma", 12F);
            ImitationTemplateButton.Location = new Point(16, 54);
            ImitationTemplateButton.Margin = new Padding(16, 8, 16, 16);
            ImitationTemplateButton.Name = "ImitationTemplateButton";
            ImitationTemplateButton.Size = new Size(186, 40);
            ImitationTemplateButton.TabIndex = 1000;
            ImitationTemplateButton.Text = "{imitation template}";
            ImitationTemplateButton.UseVisualStyleBackColor = true;
            ImitationTemplateButton.Click += ImitationButton_Click;
            // 
            // ImitationTypeSelectorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ImitationTemplateButton);
            Name = "ImitationTypeSelectorWidget";
            Size = new Size(218, 109);
            Controls.SetChildIndex(ImitationTemplateButton, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button ImitationTemplateButton;
    }
}
