using PowerAutomation.Controls.Interfaces;

namespace PowerAutomation.Controls
{
    public partial class Widget : UserControl
    {
        private ImageButton BackButton;
        private Label Header;

        [Obsolete("Used at design-time only.")]
        public Widget()
        {
            InitializeComponent();
            _ = this.Header!.Text; //reference to force compiler to recognize as set.
            _ = this.BackButton!.Text; //reference to force compiler to recognize as set.
        }

        public Widget(string headerText)
        {
            InitializeComponent();
            this.Header!.Text = headerText;

            this.BackButton!.Click += (s, e) => NavigateBackward();
            this.Resize += async (s, e) => await this.EnqueueUIChangeToRunAfterDelay(nameof(UpdateWidgetLayout), 180, c => UpdateWidgetLayout(headerText));

            this.EnableDragging(); //makes the panel behave like a draggable widget
            this.Header.EnableDragging(this); //makes the header of the panel draggable
        }

        public Widget Caller { get; protected set; } = NotInitialized;

        public void NavigateBackward()
        {
            var destination = Caller;
            ReplaceWidget(this, destination);
            destination.OnNavigationArrivedBack(this); // pseudo event
            if (destination is IViewControl d) d.UpdateGuiFromModel();
        }

        public void NavigateForward(Widget destination)
        {
            destination.Caller = this;
            ReplaceWidget(this, destination);
            destination.OnNavigationArrivedForward(this); // pseudo event
            if (destination is IViewControl d) d.UpdateGuiFromModel();
        }

        public void NavigateReplace(Widget destination)
        {
            destination.Caller = Caller;
            ReplaceWidget(this, destination);
            destination.OnNavigationArrivedForward(this); // pseudo event
            if (destination is IViewControl d) d.UpdateGuiFromModel();
        }

        public virtual void OnBeforeNavigation(Widget destination)
        {
        }

        //public void Open(Widget widget, int x, int y) //not sure about this one...
        //{
        //    OnBeforeNavigate(widget);
        //    widget.Left = x;
        //    widget.Top = y;
        //    Parent!.Controls.Add(widget);
        //    widget.BringToFront();
        //}

        public virtual void OnNavigationArrivedBack(Widget source)
        {
        }

        public virtual void OnNavigationArrivedForward(Widget source)
        {
        }

        private void InitializeComponent()
        {
            BackButton = new ImageButton();
            Header = new Label();
            SuspendLayout();
            //
            // BackButton
            //
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Image = Properties.Images.back_arrow_32;
            BackButton.Location = new Point(0, 0);
            BackButton.MouseOverImage = Properties.Images.back_arrow_light_32;
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(46, 40);
            BackButton.TabIndex = 999;
            BackButton.UseVisualStyleBackColor = false;
            //
            // Header
            //
            Header.BackColor = Color.Transparent;
            Header.Font = new Font("Tahoma", 14F);
            Header.Location = new Point(50, 0);
            Header.Margin = new Padding(0);
            Header.Name = "Header";
            Header.Size = new Size(80, 40);
            Header.TabIndex = 1;
            Header.Text = "{header}";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            //
            // Widget
            //
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BackButton);
            Controls.Add(Header);
            Name = "Widget";
            Size = new Size(180, 150);
            ResumeLayout(false);
        }

        private void ReplaceWidget(Widget current, Widget replacement)
        {
            if (current.Parent is null) throw new ArgumentException("Current widget must have a parent.", nameof(current));
            if (current == Widget.NotInitialized || replacement == Widget.NotInitialized) throw new InvalidOperationException("Widgets must be initialized.");

            replacement.Location = current.Location;
            current.OnBeforeNavigation(replacement); // pseudo event
            var zOrder = current.GetZOrder();
            if (replacement == Widget.ApplicationRoot)
            {
                current.Hide();
                //App.Minimize(); // if this is the last widget, minimize instead of hide.
            }
            else
            {
                current.Parent!.Controls.Add(replacement);
                current.Parent.Controls.Remove(current);
                replacement.SetZOrder(zOrder);
            }
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