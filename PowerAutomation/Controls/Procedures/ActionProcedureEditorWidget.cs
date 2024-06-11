using PowerAutomation.Controls.Detections;
using PowerAutomation.Controls.Extensions;
using PowerAutomation.Controls.Imitations;
using PowerAutomation.Controls.Interfaces;
using PowerAutomation.Controls.Models;
using PowerAutomation.Interfaces;
using PowerAutomation.Models;
using PowerAutomation.Models.Detection;
using PowerAutomation.Models.Imitation;

namespace PowerAutomation.Controls.Procedures
{
    public partial class ActionProcedureEditorWidget : Widget, IEditControl<ActionProcedure>
    {
        public const string DYNAMIC_ACTION_CONTROL_TAG = "Simulated Action";

        private string autoKey = string.Empty;

        public ActionProcedureEditorWidget(DetectionCollection detectionOptions, ActionProcedure model) : base("Action Setup")
        {
            DetectionOptions = detectionOptions;
            Model = model;
            InitializeComponent();
            UpdateGuiFromModel();
        }

        public DetectionCollection DetectionOptions { get; }
        public ValuePot<Type?> ImitationType { get; } = new ValuePot<Type?>(null);
        public ActionProcedure Model { get; }
        public ValuePot<IDetection?> Postcondition { get; } = new ValuePot<IDetection?>(null);
        public ValuePot<IDetection?> Precondition { get; } = new ValuePot<IDetection?>(null);

        public override void OnBeforeNavigation(Widget destination)
        {
            base.OnBeforeNavigation(destination);
            UpdateModelFromGui(); //may not need..
            App.SaveCurrentState();
        }

        public override void OnNavigationArrivedBack(Widget source)
        {
            var t = ImitationType.Value;
            if (source is ImitationTypeSelectorWidget imitationTypeSelector)
            {
                if (Model.Action?.GetType() != imitationTypeSelector.Model.Value)
                {
                    Model.Action = (IImitation)Activator.CreateInstance(imitationTypeSelector.Model.Value);
                }
            }
            else if (source is DetectionSelectorWidget detectionSelector)
            {
                Model.Precondition = Precondition.Value;
                Model.Postcondition = Postcondition.Value;
            }
            //UpdateGuiFromModel(); //model may have changed while away
        }

        public void UpdateGuiFromModel()
        {
            TitleTextbox.Text = Model.Title;
            KeyTextbox.Text = Model.Key;
            DescriptionTextbox.Text = Model.Description;

            Precondition.Value = Model.Precondition;
            if (Precondition.Value is ImageDetection imagePrecondition)
            {
                PreconditionImage.Image = imagePrecondition.MatchImage.GetResizedImage(PreconditionImage.Width, PreconditionImage.Height);
                //TODO: display other detection info in group box
            }
            else if (Precondition.Value is not null) throw new NotImplementedException();

            Postcondition.Value = Model.Postcondition;
            if (Postcondition.Value is ImageDetection imagePostcondition)
            {
                PostconditionImage.Image = imagePostcondition.MatchImage.GetResizedImage(PostconditionImage.Width, PostconditionImage.Height);
                //TODO: display other detection info in group box
            }
            else if (Postcondition.Value is not null) throw new NotImplementedException();

            ImitationType.Value = Model.Action is null ? null : Model.Action.GetType();
            if (Model.Action is null)
            {
                SimulatedActionGroupbox.Show();
                var toRemove = new List<Control>();
                foreach (Control control in SimulatedActionGroupbox.Parent!.Controls)
                {
                    if (control.Tag is not null && control.Tag as string == DYNAMIC_ACTION_CONTROL_TAG) toRemove.Add(control);
                }
                foreach (var control in toRemove)
                {
                    SimulatedActionGroupbox.Parent.Controls.Remove(control);
                }
            }
            else if (Model.Action is ClickImitation clickAction)
            {
                var control = new ClickImitationControl(clickAction);
                control.Location = SimulatedActionGroupbox.Location;
                control.Tag = DYNAMIC_ACTION_CONTROL_TAG;
                SimulatedActionGroupbox.Parent!.Controls.Add(control);
                SimulatedActionGroupbox.Hide();
            }
            else throw new NotImplementedException();
        }

        public void UpdateModelFromGui()
        {
            Model.Title = TitleTextbox.Text;
            Model.Key = KeyTextbox.Text;
            Model.Description = DescriptionTextbox.Text;
            Model.Precondition = Precondition.Value;
            Model.Postcondition = Postcondition.Value;

            if (ImitationType.Value is null)
            {
                Model.Action = null;
            }
            else if (ImitationType.Value == typeof(ClickImitation))
            {
                var control = Controls.First<ClickImitationControl>();
                Model.Action = control.Model;
            }
            else throw new NotImplementedException();
        }

        //private bool IsNewImitationTypeSelected()
        //{
        //    if (ImitationType.Value is not null) //when a new imitation type is selected, this value will be set to the type
        //    {
        //        if (Model.Action is null || Model.Action.GetType() != ImitationType.Value) return true; //if type was just selected the Model.Action will not match
        //    }
        //    return false;
        //}

        private void SelectActionTypeButton_Click(object sender, EventArgs e)
        {
            var widget = new ImitationTypeSelectorWidget([typeof(ClickImitation), typeof(KeyImitation), typeof(TypingImitation)], ImitationType);
            NavigateForward(widget);
        }

        private void SelectPostconditionDetectionButton_Click(object sender, EventArgs e)
        {
            var widget = new DetectionSelectorWidget(DetectionOptions, Postcondition);
            NavigateForward(widget);
        }

        private void SelectPreconditionDetectionButton_Click(object sender, EventArgs e)
        {
            var widget = new DetectionSelectorWidget(DetectionOptions, Precondition);
            NavigateForward(widget);
        }

        private void TitleTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyTextbox.Text == autoKey) //user has not changed the key
            {
                autoKey = KeyTextbox.Text = TitleTextbox.Text.Replace(" ", "");
            }
        }
    }
}