using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
                    Description = dr["Description"].ToString()
                };
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
    }
}
