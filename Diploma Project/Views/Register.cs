using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnReviewPassword_Click(object sender, EventArgs e)
        {
            ButtonUtils.ReviewPasswordButton(txtBoxPassword);
        }

        private void btnReviewRepeatPassword_Click(object sender, EventArgs e)
        {
            ButtonUtils.ReviewPasswordButton(txtBoxRepeatPassword);
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text != txtBoxRepeatPassword.Text)
            {
                MessageBox.Show("Паролите не съвпадат!",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxUserName.Text))
            {
                MessageBox.Show("Въведено е неподходящо име!",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dt = usersTableAdapter.GetData();
            var existingUser = dt.AsEnumerable()
                .FirstOrDefault(dr => dr["NameOfUser"].ToString().Equals(txtBoxUserName.Text));
            if (existingUser != null)
            {
                MessageBox.Show("Потребител с въведеното потребителско име вече съществува!",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SignIn.NameOfUser = txtBoxUserName.Text;
            usersTableAdapter.Insert(txtBoxUserName.Text, txtBoxPassword.Text, "User", 0);
            SignIn.UserID = Convert.ToInt32(usersTableAdapter.GetLastInsertedId());
            SignIn.SignInCompleted?.Invoke(sender, e);
        }
    }
}
