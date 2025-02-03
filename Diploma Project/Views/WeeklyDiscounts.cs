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
        public override void LoadMarketItems()
        {
            for (int i = 1; i <= 5; i++)
            {
                var item = new Product
                {
                    Title = $"Discount {i}",
                    Description = "Very Special",
                    Price = $"${i * 10}",
                    ItemImage = Properties.Resources.About_us_Photo
                };


                item.BuyClicked += (s, e) =>
                {
                    var clickedItem = s as Product;
                    MessageBox.Show($"You bought {clickedItem.Title} for {clickedItem.Price}!");
                };

                AddItem(item);
            }
        }
        private void WeeklyDiscounts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
