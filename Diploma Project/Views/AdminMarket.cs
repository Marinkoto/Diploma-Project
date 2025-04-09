using Diploma_Project.DatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project.Views
{
    public partial class AdminMarket : UserControl
    {
        public AdminMarket()
        {
            InitializeComponent();
        }

        private void AdminMarket_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
            {
                return;
            }
            DataTable dt = productsTableAdapter.GetData();
            dataGridView1.DataSource = dt;
            cmbBoxGenre.DataSource = productsTableAdapter.GetDataForGenres();
            cmbBoxGenre.DisplayMember = "Genre";

            cmbBoxProductType.DataSource = productsTableAdapter.GetDataForType();
            cmbBoxProductType.DisplayMember = "ProductType";
            cmbBoxGenre.SelectedIndex = 1;
            cmbBoxProductType.SelectedIndex = 1;
        }

        private void btnАdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                openFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
                openFileDialog.Title = "Добави снимка с точното име на играта";
                openFileDialog.FileName = "Снимка";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(openFileDialog.FileName))
                    {
                        string destinationPath = Path.Combine($@"{Application.StartupPath}\Games", Path.GetFileName(openFileDialog.FileName));
                        File.Copy(openFileDialog.FileName, destinationPath, true); 
                    }

                    MessageBox.Show("Файла е копиран успешно!", 
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Грешка в добавянето!",
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                productsTableAdapter.Insert(txtUserName.Text, cmbBoxProductType.Text, txtDescription.Text, price, cmbBoxGenre.Text);
                dataGridView1.DataSource = productsTableAdapter.GetData();
                dataGridView1.Refresh();
                MessageBox.Show($"Успешно добавихте нов запис!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Грешно въведени данни!",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.databaseDataSet.Products);
            int idToDelete = (int)numericUpDownId.Value;

            bool idExists = databaseDataSet.Products.AsEnumerable()
                .Any(user => user.Field<int>("ID") == idToDelete);

            if (!idExists)
            {
                MessageBox.Show($"Няма намерен продукт с ИД {numericUpDownId.Value}!",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show($"Сигурни ли сте че искате да изтриете запис с ИД {numericUpDownId.Value}?" +
                $"\nТова действие е необратимо!",
                "Предупреждение", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes)
            {
                productsTableAdapter.DeleteById((int)numericUpDownId.Value);

                this.productsTableAdapter.Fill(this.databaseDataSet.Products);
                dataGridView1.DataSource = productsTableAdapter.GetData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                databaseDataSet.Products.Merge((DataTable)dataGridView1.DataSource);
                DataTable changes = databaseDataSet.Products.GetChanges();

                if (changes != null)
                {
                    this.productsTableAdapter.Update(databaseDataSet.Products);

                    databaseDataSet.Products.AcceptChanges();
                }

                this.productsTableAdapter.Fill(this.databaseDataSet.Products);
                dataGridView1.DataSource = this.databaseDataSet.Products;
                dataGridView1.Refresh();

                MessageBox.Show("Промените са запазени успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при запазване: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productsTableAdapter.GetData();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
