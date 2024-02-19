using PowerAutomation.Controls;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class ProcedureTypeSelectorWidget : Widget
    {
        public ProcedureTypeSelectorWidget(Widget caller, Action<Type> selectedProcedureTypeCallback) : base("Select Procedure Type", caller)
        {
            Callback = selectedProcedureTypeCallback;
            InitializeComponent();
        }

        public Action<Type> Callback { get; }

        private void ActionProcedureButton_Click(object sender, EventArgs e)
        {
            Callback.Invoke(typeof(Action));
            TryNavigateBackward();
        }

        private void CompositeProcedureButton_Click(object sender, EventArgs e)
        {
            Callback.Invoke(typeof(Procedure));
            TryNavigateBackward();
        }
    }
}