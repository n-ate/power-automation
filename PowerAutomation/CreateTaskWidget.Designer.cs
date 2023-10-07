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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskWidget));
            CreateTaskBackButton = new Button();
            Header = new Label();
            ManipulationTaskButton = new Button();
            DetectionTaskButton = new Button();
            NavigationTaskButton = new Button();
            imageButton1 = new Controls.ImageButton();
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
            CreateTaskBackButton.Image = (Image)resources.GetObject("CreateTaskBackButton.Image");
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
            // imageButton1
            // 
            imageButton1.BackColor = Color.Transparent;
            imageButton1.FlatAppearance.BorderSize = 0;
            imageButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            imageButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            imageButton1.FlatStyle = FlatStyle.Flat;
            imageButton1.Image = (Image)resources.GetObject("imageButton1.Image");
            imageButton1.Location = new Point(122, 8);
            imageButton1.MouseOverImage = (Image)resources.GetObject("imageButton1.MouseOverImage");
            imageButton1.Name = "imageButton1";
            imageButton1.Size = new Size(75, 40);
            imageButton1.TabIndex = 6;
            imageButton1.UseVisualStyleBackColor = false;
            // 
            // CreateTaskWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(imageButton1);
            Controls.Add(CreateTaskBackButton);
            Controls.Add(Header);
            Controls.Add(ManipulationTaskButton);
            Controls.Add(NavigationTaskButton);
            Controls.Add(DetectionTaskButton);
            Name = "CreateTaskWidget";
            Size = new Size(200, 233);
            Load += CreateTaskWidget_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button CreateTaskBackButton;
        private Label Header;
        private Button ManipulationTaskButton;
        private Button DetectionTaskButton;
        private Button NavigationTaskButton;
        private Controls.ImageButton imageButton1;
    }
}
