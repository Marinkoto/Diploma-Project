using Diploma_Project.DatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class MyGames : Market
    {
        public MyGames()
        {
            InitializeComponent();
            Filters.Visible = false;
            Panel.FlowDirection = FlowDirection.TopDown;
            Panel.Padding = new Padding(0, 35, 0, 0);
            Panel.WrapContents = true;
            Panel.AutoScroll = true;
        }

        private void MyGames_Load(object sender, EventArgs e)
        {
            
        }

        public override void LoadMarketItems(string itemType)
        {
            RemoveAllItems();

            DataTable dt = productsTableAdapter.GetData();

            var purchasedGames = purchasesTableAdapter.GetData(SignIn.UserID)
                .AsEnumerable()
                .Select(row => row.Field<int>("ProductID"))
                .ToHashSet();

            foreach (DataRow dr in dt.Rows)
            {
                int gameId = Convert.ToInt32(dr["ID"]);

                if (purchasedGames.Contains(gameId))
                {
                    Product product = new Product
                    {
                        Title = dr["ProductName"].ToString(),
                        Price = "",
                        Description = dr["Description"].ToString(),
                    };
                    product.PurhcaseButton.Hide();
                    LoadImageForProduct(product);
                    AddItem(product);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
