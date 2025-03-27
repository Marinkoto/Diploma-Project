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
    public partial class AdminQueue : UserControl
    {
        public AdminQueue()
        {
            InitializeComponent();

            dateTimePicker.MinDate = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AdminQueue_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;

            DataTable odt = ordersTableAdapter.GetData();

            var filter1 = odt.AsEnumerable()
                            .Where(order => Convert.ToBoolean(order["Completed"]) == false);

            if (filter1.Any())
                dataGridView1.DataSource = filter1.CopyToDataTable();
            else
                dataGridView1.DataSource = null;

            var filter2 = odt.AsEnumerable()
                            .Where(order => Convert.ToBoolean(order["Completed"]) == true);

            if (filter2.Any())
                dataGridView2.DataSource = filter2.CopyToDataTable();
            else
                dataGridView2.DataSource = null;

            DataTable udt = usersTableAdapter.GetData();

            foreach (DataRow dr in udt.Rows)
            {
                cmbBoxUser.Items.Add(dr["NameOfUser"]);
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnАdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                ordersTableAdapter.Insert(cmbBoxUser.SelectedItem.ToString(),
                price, cmbBoxService.SelectedItem.ToString(),
                DateTime.Now, dateTimePicker.Value, false);
                MessageBox.Show($"Успешно добавихте нов запис!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
            var filter = databaseDataSet.Orders.AsEnumerable()
                .Where(order => order.Field<bool>("Completed") == false);

            if (filter.Any())
            {
                dataGridView1.DataSource = filter.CopyToDataTable();
            }
            else
            {
                dataGridView1.DataSource = null; 
            }

            dataGridView1.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
            int idToDelete = (int)numericUpDownId.Value;

            bool idExists = databaseDataSet.Orders.AsEnumerable()
                .Any(order => order.Field<int>("ID") == idToDelete);
            if(!idExists)
            {
                MessageBox.Show($"Няма намерана заявка с ИД {numericUpDownId.Value}!",
                    "Предупреждение",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show($"Сигурни ли сте че искате да изтриете запис с ИД {numericUpDownId.Value}?" +
                $"\nТова действие е необратимо!",
                "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ordersTableAdapter.DeleteById((int)numericUpDownId.Value);

                this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
                var filter1 = databaseDataSet.Orders.AsEnumerable()
                    .Where(order => order.Field<bool>("Completed") == false);

                if(filter1.Any())
                {
                    dataGridView1.DataSource = filter1.CopyToDataTable();
                }
                dataGridView1.Refresh();

                var filter2 = databaseDataSet.Orders.AsEnumerable()
                   .Where(order => order.Field<bool>("Completed") == true);

                if (filter2.Any())
                {
                    dataGridView1.DataSource = filter2.CopyToDataTable();
                }
                dataGridView2.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Fill(this.databaseDataSet.Orders); 
                dataGridView1.Refresh();

                var filter2 = databaseDataSet.Orders.AsEnumerable()
                   .Where(order => order.Field<bool>("Completed") == true);

                if (filter2.Any())
                {
                    dataGridView1.DataSource = filter2.CopyToDataTable();
                }
                dataGridView2.Refresh();
                MessageBox.Show("Промените са запазени успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Грешка при запазване: ", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
