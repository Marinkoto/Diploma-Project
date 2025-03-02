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
        public DatabaseHelper db;
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
            db = new DatabaseHelper();
            string query = "SELECT * FROM Products WHERE ProductType = ?";
            OleDbParameter param = new OleDbParameter("ProductType", OleDbType.VarChar)
            { 
                Value =  itemType
            };

            DataTable dt = db.ExecuteQuery(query, param);

            foreach (DataRow dr in dt.Rows)
            {
                Product product = new Product
                {
                    Title = dr["ProductName"].ToString(),
                    Price = $"{dr["Price"]}€",
                    Description = dr["Description"].ToString(),
                };
                LoadImageForProduct(product);
                AddItem(product);
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
            string query = "SELECT * FROM Products WHERE Genre = ?";
            OleDbParameter param = new OleDbParameter("Genre", OleDbType.VarChar)
            {
                Value = genre
            };

            DataTable dt = db.ExecuteQuery(query, param);

            foreach (DataRow dr in dt.Rows)
            {
                Product product = new Product
                {
                    Title = dr["ProductName"].ToString(),
                    Price = $"{dr["Price"]}€",
                    Description = dr["Description"].ToString()
                };
                LoadImageForProduct(product);
                AddItem(product);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                DialogResult result = MessageBox.Show("Сигурни ли сте че искате да премахнете избрания от вас филтър?",
                    "Информация",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if(result == DialogResult.OK)
                {
                    RemoveAllItems();
                    LoadMarketItems("Game");
                    checkBox.Checked = false;
                }
            }
        }
        private void LoadImageForProduct(Product product)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            product.ItemImage = Image.FromFile($@"{baseDirectory}Games\{product.Title}.jpg");
        }
    }
}
