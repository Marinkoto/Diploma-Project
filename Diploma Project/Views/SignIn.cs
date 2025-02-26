using Diploma_Project.Presenters;
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
        public AdminEntry AdminEntry { get; set; }
        public event EventHandler SignInCompleted;
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnReviewPassword_Click(object sender, EventArgs e)
        {
            ButtonUtils.ReviewPasswordButton(txtBoxPassword);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBoxPassword.Text == "123" && txtBoxUserName.Text == "Admin")
            {
                AdminEntry = new AdminEntry();
                AdminEntry.Show();
            }
            if(txtBoxPassword.Text == "123" && txtBoxUserName.Text == "Marin")
            {
                SignInCompleted?.Invoke(sender,e);
            }
        }
    }
}
