using System;
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
    public partial class Services : UserControl
    {
        public Services()
        {
            InitializeComponent();

            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtDescription.ForeColor = Color.Black;
        }

        private void txtBoxInfo_Enter(object sender, EventArgs e)
        {
            txtBoxInfo.Text = "";
            txtBoxInfo.ForeColor = Color.Black;
        }

        private void txtBoxNeeds_Enter(object sender, EventArgs e)
        {
            txtBoxNeeds.Text = "";
            txtBoxNeeds.ForeColor = Color.Black;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                txtDescription.Text = "Попълни желанията си";
                txtDescription.ForeColor = Color.Gray;
            }
        }

        private void txtBoxInfo_Leave(object sender, EventArgs e)
        {
            if (txtBoxInfo.Text == "")
            {
                txtBoxInfo.Text = "Напиши ни защо да работим с теб";
                txtBoxInfo.ForeColor = Color.Gray;
            }
        }

        private void txtBoxNeeds_Leave(object sender, EventArgs e)
        {
            if (txtBoxNeeds.Text == "")
            {
                txtBoxNeeds.Text = "Напиши ни твоите изисквания";
                txtBoxNeeds.ForeColor = Color.Gray;
            }
        }

        private void checkBoxClear3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClear3.Checked)
            {
                txtBoxInfo.Clear();
                txtBoxNeeds.Clear();
            }
        }

        private void checkBoxClear2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClear2.Checked)
            {
                txtDescription.Clear();
            }
        }

        private void checkBoxClear1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClear1.Checked)
            {
                dateTimePicker.ResetText();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            if (!SignIn.SignedIn)
            {
                MessageBox.Show("Влезте в профила си!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Поръчката е добавена в Профил -> Количка!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ordersTableAdapter.Insert(SignIn.NameOfUser, 10, "Консултация", DateTime.Now, dateTimePicker.Value, false);
            ordersTableAdapter.Update(ordersTableAdapter.GetData());
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (!SignIn.SignedIn)
            {
                MessageBox.Show("Влезте в профила си!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Поръчката е добавена в Профил -> Количка!", "Информация",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            ordersTableAdapter.Insert(SignIn.NameOfUser, 50, $"Начало на игра ({cBoxType.SelectedItem})", DateTime.Now, DateTime.Now.AddDays(14), false);
            ordersTableAdapter.Update(ordersTableAdapter.GetData());
        }

        private void btnSend3_Click(object sender, EventArgs e)
        {
            if (!SignIn.SignedIn)
            {
                MessageBox.Show("Влезте в профила си!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Поръчката е добавена в Профил -> Количка!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ordersTableAdapter.Insert(SignIn.NameOfUser, 250, $"Промотиране на игра", DateTime.Now, dateTimePicker1.Value, false);
            ordersTableAdapter.Update(ordersTableAdapter.GetData());
        }
    }
}
