namespace PowerAutomation.Widgets.Procedures
{
    partial class ProceduresWidget
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
            CreateProcedureButton = new Button();
            ProceduresListview = new ListView();
            AboutColumnHeader = new ColumnHeader();
            TitleColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // CreateProcedureButton
            // 
            CreateProcedureButton.BackColor = SystemColors.ButtonFace;
            CreateProcedureButton.FlatStyle = FlatStyle.Flat;
            CreateProcedureButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateProcedureButton.Location = new Point(221, 43);
            CreateProcedureButton.Name = "CreateProcedureButton";
            CreateProcedureButton.Size = new Size(114, 32);
            CreateProcedureButton.TabIndex = 1027;
            CreateProcedureButton.Text = "Create New";
            CreateProcedureButton.UseVisualStyleBackColor = false;
            CreateProcedureButton.Click += CreateProcedureButton_Click;
            // 
            // ProceduresListview
            // 
            ProceduresListview.Columns.AddRange(new ColumnHeader[] { TitleColumnHeader, AboutColumnHeader });
            ProceduresListview.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ProceduresListview.Location = new Point(16, 91);
            ProceduresListview.Name = "ProceduresListview";
            ProceduresListview.Size = new Size(319, 327);
            ProceduresListview.TabIndex = 1028;
            ProceduresListview.UseCompatibleStateImageBehavior = false;
            ProceduresListview.View = View.Details;
            ProceduresListview.ItemSelectionChanged += ProceduresListview_ItemSelectionChanged;
            // 
            // AboutColumnHeader
            // 
            AboutColumnHeader.Text = "About";
            AboutColumnHeader.Width = 200;
            // 
            // TitleColumnHeader
            // 
            TitleColumnHeader.Text = "Title";
            TitleColumnHeader.Width = 150;
            // 
            // ProceduresWidget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProceduresListview);
            Controls.Add(CreateProcedureButton);
            Name = "ProceduresWidget";
            Size = new Size(350, 433);
            Controls.SetChildIndex(CreateProcedureButton, 0);
            Controls.SetChildIndex(ProceduresListview, 0);
            ResumeLayout(false);
        }

        #endregion
        private Button CreateProcedureButton;
        private ListView ProceduresListview;
        private ColumnHeader TitleColumnHeader;
        private ColumnHeader AboutColumnHeader;
    }
}
