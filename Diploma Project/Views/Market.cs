using Diploma_Project.DatabaseDataSetTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
        public CheckBox AllFiltersBox => checkBox;

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
        public virtual void LoadMarketItems(string itemType)
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
                    Price = $"{dr["Price"]}€",
                    Description = dr["Description"].ToString(),
                    BuyClicked = () => PurchaseGame(SignIn.UserID, gameId),
                };
                LoadImageForProduct(product);
                AddItem(product);
            }
        }
        public virtual void PurchaseGame(int userId, int gameId)
        {
            var existingPurchase = purchasesTableAdapter.GetData(userId)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ProductID") == gameId);
            if (!SignIn.SignedIn)
            {
                MessageBox.Show("Влезте в профила си!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (existingPurchase != null)
            {
                MessageBox.Show("Играта е закупена вече!\n" +
                    "Намерете я в Профил -> Моите игри", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataRow newRow = purchasesTableAdapter.GetData(userId).NewRow();
            newRow["UserID"] = userId;
            newRow["ProductID"] = gameId;

            purchasesTableAdapter.Insert(userId, gameId);
            MessageBox.Show($"Успешно закупихте играта!\n" +
                "Намерете я в Профил -> Моите игри", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            purchasesTableAdapter.Update(newRow);
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Market_Load(object sender, EventArgs e)
        {

        }

        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(multiplayerToolStripMenuItem.Text);
        }

        private void platformertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(platformertoolStripMenuItem.Text);
        }

        private void simulationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(simulationtoolStripMenuItem.Text);
        }

        private void survivaltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(survivaltoolStripMenuItem.Text);
        }

        private void adventuretoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(adventuretoolStripMenuItem.Text);
        }

        private void roguelikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(roguelikeToolStripMenuItem.Text);
        }

        private void puzzleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(puzzleToolStripMenuItem1.Text);
        }

        private void actionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGamesByGenre(actionToolStripMenuItem.Text);
        }
        private void LoadGamesByGenre(string genre)
        {
            RemoveAllItems();
            DataTable dt = productsTableAdapter.GetData();

            var filteredRows = dt.AsEnumerable()
                .Where(dr => dr["Genre"].ToString().Equals(genre) 
                && dr["ProductType"].ToString().Equals("Игра")).ToList();

            foreach (DataRow dr in filteredRows)
            {
                int gameId = Convert.ToInt32(dr["ID"]);
                Product product = new Product
                {
                    Title = dr["ProductName"].ToString(),
                    Price = $"{dr["Price"]}€",
                    Description = dr["Description"].ToString(),
                    BuyClicked = () => PurchaseGame(SignIn.UserID,gameId)
                };
                LoadImageForProduct(product);
                AddItem(product);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                DialogResult result = MessageBox.Show("Сигурни ли сте че искате да премахнете избрания от вас филтър?",
                    "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    RemoveAllItems();
                    LoadMarketItems("Игра");
                    checkBox.Checked = false;
                }
            }
        }
        public void LoadImageForProduct(Product product)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            product.ItemImage = Image.FromFile($@"{baseDirectory}Games\{product.Title}.jpg");
        }
    }
}
