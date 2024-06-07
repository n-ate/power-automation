using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class CompositeProcedureEditorWidget : Widget, IEditWidget<Procedure>
    {
        public CompositeProcedureEditorWidget(Procedure model) : base("Composite Procedure")
        {
            Model = model;
            InitializeComponent();
        }

        public Procedure Model { get; }

        public void UpdateGuiFromModel()
        {
            throw new NotImplementedException();
        }

        public void UpdateModelFromGui()
        {
            throw new NotImplementedException();
        }
    }
}