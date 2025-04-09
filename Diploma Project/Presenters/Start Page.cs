using Diploma_Project.Presenters;
using Diploma_Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            CloseAllControls();
            market.LoadMarketItems("Игра");
            weeklyDiscounts.LoadMarketItems("Намаление");
            newReleases.LoadMarketItems("Ново заглавие");
            freeGames.LoadMarketItems("Безплатна игра");
        }

        private void SignInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            signIn1.Show();
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

        private void CompleteSignIn()
        {
            CheckOuttoolStripMenuItem.Visible = true;
            MyGamesToolStripMenuItem.Visible = true;
            SignInToolStripMenuItem.Visible = false;
            RegistrationToolStripMenuItem.Visible = false;
            SignOutToolStripMenuItem.Visible = true;
            SignIn.SignedIn = true;
            CloseAllControls();
            Title.Text = "Добре Дошли!";
            Title.Location = new Point(325, 40);
            MessageBox.Show("Влизането бе успешно!","Успех!",MessageBoxButtons.OK,
                MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            this.Text = $"Gamehub - {SignIn.NameOfUser}";
        }

        private void RegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            register.Show();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            SignIn.SignInCompleted += (s,ea) =>
            {
                CompleteSignIn();
            };
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
            market.LoadMarketItems("Игра");
        }

        private void market_Load(object sender, EventArgs e)
        {

        }

        private void MyGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            myGames.Show();
            myGames.LoadMarketItems("Игра");
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

        private void CheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void FreeGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            freeGames.Show();
            freeGames.LoadMarketItems("Безплатна игра");
        }

        private void NewTitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllControls();
            newReleases.Show();
            newReleases.LoadMarketItems("Ново заглавие");
        }

        private void WeeklyDiscountstoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CloseAllControls();
            weeklyDiscounts.Show();
        }

        private void CheckOuttoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Checkout checkOut = new Checkout();
            checkOut.Show();
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Сигурни ли сте че искате да излезнете от профила си?",
                "Предупреждение", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if(result == DialogResult.Yes)
            {
                Application.Restart();
            }            
        }

        private void MarketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
