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
    public partial class LearnUnrealEngine : UserControl
    {
        public LearnUnrealEngine()
        {
            InitializeComponent();
        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemInterface, true);
            boxItemPhysics.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemUI.Visible = false;
            UrlLoader.LoadVideo("ptCN4cysDig", webBrowser1);
        }

        private void LearnUnrealEngine_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemPlayer, true);
            boxItemPhysics.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemInterface.Visible = false;
            boxItemUI.Visible = false;
        }

        private void linkLabelUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemUI, true);
            boxItemPhysics.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemInterface.Visible = false;
        }

        private void linkLabelInteraction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemInteraction, true);
            boxItemPhysics.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemInterface.Visible = false;
            boxItemUI.Visible = false;
        }

        private void linkLabelPhysics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemPhysics, true);
            boxItemPlayer.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemInterface.Visible = false;
            boxItemUI.Visible = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
