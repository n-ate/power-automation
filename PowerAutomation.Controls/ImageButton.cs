using System.ComponentModel;

namespace PowerAutomation.Controls
{
    public class ImageButton : Button
    {
        private Image? prehoverImage = null;

        public ImageButton()
        {
            BackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            MouseEnter += MouseEntered;
            MouseLeave += MouseLeft;
        }

        [Category("Appearance")]
        public Image? MouseOverImage { get; set; }

        public void MouseEntered(object? sender, EventArgs e)
        {
            prehoverImage = this.Image;
            Image = MouseOverImage;
        }

        private void MouseLeft(object? sender, EventArgs e)
        {
            if (prehoverImage is not null) this.Image = prehoverImage;
        }
    }
}