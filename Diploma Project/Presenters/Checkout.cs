using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Presenters
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void checkBoxClear1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxClear1.Checked)
            {
                listBoxCheckOut.Items.Clear();
            }
        }
    }
}
