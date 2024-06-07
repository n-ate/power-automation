using PowerAutomation.Controls;
using PowerAutomation.Extensions;
using PowerAutomation.Models.Detection;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Vanara.PInvoke;

namespace PowerAutomation.Widgets
{
    public partial class ImageToolsWidget : Widget
    {
        public ImageToolsWidget(HWND targetHandle, ImageDetection model) : base("Tools")
        {
            TargetHandle = targetHandle;
            Model = model;
            InitializeComponent();
            Load += ImageToolsWidget_Load;
        }

        private async void ImageToolsWidget_Load(object? sender, EventArgs e)
        {
            App.Hide();
            var capture = await WinOS.CaptureImage(TargetHandle);
            App.Show();
            PictureControl = App.AddImageWithMaskedBackground(capture);

            var response = await UserImageSelect(PictureControl);

            App.RemoveImageWithMaskedBackground();

            Model.Location.Top = response.Bounds.Top;
            Model.Location.Left = response.Bounds.Left;
            Model.Location.Height = response.Bounds.Height;
            Model.Location.Width = response.Bounds.Width;
            Model.MatchImage = response.Image;

            NavigateBackward();
        }

        public ImageDetection Model { get; }
        public HWND TargetHandle { get; }
        public Panel? PictureControl { get; private set; }

        private void RefreshImageButton_Click(object sender, EventArgs e)
        {
            //var selection = await UserImageSelect();
            //SelectedImage.Image = selection.Image;
            //SelectionLocation = new Bounds()
            //{
            //    Top = selection.Bounds.Top,
            //    Left = selection.Bounds.Left,
            //    Height = selection.Bounds.Height,
            //    Width = selection.Bounds.Width
            //};
            //LocationLabel.Text = $"top:{SelectionLocation.Top}, left:{SelectionLocation.Left}, h:{SelectionLocation.Height}, w:{SelectionLocation.Width}";
        }

        public static async Task<(Bitmap Image, Rectangle Bounds)> UserImageSelect(Panel control)
        {
            if (control.BackgroundImage is null || control.BackgroundImage is not Bitmap screen) throw new ArgumentException("Control must have a bitmap background image.", nameof(control));
            Bitmap? selection = null;
            Rectangle? bounds = null;
            var dragStart = Point.Empty;
            var dragCurrent = Point.Empty;


            //var screen = WinOS.CaptureImage(App.Form.Bounds);
            App.SetNotice("Click and drag to select area to match.");
            //App.Form.BackgroundImage = screen.AdjustSaturation(0.4f);
            control.BackgroundImage = screen.AdjustSaturation(0.4f);

            //App.Form.ExecuteOnUIThread(f => f.BackgroundImage = test);// Image.FromFile("C:\\_\\temp\\screen.png"));// screen);
            var selectionTool = new Panel()
            {
                AutoSize = false,
                Visible = false,
                BackColor = Color.Transparent
            };
            selectionTool.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.Red, 2f), 1, 1, selectionTool.Width - 2, selectionTool.Height - 2);
            };
            control.Controls.Add(selectionTool);
            selectionTool.BringToFront();
            
            //selectionTool.SetZOrder(0);

            control.MouseDown += StartImageSelection;
            control.MouseMove += ChangeImageSelection;
            control.MouseUp += FinishImageSelection;

            Rectangle GetSelectionBounds()
            {
                var x = Math.Min(dragStart.X, dragCurrent.X);
                var y = Math.Min(dragStart.Y, dragCurrent.Y);
                var w = Math.Max(dragStart.X, dragCurrent.X) - x;
                var h = Math.Max(dragStart.Y, dragCurrent.Y) - y;
                if (w == 0) w = 1;
                if (h == 0) h = 1;
                return new Rectangle() { X = x, Y = y, Width = w, Height = h };
            }
            void SetSelectionTool()
            {
                var bounds = GetSelectionBounds();
                selectionTool.Top = bounds.Y - 2;
                selectionTool.Left = bounds.X - 2;
                selectionTool.Height = bounds.Height + 4;
                selectionTool.Width = bounds.Width + 4;
                selectionTool.Invalidate();
            }
            void StartImageSelection(object? s, MouseEventArgs e)
            {
                App.SetNotice("");
                dragStart = dragCurrent = e.Location;
                SetSelectionTool();
                selectionTool.Show();
            };
            void ChangeImageSelection(object? s, MouseEventArgs e)
            {
                dragCurrent = e.Location;
                SetSelectionTool();
            };
            void FinishImageSelection(object? s, MouseEventArgs e)
            {
                //unbind event handlers//
                control.MouseDown -= StartImageSelection;
                control.MouseMove -= ChangeImageSelection;
                control.MouseUp -= FinishImageSelection;
                //get captured snippet//
                dragCurrent = e.Location;
                bounds = GetSelectionBounds();
                //selection = WinOS.CaptureImage(bounds.Value);
                selection = screen.Clone(bounds.Value, PixelFormat.Format32bppArgb);
                //remove capture specific elements//
                //screen?.Dispose();
                control.Controls.Remove(selectionTool);
                ////dispose of background image//
                //var image = App.Form.BackgroundImage;
                //App.Form.BackgroundImage = null;
                //image?.Dispose();
            };

            while (bounds is null || selection is null) await Task.Delay(50);

            App.SetNotice("");
            return (selection, bounds.Value);
        }
    }
}