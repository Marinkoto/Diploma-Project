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
    public partial class NewReleases : Market
    {
        public NewReleases()
        {
            InitializeComponent();
            Filters.Hide();
            AllFiltersBox.Hide();
            Panel.FlowDirection = FlowDirection.RightToLeft;
            Panel.Padding = new Padding(0, 0, 45, 0);
            Panel.WrapContents = true;
            Panel.AutoScroll = true;
        }

        private void NewReleases_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
