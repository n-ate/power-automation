using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class ActionProcedureEditorWidget : Widget, IEditWidget<SimulatedAction>
    {
        public ActionProcedureEditorWidget(SimulatedAction model) : base("Action Procedure")
        {
            Model = model;
            InitializeComponent();
        }

        public SimulatedAction Model { get; }

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