namespace PowerAutomation.Controls
{
    public class Widget : UserControl
    {
        private ImageButton BackButton;
        private Label Header;

        [Obsolete]
        public Widget()
        {
            InitializeComponent();

            _ = Header!.Text; //added to present as not null
            _ = BackButton!.Text;
        }

        public Widget(string header, Widget? caller)
        {
            InitializeComponent();

            Caller = caller;
            BackButton!.Click += (s, e) => TryNavigateBack();

            this.Resize += async (s, e) => await this.EnqueUIChangeToRunAfterDelay(nameof(UpdateWidgetLayout), 180, c => UpdateWidgetLayout(header));

            this.EnableDragging(); //makes the panel behave like a draggable widget
            Header!.EnableDragging(this); //makes the header of the panel draggable
        }

        public Widget? Caller { get; }

        public void NavigateForward(Widget widget)
        {
            widget.Location = this.Location;
            this.ParentForm.Controls.Add(widget);
            this.ParentForm.Controls.Remove(this);
        }

        public void SetNotice(string message)
        {
            MainForm.Form.TopNotice.Text = message;
        }

        public bool TryNavigateBack()
        {
            if (Caller is null) return false;

            Caller.Location = this.Location;
            this.ParentForm.Controls.Add(Caller);
            this.ParentForm.Controls.Remove(this);
            return true;
        }

        private void InitializeComponent()
        {
            Header = new Label();
            BackButton = new ImageButton();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Anchor = AnchorStyles.Top;
            Header.BackColor = Color.Transparent;
            Header.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(50, 0);
            Header.Margin = new Padding(0);
            Header.Name = "Header";
            Header.Size = new Size(90, 40);
            Header.TabIndex = 1;
            Header.Text = "{header}";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Image = Properties.Images.back_arrow_32;
            BackButton.Location = new Point(1, 1);
            BackButton.MouseOverImage = Properties.Images.back_arrow_light_32;
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(46, 40);
            BackButton.TabIndex = 999;
            BackButton.UseVisualStyleBackColor = false;
            // 
            // Widget
            // 
            Controls.Add(BackButton);
            Controls.Add(Header);
            Name = "Widget";
            Size = new Size(245, 150);
            ResumeLayout(false);
        }

        private void UpdateWidgetLayout(string headerText)
        {
            if (Header.Text != headerText || Header.Width != this.Width - 100)
            {
                Header.Text = headerText;
                Header.BackColor = Color.White;
                Header.TextAlign = ContentAlignment.MiddleCenter;
                Header.Left = 50;
                Header.Width = this.Width - 100; //ensures that the header is always 100px less wide than the widget

                if (Caller == null)
                {
                    BackButton.Visible = false;
                }
                else
                {
                    BackButton.Visible = true;
                }
            }
        }
    }
}