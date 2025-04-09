using Diploma_Project.DatabaseDataSetTableAdapters;
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
    public partial class FreeGames : Market
    {
        public FreeGames()
        {
            InitializeComponent();
            Filters.Hide();
            AllFiltersBox.Hide();
            Panel.FlowDirection = FlowDirection.TopDown;
            Panel.Padding = new Padding(0, 35, 0, 0);
            Panel.WrapContents = true;
            Panel.AutoScroll = true;
        }

        private void FreeGames_Load(object sender, EventArgs e)
        {

        }
        public override void LoadMarketItems(string itemType)
        {
            RemoveAllItems();
            DataTable dt = productsTableAdapter.GetData();
            var filteredItems = dt.AsEnumerable().Where(dr => dr["ProductType"].Equals(itemType));

            foreach (DataRow dr in filteredItems)
            {
                int gameId = Convert.ToInt32(dr["ID"]);
                Product product = new Product
                {
                    Title = dr["ProductName"].ToString(),
                    Price = "0€",
                    Description = dr["Description"].ToString(),
                    BuyClicked = () => PurchaseGame(SignIn.UserID, gameId),
                };
                LoadImageForProduct(product);
                AddItem(product);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
