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
    public partial class MainMenuWidget : UserControl
    {
        public MainMenuWidget()
        {
            InitializeComponent();

            this.EnableDragging(); //makes the panel behave like a draggable widget
            this.Header.EnableDragging(this); //makes the header of the panel draggable
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this.SwapWidgetWith(new CreateTaskWidget(this));
        }
    }
}
