using Diploma_Project.DatabaseDataSetTableAdapters;
using Diploma_Project.Presenters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Diploma_Project.Views
{
    public partial class SignIn : UserControl
    {
        public AdminEntry AdminEntry { get; set; }
        public static EventHandler SignInCompleted;

        public static bool SignedIn { get; set; }
        public static int UserID { get; set; }
        public static string NameOfUser { get; set; }

        public SignIn()
        {
            InitializeComponent();
            SignedIn = false;
        }

        private void btnReviewPassword_Click(object sender, EventArgs e)
        {
            ButtonUtils.ReviewPasswordButton(txtBoxPassword);
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable dt = usersTableAdapter.GetData();
            var userRow = dt.AsEnumerable()
                .FirstOrDefault(dr => dr["NameOfUser"].ToString().Equals(txtBoxUserName.Text) &&
                                      dr["Password"].ToString().Equals(txtBoxPassword.Text));
            if (userRow == null)
            {
                MessageBox.Show("Грешно въведено име или парола!",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (userRow["Role"].ToString() == "Admin")
            {
                AdminEntry = new AdminEntry();
                AdminEntry.Show();
            }
            else
            {
                NameOfUser = userRow["NameOfUser"].ToString();
                UserID = Convert.ToInt32(userRow["ID"]);
                SignInCompleted?.Invoke(this, new EventArgs());
            }
        }
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
