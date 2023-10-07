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
        [Category("Appearance")]
        public Image MouseOverImage { get; set; }

        public ImageButton()
        {
            BackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            //this.MouseEnter += this.MouseEnter;
        }
        

        public void MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
