namespace PowerAutomation
{
    partial class CreateTaskWidget
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
            ManipulationTaskButton = new Button();
            DetectionTaskButton = new Button();
            NavigationTaskButton = new Button();
            SuspendLayout();
            // 
            // ManipulationTaskButton
            // 
            ManipulationTaskButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ManipulationTaskButton.Location = new Point(16, 171);
            ManipulationTaskButton.Margin = new Padding(16, 8, 16, 16);
            ManipulationTaskButton.Name = "ManipulationTaskButton";
            ManipulationTaskButton.Size = new Size(168, 40);
            ManipulationTaskButton.TabIndex = 4;
            ManipulationTaskButton.Text = "Manipulation Task";
            ManipulationTaskButton.UseVisualStyleBackColor = true;
            // 
            // DetectionTaskButton
            // 
            DetectionTaskButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetectionTaskButton.Location = new Point(16, 59);
            DetectionTaskButton.Margin = new Padding(16, 8, 16, 8);
            DetectionTaskButton.Name = "DetectionTaskButton";
            DetectionTaskButton.Size = new Size(168, 40);
            DetectionTaskButton.TabIndex = 1;
            DetectionTaskButton.Text = "Detection Task";
            DetectionTaskButton.UseVisualStyleBackColor = true;
            DetectionTaskButton.Click += DetectionTaskButton_Click;
            // 
            // NavigationTaskButton
            // 
            NavigationTaskButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NavigationTaskButton.Location = new Point(16, 115);
            NavigationTaskButton.Margin = new Padding(16, 8, 16, 8);
            NavigationTaskButton.Name = "NavigationTaskButton";
            NavigationTaskButton.Size = new Size(168, 40);
            NavigationTaskButton.TabIndex = 3;
            NavigationTaskButton.Text = "Navigation Task";
            NavigationTaskButton.UseVisualStyleBackColor = true;
            // 
            // CreateTaskWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(ManipulationTaskButton);
            Controls.Add(NavigationTaskButton);
            Controls.Add(DetectionTaskButton);
            Name = "CreateTaskWidget";
            Size = new Size(200, 233);
            Controls.SetChildIndex(DetectionTaskButton, 0);
            Controls.SetChildIndex(NavigationTaskButton, 0);
            Controls.SetChildIndex(ManipulationTaskButton, 0);
            ResumeLayout(false);
        }

        #endregion
        private Button ManipulationTaskButton;
        private Button DetectionTaskButton;
        private Button NavigationTaskButton;
    }
}
