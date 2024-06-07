using PowerAutomation.Controls;
using PowerAutomation.Models;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class ProcedureTypeSelectorWidget : Widget //TODO: consider making an ISelectWidget
    {
        public ProcedureTypeSelectorWidget(Action<Type> selectedProcedureTypeCallback) : base("Select Procedure Type")
        {
            Callback = selectedProcedureTypeCallback;
            InitializeComponent();
        }

        public Action<Type> Callback { get; }

        private void ActionProcedureButton_Click(object sender, EventArgs e)
        {
            Callback.Invoke(typeof(Action));
            NavigateBackward();
        }

        private void CompositeProcedureButton_Click(object sender, EventArgs e)
        {
            Callback.Invoke(typeof(Procedure));
            NavigateBackward();
        }
    }
}