using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Diploma_Project.Views
{
    public partial class LearnUnity : UserControl
    {
        public LearnUnity()
        {
            InitializeComponent();
        }

        private void LearnUnity_Load(object sender, EventArgs e)
        {
        }
        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxItemStart.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemAnimations.Visible = false;
            boxItemCamera.Visible = false;
            boxItemGameplay.Visible = false;
            ButtonUtils.ManagePanel(boxItemStart, true);
            UrlLoader.LoadVideo("XtQMytORBmM", webBrowser1);
        }

        private void linkLabelPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxItemStart.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemAnimations.Visible = false;
            boxItemCamera.Visible = false;
            boxItemGameplay.Visible = false;
            ButtonUtils.ManagePanel(boxItemPlayer, true);
        }

        private void linkLabelCamera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxItemStart.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemAnimations.Visible = false;
            boxItemCamera.Visible = false;
            boxItemGameplay.Visible = false;
            ButtonUtils.ManagePanel(boxItemCamera, true);
        }

        private void linkLabelGameplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxItemStart.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemAnimations.Visible = false;
            boxItemCamera.Visible = false;
            boxItemGameplay.Visible = false;
            ButtonUtils.ManagePanel(boxItemGameplay, true);
        }

        private void linkLabelAnimation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxItemStart.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemAnimations.Visible = false;
            boxItemCamera.Visible = false;
            boxItemGameplay.Visible = false;
            ButtonUtils.ManagePanel(boxItemAnimations, true);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
