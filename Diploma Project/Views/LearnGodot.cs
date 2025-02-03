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
    public partial class LearnGodot : UserControl
    {
        public LearnGodot()
        {
            InitializeComponent();
        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemInterface, true);
            boxItemPhysics.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemPlayer.Visible = false;
            UrlLoader.LoadVideo("LOhfqjmasi0", webBrowser1);
        }

        private void linkLabelInteraction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemInteraction, true);
            boxItemPhysics.Visible = false;
            boxItemPlayer.Visible = false;
            boxItemInterface.Visible = false;
        }

        private void linkLabelPhysics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemPhysics, true);
            boxItemPlayer.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemInterface.Visible = false;
        }

        private void linkLabelPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonUtils.ManagePanel(boxItemPlayer, true);
            boxItemPhysics.Visible = false;
            boxItemInteraction.Visible = false;
            boxItemInterface.Visible = false;
        }

        private void LearnGodot_Load(object sender, EventArgs e)
        {

        }
    }
}
