using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerAutomation.Controls
{
    public class ImageButton : Button
    {
        private Image? prehoverImage = null;

        [Category("Appearance")]
        public Image MouseOverImage { get; set; }

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

        private void MouseLeft(object? sender, EventArgs e)
        {
            if(prehoverImage is not null) this.Image = prehoverImage;
        }

        public void MouseEntered(object? sender, EventArgs e)
        {
            prehoverImage = this.Image;
            Image = MouseOverImage;
        }

    }
}
