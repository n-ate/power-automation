using PowerAutomation.Controls;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Properties;

namespace PowerAutomation.Widgets.Procedures
{
    public partial class ProceduresWidget : Widget, IViewWidget<Workspace>
    {
        public ProceduresWidget(Workspace model) : base("Procedures")
        {
            Model = model;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public Workspace Model { get; }

        public Type? ProcedureTypeToCreate { get; private set; }

        public override void OnNavigationArrivedBack(Widget source)
        {
            base.OnNavigationArrivedBack(source);
            TryCreateNewProcedure();
            UpdateGuiFromModel();
        }

        public void TryCreateNewProcedure()
        {
            if (ProcedureTypeToCreate is not null)
            {
                var procedure = Model.Procedures.FirstOrDefault(p => p.Key == "AutoSaved");
                Widget? widget = null;
                if (ProcedureTypeToCreate == typeof(SimulatedAction))
                {
                    SimulatedAction? action = null;
                    if (procedure is not null && procedure is SimulatedAction a) action = a;
                    else
                    {
                        action = new SimulatedAction();
                        Model.Procedures = Model.Procedures.Where(p => p.Key != "AutoSaved").Concat(new[] { action }).OrderBy(d => d.Key).ToArray();
                    }
                    widget = new ActionProcedureEditorWidget(action!);
                }
                else if (ProcedureTypeToCreate == typeof(Procedure))
                {
                    Procedure? composite = null;
                    if (procedure is not null && procedure is Procedure c) composite = c;
                    else
                    {
                        composite = new Procedure();
                        Model.Procedures = Model.Procedures.Where(p => p.Key != "AutoSaved").Concat(new[] { composite }).OrderBy(d => d.Key).ToArray();
                    }
                    widget = new CompositeProcedureEditorWidget(composite!);
                }
                else throw new NotImplementedException();
                ProcedureTypeToCreate = null; //erase chosen type..
                NavigateForward(widget);
            }
        }

        private void CreateProcedureButton_Click(object sender, EventArgs e)
        {
            var widget = new ProcedureTypeSelectorWidget(t => ProcedureTypeToCreate = t);
            NavigateForward(widget);
        }

        private void ProceduresListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var procedure = ProceduresListview.FocusedItem?.Tag as IProcedure;
            if (procedure is not null)
            {
                Widget? widget = null;
                if (procedure is SimulatedAction action)
                {
                    widget = new ActionProcedureEditorWidget(action);
                }
                else if (procedure is Procedure composite)
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
            foreach (var procedure in Model.Procedures.OrderBy(d => d.Title))
            {
                var item = new ListViewItem();
                item.Text = procedure.Title;
                item.Tag = procedure;
                item.Name = procedure.Key;
                ProceduresListview.Items.Add(item);
                if (procedure is Procedure composite)
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