using PowerAutomation.Controls;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class ActionProcedureEditorWidget : Widget
    {
        public ActionProcedureEditorWidget(Widget caller, Models.SimulatedAction action) : base("Action Procedure", caller)
        {
            InitializeComponent();
        }
    }
}