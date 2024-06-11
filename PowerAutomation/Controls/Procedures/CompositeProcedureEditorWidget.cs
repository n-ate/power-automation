using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Controls.Procedures
{
    public partial class CompositeProcedureEditorWidget : Widget, IEditControl<CompositeProcedure>
    {
        public CompositeProcedureEditorWidget(CompositeProcedure model) : base("Composite Procedure")
        {
            Model = model;
            InitializeComponent();
        }

        public CompositeProcedure Model { get; }

        public void UpdateGuiFromModel()
        {
            throw new NotImplementedException();
        }

        public void UpdateModelFromGui()
        {
            throw new NotImplementedException();
        }

        private string autoKey = string.Empty;

        private void TitleTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyTextbox.Text == autoKey) //user has not changed the key
            {
                autoKey = KeyTextbox.Text = TitleTextbox.Text.Replace(" ", "");
            }
        }
    }
}