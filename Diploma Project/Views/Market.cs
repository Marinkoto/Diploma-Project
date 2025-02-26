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
    public partial class Market : UserControl
    {
        public FlowLayoutPanel Panel => itemHolder;
        public MenuStrip Filters => filterMenuStrip;
        public Market()
        {
            InitializeComponent();

            Panel.FlowDirection = FlowDirection.LeftToRight;
            Panel.WrapContents = true;
            Panel.AutoScroll = true;
            Panel.Padding = new Padding(0, 0, 0, 0);
            Filters.Visible = true;
        }
        public void AddItem(Control item)
        {
            Panel.Controls.Add(item);
        }
        public void RemoveAllItems()
        {
            Panel.Controls.Clear();
        }
        public virtual void LoadMarketItems()
        {
            for (int i = 1; i <= 20; i++)
            {
                var item = new Product
                {
                    Title = $"Game {i}",
                    Description = "A great game to play.",
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
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            //itemHolder.VerticalScroll.Value = vScrollBar.Value; 
            //itemHolder.Invalidate();
        }

        private void Market_Load(object sender, EventArgs e)
        {

        }
    }
}
