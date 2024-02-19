using PowerAutomation.Controls;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class CompositeProcedureEditorWidget : Widget
    {
        public CompositeProcedureEditorWidget(Widget caller, Models.Procedure procedure) : base("Composite Procedure", caller)
        {
            InitializeComponent();
        }
    }
}