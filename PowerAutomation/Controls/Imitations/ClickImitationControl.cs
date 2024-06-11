using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models.Imitation;

namespace PowerAutomation.Controls.Imitations
{
    public partial class ClickImitationControl : UserControl, IEditControl<ClickImitation>
    {
        public ClickImitationControl(ClickImitation model)
        {
            Model = model;
            InitializeComponent();
            //XOffsetTextbox.Mask = "-00";
            //YOffsetTextbox.Mask = "-00";
        }

        public ClickImitation Model { get; }

        public void UpdateGuiFromModel()
        {
            switch (Model.Type)
            {
                case ClickType.DoubleClick:
                    DoubleClickRadio.Checked = true;
                    break;
                case ClickType.LeftClick:
                    LeftClickRadio.Checked = true;
                    break;
                default: throw new NotImplementedException();
            }

            XOffsetTextbox.Text = Model.XOffset.ToString();

            YOffsetTextbox.Text = Model.YOffset.ToString();
        }

        public void UpdateModelFromGui()
        {
            if (LeftClickRadio.Checked) Model.Type = ClickType.LeftClick;
            else if (DoubleClickRadio.Checked) Model.Type = ClickType.DoubleClick;
            else throw new NotImplementedException();

            if (int.TryParse(XOffsetTextbox.Text, out var x)) Model.XOffset = x;
            else throw new ArgumentException();

            if (int.TryParse(YOffsetTextbox.Text, out var y)) Model.YOffset = y;
            else throw new ArgumentException();
        }
    }
}