using Diploma_Project.DatabaseDataSetTableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class AdminRegistry : UserControl
    {
        public AdminRegistry()
        {
            InitializeComponent();
        }
        
        private void AdminRegistry_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
            {
                return;
            }
            dataGridView1.DataSource = usersTableAdapter.GetData();
            cmbBoxRole.SelectedIndex = 0;
        }

        private void btnАdd_Click(object sender, EventArgs e)
        {
            Guid passwordLong = Guid.NewGuid();
            string shortPassword = passwordLong.ToString("N").Substring(0, 8);
            usersTableAdapter.Insert(txtUserName.Text, shortPassword, cmbBoxRole.SelectedItem.ToString(), 0);
            dataGridView1.DataSource = usersTableAdapter.GetData();
            MessageBox.Show($"Успешно добавихте нов запис!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            int idToDelete = (int)numericUpDownId.Value;

            bool idExists = databaseDataSet.Users.AsEnumerable()
                .Any(user => user.Field<int>("ID") == idToDelete);

            if (!idExists)
            {
                MessageBox.Show($"Няма намерен потребител с ИД {numericUpDownId.Value}!",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show($"Сигурни ли сте че искате да изтриете запис с ИД {numericUpDownId.Value}?" +
                $"\nТова действие е необратимо!",
                "Предупреждение", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes)
            {
                usersTableAdapter.DeleteById((int)numericUpDownId.Value);

                this.usersTableAdapter.Fill(this.databaseDataSet.Users);
                dataGridView1.DataSource = usersTableAdapter.GetData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usersTableAdapter.GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                databaseDataSet.Users.Merge((DataTable)dataGridView1.DataSource);
                DataTable changes = databaseDataSet.Users.GetChanges();

                if (changes != null)
                {
                    this.usersTableAdapter.Update(databaseDataSet.Users);

                    databaseDataSet.Users.AcceptChanges();
                }

                this.usersTableAdapter.Fill(this.databaseDataSet.Users);
                dataGridView1.DataSource = this.databaseDataSet.Users;
                dataGridView1.Refresh();

                MessageBox.Show("Промените са запазени успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при запазване: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
