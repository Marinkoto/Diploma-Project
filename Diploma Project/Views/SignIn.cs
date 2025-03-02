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

namespace Diploma_Project.Views
{
    public partial class SignIn : UserControl
    {
        public AdminEntry AdminEntry { get; set; }
        public event EventHandler SignInCompleted;
        private DatabaseHelper db;

        public string NameOfUser { get; set; }
        public string Password{ get; set; }
        public string Role { get; set; }
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnReviewPassword_Click(object sender, EventArgs e)
        {
            ButtonUtils.ReviewPasswordButton(txtBoxPassword);
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string query = "SELECT NameOfUser,Password,Role FROM Users WHERE NameOfUser = ? AND Password = ?";

            OleDbParameter[] parameters =
            {
                new OleDbParameter("NameOfUser",txtBoxUserName.Text),
                new OleDbParameter("Password",txtBoxPassword.Text)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                Role = dt.Rows[0]["Role"].ToString();
                if (Role == "Admin")
                {
                    AdminEntry adminEntry = new AdminEntry();
                    adminEntry.Show();
                }
                if (Role == "User")
                {
                    SignInCompleted?.Invoke(this, new EventArgs());
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!DesignMode)
            {
                db = new DatabaseHelper();
            }
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
        }
    }
}
