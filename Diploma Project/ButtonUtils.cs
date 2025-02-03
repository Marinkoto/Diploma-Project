using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public static class ButtonUtils
    {
        public static void ReviewPasswordButton(TextBox textBox)
        {
            textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar;
        }
        public static void ManagePanel(GroupBox box,bool state)
        {
            box.Visible = state;
        }
    }
}
