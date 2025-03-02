using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Presenters
{
    public partial class AdminEntry : Form
    {
        public AdminEntry()
        {
            InitializeComponent();
        }

        private void AdminEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void AdminEntry_Load(object sender, EventArgs e)
        {
            
        }

        private void пазарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminMarket.Show();
            adminQueue.Hide();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminQueue.Show();
            adminMarket.Hide();
            adminRegistry.Hide();
        }

        private void потребителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminQueue.Hide();
            adminMarket.Hide();
            adminRegistry.Show();
        }
    }
}
