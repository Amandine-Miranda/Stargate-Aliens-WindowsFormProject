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
    public partial class Planete : UserControl
    {
        public Planete()
        {
            InitializeComponent();
        }

        private DataSet monDS;

        public Planete(String nom, int top, int left, DataSet DS)
        {
            InitializeComponent();

            monDS = DS;

            if (nom == "La 9ème planète")
            {
                lblNomPlanete.Top = 80;
            }
            this.Top = top;
            this.Left = left;
            this.BackgroundImage = Image.FromFile("../../Resources/" + nom + ".png");
            lblNomPlanete.Text = nom;
        }

        private void Planete_Click(object sender, EventArgs e)
        {
            frmPlanete frmInfosPlanete = new frmPlanete(lblNomPlanete.Text, monDS);
            frmInfosPlanete.Show();
        }
    }
}
