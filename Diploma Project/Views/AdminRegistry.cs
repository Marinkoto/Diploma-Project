using System;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class AdminRegistry : UserControl
    {
        public AdminRegistry()
        {
            InitializeComponent();
            dataGridView1.DataSource = usersTableAdapter.GetData();
        }
        
        private void AdminRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
