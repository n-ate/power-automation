namespace PowerAutomation.Widgets.Procedures
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
            ActionProcedureButton = new Button();
            CompositeProcedureButton = new Button();
            SuspendLayout();
            // 
            // ActionProcedureButton
            // 
            ActionProcedureButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ActionProcedureButton.Location = new Point(16, 54);
            ActionProcedureButton.Margin = new Padding(16, 8, 16, 16);
            ActionProcedureButton.Name = "ActionProcedureButton";
            ActionProcedureButton.Size = new Size(168, 40);
            ActionProcedureButton.TabIndex = 1000;
            ActionProcedureButton.Text = "Action Procedure";
            ActionProcedureButton.UseVisualStyleBackColor = true;
            ActionProcedureButton.Click += ActionProcedureButton_Click;
            // 
            // CompositeProcedureButton
            // 
            CompositeProcedureButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CompositeProcedureButton.Location = new Point(16, 107);
            CompositeProcedureButton.Margin = new Padding(16, 8, 16, 16);
            CompositeProcedureButton.Name = "CompositeProcedureButton";
            CompositeProcedureButton.Size = new Size(168, 40);
            CompositeProcedureButton.TabIndex = 1001;
            CompositeProcedureButton.Text = "Composite Procedure";
            CompositeProcedureButton.UseVisualStyleBackColor = true;
            CompositeProcedureButton.Click += CompositeProcedureButton_Click;
            // 
            // ProcedureTypeSelectorWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CompositeProcedureButton);
            Controls.Add(ActionProcedureButton);
            Name = "ProcedureTypeSelectorWidget";
            Size = new Size(200, 165);
            Controls.SetChildIndex(ActionProcedureButton, 0);
            Controls.SetChildIndex(CompositeProcedureButton, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button ActionProcedureButton;
        private Button CompositeProcedureButton;
    }
}
