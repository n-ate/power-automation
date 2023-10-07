using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerAutomation
{
    public partial class CreateTaskWidget : UserControl
    {
        public CreateTaskWidget()
        {
            InitializeComponent();

            this.EnableDragging(); //makes the panel behave like a draggable widget
            this.Header.EnableDragging(this); //makes the header of the panel draggable
        }

        private void CreateTaskWidget_Load(object sender, EventArgs e)
        {

        }

        private void imageButton1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
