using Diploma_Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            market.LoadMarketItems();
            weeklyDiscounts.LoadMarketItems();
            CloseAllControls();
        }

        private void SignInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            signIn.Show();
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
        }
        private void CloseAllControls()
        {
            foreach (Control control in this.Controls)
            {
                if(control.Tag != null && control.Tag.ToString() == "CustomControl")
                {
                    control.Hide();
                }
            }
        }

        private void RegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            register.Show();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            aboutUs.Show();
        }

        private void GamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            market.Show();
        }

        private void market_Load(object sender, EventArgs e)
        {

        }

        private void MyGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            myGames.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            sendAReport.Show();
        }

        private void LearningMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            learningMaterials.Show();
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            contacts.Show();
        }

        private void contacts_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void UnityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            learnUnity.Show();
        }

        private void GodotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            learnGodot.Show();
        }

        private void UnrealEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            learnUnrealEngine.Show();
        }

        private void WeeklyDiscountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            weeklyDiscounts.Show();
        }

        private void services1_Load(object sender, EventArgs e)
        {

        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            services.Show();
        }
    }
}
