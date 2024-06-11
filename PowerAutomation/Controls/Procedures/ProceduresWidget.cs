using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Controls.Models;
using PowerAutomation.Controls.Properties;
using PowerAutomation.Interfaces;
using PowerAutomation.Models;

namespace PowerAutomation.Controls.Procedures
{
    public partial class ProceduresWidget : Widget, IViewControl<ProcedureCollection>
    {
        public ProceduresWidget(DetectionCollection detectionOptions, ProcedureCollection model) : base("Procedures")
        {
            Model = model;
            DetectionOptions = detectionOptions;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public ProcedureCollection Model { get; }
        public DetectionCollection DetectionOptions { get; }
        public ValuePot<Type?> ProcedureTypeToCreate { get; private set; } = new ValuePot<Type?>(null);

        public override void OnNavigationArrivedBack(Widget source)
        {
            if (source is ProcedureTypeSelectorWidget)
            {
                TryCreateNewProcedure();
                //UpdateGuiFromModel();
            }
        }

        public void TryCreateNewProcedure()
        {
            if (ProcedureTypeToCreate.Value is not null)
            {
                var procedure = Model.FirstOrDefault(p => p.Key == "AutoSaved");
                Widget? widget = null;
                if (ProcedureTypeToCreate.Value == typeof(ActionProcedure))
                {
                    ActionProcedure? action = null;
                    if (procedure is not null && procedure is ActionProcedure a) action = a;
                    else
                    {
                        action = new ActionProcedure();
                        Model.Add(action);
                    }
                    widget = new ActionProcedureEditorWidget(DetectionOptions, action);
                }
                else if (ProcedureTypeToCreate.Value == typeof(CompositeProcedure))
                {
                    CompositeProcedure? composite = null;
                    if (procedure is not null && procedure is CompositeProcedure c) composite = c;
                    else
                    {
                        composite = new CompositeProcedure();
                        Model.Add(composite);
                    }
                    widget = new CompositeProcedureEditorWidget(composite);
                }
                else throw new NotImplementedException();
                ProcedureTypeToCreate.Value = null; //erase chosen type..
                NavigateForward(widget);
            }
        }

        private void CreateProcedureButton_Click(object sender, EventArgs e)
        {
            var options = new[] { typeof(ActionProcedure), typeof(CompositeProcedure) };
            var widget = new ProcedureTypeSelectorWidget(options, ProcedureTypeToCreate);
            NavigateForward(widget);
        }

        private void ProceduresListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var procedure = ProceduresListview.FocusedItem?.Tag as IProcedure;
            if (procedure is not null)
            {
                Widget? widget = null;
                if (procedure is ActionProcedure action)
                {
                    widget = new ActionProcedureEditorWidget(DetectionOptions, action);
                }
                else if (procedure is CompositeProcedure composite)
                {
                    widget = new CompositeProcedureEditorWidget(composite);
                }
                else throw new NotImplementedException();
                NavigateForward(widget);
            }
        }

        public void UpdateGuiFromModel()
        {
            ProceduresListview.Items.Clear();
            ProceduresListview.SmallImageList = new ImageList();
            ProceduresListview.SmallImageList.Images.Add("action", Images.action_32);
            ProceduresListview.SmallImageList.Images.Add("composite", Images.composite_32);
            foreach (var procedure in Model)
            {
                var item = new ListViewItem();
                item.Text = procedure.Title;
                item.Tag = procedure;
                item.Name = procedure.Key;
                ProceduresListview.Items.Add(item);
                if (procedure is CompositeProcedure composite)
                {
                    item.ImageKey = "composite";
                    item.SubItems.Add(string.Join(", ", composite.Procedures.Select(p => p.Title)));
                }
                else
                {
                    item.ImageKey = "action";
                    item.SubItems.Add("simulated action");
                }
            }
        }
    }
}