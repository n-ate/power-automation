namespace PowerAutomation.Controls
{
    partial class WorkspacesWidget
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
            CreateDetectionButton = new Button();
            WorkspacesListview = new ListView();
            TitleColumnHeader = new ColumnHeader();
            ProcessNameColumnDescription = new ColumnHeader();
            ShowDeletedCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // CreateDetectionButton
            // 
            CreateDetectionButton.BackColor = SystemColors.ButtonFace;
            CreateDetectionButton.FlatStyle = FlatStyle.Flat;
            CreateDetectionButton.Font = new Font("Tahoma", 12F);
            CreateDetectionButton.Location = new Point(221, 43);
            CreateDetectionButton.Name = "CreateDetectionButton";
            CreateDetectionButton.Size = new Size(114, 32);
            CreateDetectionButton.TabIndex = 1027;
            CreateDetectionButton.Text = "Create New";
            CreateDetectionButton.UseVisualStyleBackColor = false;
            CreateDetectionButton.Click += CreateWorkspaceButton_Click;
            // 
            // WorkspacesListview
            // 
            WorkspacesListview.Columns.AddRange(new ColumnHeader[] { TitleColumnHeader, ProcessNameColumnDescription });
            WorkspacesListview.Font = new Font("Tahoma", 10F);
            WorkspacesListview.Location = new Point(15, 90);
            WorkspacesListview.Name = "WorkspacesListview";
            WorkspacesListview.Size = new Size(320, 326);
            WorkspacesListview.TabIndex = 1028;
            WorkspacesListview.UseCompatibleStateImageBehavior = false;
            WorkspacesListview.View = View.Details;
            WorkspacesListview.ItemSelectionChanged += WorkspacesListview_ItemSelectionChanged;
            // 
            // TitleColumnHeader
            // 
            TitleColumnHeader.Text = "Title";
            TitleColumnHeader.Width = 200;
            // 
            // ProcessNameColumnDescription
            // 
            ProcessNameColumnDescription.Text = "Process";
            ProcessNameColumnDescription.Width = 200;
            // 
            // ShowDeletedCheckbox
            // 
            ShowDeletedCheckbox.AutoSize = true;
            ShowDeletedCheckbox.Location = new Point(16, 60);
            ShowDeletedCheckbox.Name = "ShowInactiveCheckbox";
            ShowDeletedCheckbox.Size = new Size(98, 19);
            ShowDeletedCheckbox.TabIndex = 1029;
            ShowDeletedCheckbox.Text = "Show Deleted";
            ShowDeletedCheckbox.UseVisualStyleBackColor = true;
            ShowDeletedCheckbox.CheckedChanged += ShowDeletedCheckbox_CheckedChanged;
            // 
            // WorkspacesWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ShowDeletedCheckbox);
            Controls.Add(WorkspacesListview);
            Controls.Add(CreateDetectionButton);
            Name = "WorkspacesWidget";
            Size = new Size(350, 433);
            Controls.SetChildIndex(CreateDetectionButton, 0);
            Controls.SetChildIndex(WorkspacesListview, 0);
            Controls.SetChildIndex(ShowDeletedCheckbox, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CreateDetectionButton;
        private ListView WorkspacesListview;
        private ColumnHeader TitleColumnHeader;
        private ColumnHeader ProcessNameColumnDescription;
        private CheckBox ShowDeletedCheckbox;
    }
}
