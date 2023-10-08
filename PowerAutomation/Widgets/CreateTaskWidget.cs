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
        private UserControl callingWidget;

        public CreateTaskWidget(UserControl callingWidget)
        {
            this.callingWidget = callingWidget;

            InitializeComponent();

            this.EnableDragging(); //makes the panel behave like a draggable widget
            this.Header.EnableDragging(this); //makes the header of the panel draggable
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.SwapWidgetWith(callingWidget);
        }
    }
}
