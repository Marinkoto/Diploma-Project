using Diploma_Project.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Diploma_Project.Presenters
{
    public partial class Checkout : Form
    {
        public int FinalCostOfCustomer { get; set; }
        public Checkout()
        {
            InitializeComponent();
        }

        private void checkBoxClear1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxCheckOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.DeleteById((int)listBoxCheckOut.SelectedValue);
            ordersTableAdapter.Update(ordersTableAdapter.GetDataByName(SignIn.NameOfUser));
            LoadListBox();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изпратихте успешно поръчката!", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            usersTableAdapter.UpdateFinalCost(FinalCostOfCustomer,SignIn.NameOfUser);
            FinalCostOfCustomer = 0;
            this.Close();
        }
        private void LoadListBox()
        {
            DataTable dt = ordersTableAdapter.GetDataByName(SignIn.NameOfUser);
            dt.Columns.Add("DisplayText", typeof(string));
            var filteredOrders = dt.AsEnumerable()
                .Where(order => !Convert.ToBoolean(order["Completed"]) && Convert.ToDateTime(order["StartDate"]) >= DateTime.Now.AddSeconds(-30));
            
            foreach (DataRow order in filteredOrders)
            {
                string displayText = $"{order["Cost"]}€ {order["TypeOfService"]} Дата на поръчка: {order["StartDate"]}";
                FinalCostOfCustomer += Convert.ToInt32(order["Cost"]);
                order["DisplayText"] = displayText;
            }

            lblLastPrice.Text = $"Крайна цена с ДДС {FinalCostOfCustomer}€";
            listBoxCheckOut.DataSource = filteredOrders.AsDataView();
            listBoxCheckOut.ValueMember = "ID";
            listBoxCheckOut.DisplayMember = "DisplayText";
        }
    }
}
