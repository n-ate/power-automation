using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerAutomation
{
    public static class ControlExtensions
    {
        public static bool IsChildOf(this Control child, Control parent)
        {
            while (child.Parent is not null)
            {
                if (child.Parent == parent) return true;
                else child = child.Parent;
            }
            return false;
        }
        public static bool IsParentOf(this Control parent, Control child)
        {
            return child.IsChildOf(parent);
        }

        public static void SwapWidgetWith(this UserControl value, UserControl widget)
        {
            widget.Location = value.Location;
            value.ParentForm.Controls.Add(widget);
            value.ParentForm.Controls.Remove(value);
        }
    }
}
