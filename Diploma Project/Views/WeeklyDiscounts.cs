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
    public partial class WeeklyDiscounts : Market
    {
        public WeeklyDiscounts()
        {
            InitializeComponent();
            
            Panel.FlowDirection = FlowDirection.TopDown;
            Panel.Padding = new Padding(0, 35, 0, 0);
            Panel.WrapContents = true;
            Panel.AutoScroll = true;
            Filters.Visible = false;
        }
        public override void LoadMarketItems(string itemType)
        {
            base.LoadMarketItems(itemType);
        }
        private void WeeklyDiscounts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
