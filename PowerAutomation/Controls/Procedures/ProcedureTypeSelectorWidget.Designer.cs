namespace PowerAutomation.Controls.Procedures
{
    partial class ProcedureTypeSelectorWidget
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
            ProcedureTemplateButton = new Button();
            SuspendLayout();
            // 
            // ProcedureTemplateButton
            // 
            ProcedureTemplateButton.Font = new Font("Tahoma", 12F);
            ProcedureTemplateButton.Location = new Point(16, 54);
            ProcedureTemplateButton.Margin = new Padding(16, 8, 16, 16);
            ProcedureTemplateButton.Name = "ProcedureTemplateButton";
            ProcedureTemplateButton.Size = new Size(186, 40);
            ProcedureTemplateButton.TabIndex = 1000;
            ProcedureTemplateButton.Text = "{procedure template}";
            ProcedureTemplateButton.UseVisualStyleBackColor = true;
            ProcedureTemplateButton.Click += ProcedureButton_Click;
            // 
            // ProcedureTypeSelectorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProcedureTemplateButton);
            Name = "ProcedureTypeSelectorWidget";
            Size = new Size(218, 109);
            Controls.SetChildIndex(ProcedureTemplateButton, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button ProcedureTemplateButton;
    }
}
