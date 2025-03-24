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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://margata.itch.io/potomania");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://margata.itch.io/phrase-fighters");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://margata.itch.io/the-kift");
        }

        private void MyGames_Load(object sender, EventArgs e)
        {
            LoadMarketItems("Game");
        }
        public override void LoadMarketItems(string itemType)
        {
            RemoveAllItems();

            var dt = productsTableAdapter.GetData()
                .AsEnumerable()
                .Where(dr => dr["ProductType"].ToString().Equals(itemType))
                .ToList();

            var purchasedGames = purchasesTableAdapter.GetData(SignIn.UserID)
                .AsEnumerable()
                .Select(row => row.Field<int>("ProductID"))
                .ToHashSet(); 

            foreach (DataRow dr in dt)
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

        public bool HasUserPurchasedGame(int userId, int gameId)
        {
            var purchases = purchasesTableAdapter.GetData(userId);

            return purchases.AsEnumerable().Any(row => row.Field<int>("ProductID") == gameId);
        }
    }
}
