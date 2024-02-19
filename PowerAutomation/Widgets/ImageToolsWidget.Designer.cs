namespace PowerAutomation.Widgets
{
    partial class ImageToolsWidget
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
            RefreshImageButton = new Controls.ImageButton();
            SnippetButton = new Controls.ImageButton();
            SuspendLayout();
            // 
            // RefreshImageButton
            // 
            RefreshImageButton.BackColor = Color.Transparent;
            RefreshImageButton.FlatAppearance.BorderSize = 0;
            RefreshImageButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            RefreshImageButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            RefreshImageButton.FlatStyle = FlatStyle.Flat;
            RefreshImageButton.Image = Properties.Images.refresh_picture_64;
            RefreshImageButton.Location = new Point(84, 53);
            RefreshImageButton.MouseOverImage = null;
            RefreshImageButton.Name = "RefreshImageButton";
            RefreshImageButton.Size = new Size(75, 60);
            RefreshImageButton.TabIndex = 1001;
            RefreshImageButton.TabStop = false;
            RefreshImageButton.UseVisualStyleBackColor = false;
            RefreshImageButton.Click += RefreshImageButton_Click;
            // 
            // SnippetButton
            // 
            SnippetButton.BackColor = Color.Transparent;
            SnippetButton.FlatAppearance.BorderSize = 0;
            SnippetButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SnippetButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SnippetButton.FlatStyle = FlatStyle.Flat;
            SnippetButton.Image = Properties.Images.snippet_select_64;
            SnippetButton.Location = new Point(3, 53);
            SnippetButton.MouseOverImage = null;
            SnippetButton.Name = "SnippetButton";
            SnippetButton.Size = new Size(75, 60);
            SnippetButton.TabIndex = 1002;
            SnippetButton.TabStop = false;
            SnippetButton.UseVisualStyleBackColor = false;
            // 
            // ImageToolsWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SnippetButton);
            Controls.Add(RefreshImageButton);
            Name = "ImageToolsWidget";
            Size = new Size(165, 303);
            Controls.SetChildIndex(RefreshImageButton, 0);
            Controls.SetChildIndex(SnippetButton, 0);
            ResumeLayout(false);
        }

        #endregion
        private Controls.ImageButton RefreshImageButton;
        private Controls.ImageButton SnippetButton;
    }
}
