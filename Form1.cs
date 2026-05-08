using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24STARGATE
{

    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPagePrincipal;
        }

        private void btnDecouverteRaces_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPagePrincipal;
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPagePrincipal;
        }

        private void btnInfosPlanete_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPagePrincipal;
        }

    }
}
