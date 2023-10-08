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
            CreateTaskBackButton = new Button();
            Header = new Label();
            ManipulationTaskButton = new Button();
            DetectionTaskButton = new Button();
            NavigationTaskButton = new Button();
            BackButton = new Controls.ImageButton();
            SuspendLayout();
            // 
            // CreateTaskBackButton
            // 
            CreateTaskBackButton.BackColor = Color.Transparent;
            CreateTaskBackButton.FlatAppearance.BorderSize = 0;
            CreateTaskBackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CreateTaskBackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CreateTaskBackButton.FlatStyle = FlatStyle.Flat;
            CreateTaskBackButton.ForeColor = Color.Transparent;
            CreateTaskBackButton.Location = new Point(3, 3);
            CreateTaskBackButton.Name = "CreateTaskBackButton";
            CreateTaskBackButton.Size = new Size(48, 32);
            CreateTaskBackButton.TabIndex = 5;
            CreateTaskBackButton.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            Header.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(16, 3);
            Header.Margin = new Padding(16, 16, 16, 8);
            Header.Name = "Header";
            Header.Size = new Size(168, 40);
            Header.TabIndex = 0;
            Header.Text = "Create Task";
            Header.TextAlign = ContentAlignment.MiddleCenter;
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
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Image = Properties.Images.back_arrow_32;
            BackButton.Location = new Point(5, 5);
            BackButton.MouseOverImage = Properties.Images.back_arrow_light_32;
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(37, 32);
            BackButton.TabIndex = 6;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CreateTaskWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BackButton);
            Controls.Add(CreateTaskBackButton);
            Controls.Add(Header);
            Controls.Add(ManipulationTaskButton);
            Controls.Add(NavigationTaskButton);
            Controls.Add(DetectionTaskButton);
            Name = "CreateTaskWidget";
            Size = new Size(200, 233);
            ResumeLayout(false);
        }

        #endregion
        private Button CreateTaskBackButton;
        private Label Header;
        private Button ManipulationTaskButton;
        private Button DetectionTaskButton;
        private Button NavigationTaskButton;
        private Controls.ImageButton BackButton;
    }
}
