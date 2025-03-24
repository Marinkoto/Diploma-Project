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
    public partial class Product : UserControl
    {
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Description
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }

        public Image ItemImage
        {
            get => pBoxIcon.Image;
            set => pBoxIcon.Image = value;
        }
        public Button PurhcaseButton
        {
            get => btnBuy;
        }
        public Action BuyClicked;

        public Product()
        {
            InitializeComponent();

            btnBuy.Click += (s, e) => BuyClicked?.Invoke();
        }

        private void GameProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
