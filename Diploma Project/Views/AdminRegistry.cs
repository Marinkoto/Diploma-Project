using System;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class AdminRegistry : UserControl
    {
        private DatabaseHelper db;
        public AdminRegistry()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!DesignMode)
            {
                db = new DatabaseHelper();

                string query = "SELECT NameOfUser, Password, Role FROM Users";

                dataGridView1.DataSource = db.ExecuteQuery(query);
            }
        }
        private void AdminRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
