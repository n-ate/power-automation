using n_ate.Essentials;
using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Controls.Models;
using PowerAutomation.Models;

namespace PowerAutomation.Controls.Procedures
{
    public partial class ProcedureTypeSelectorWidget : Widget, ISelectControl<Type[], Type?>
    {
        public ProcedureTypeSelectorWidget(Type[] options, ValuePot<Type?> model) : base("Select Procedure Type")
        {
            Options = options;
            Model = model;
            InitializeComponent();
        }

        public ValuePot<Type?> Model { get; }

        public Type[] Options { get; }

        public void UpdateGuiFromModel()
        {
            var template = ProcedureTemplateButton;
            var spacingY = template.Height + Math.Max(template.Margin.Top, template.Margin.Bottom);
            var locationY = template.Location.Y - spacingY;
            foreach (var option in Options)
            {
                locationY += spacingY;
                var button = new Button
                {
                    Name = option.Name + "Button",
                    Text = option.Name.CamelCaseToFriendly(),
                    Tag = option,
                    Location = new Point { X = template.Location.X, Y = locationY },
                    Font = template.Font,
                    Margin = template.Margin,
                    Size = template.Size,
                    UseVisualStyleBackColor = template.UseVisualStyleBackColor
                };
                button.Click += ProcedureButton_Click;
                this.Controls.Add(button);
            }
            this.Height = locationY + spacingY;
            template.Hide();
        }

        public void UpdateModelFromGui()
        {
            //Nothing to do; handled in the button click events..
        }

        private void ProcedureButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Type type) 
            {
                Model.Value = type;
            }
            else throw new NotImplementedException();
            NavigateBackward();
        }
    }
}