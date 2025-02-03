using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnReviewPassword_Click(object sender, EventArgs e)
        {
            ButtonUtils.ReviewPasswordButton(txtBoxPassword);
        }
    }
}
