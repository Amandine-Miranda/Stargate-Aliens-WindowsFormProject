using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SAE24STARGATE
{

    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        //AMANDINE
        //permet d'initialiser le mode déconnecté de la base de données
        SQLiteConnection maConnec = new SQLiteConnection();
        string connecString = @"Data Source = Stargate.db";
        DataSet monDS = new DataSet();
        //AMANDINE
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            //AMANDINE
            //permet d'initialiser le mode déconnecté de la base de données et de mettre la base de données dans monDS, le dataSet
            maConnec.ConnectionString = connecString;

            maConnec.Open();
            DataTable dtSchema = maConnec.GetSchema("Tables");

            for (int i = 1; i < dtSchema.Rows.Count; i++)
            {
                string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();

                string requete = "select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(requete, maConnec);

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.SelectCommand = cd;

                da.Fill(monDS, nomTable);
            }

            //AMANDINE

            //AMANDINE
            //Permet de remplir un nouveau DataSet, cette fois-ci uniquement avec les couleurs distinctes d'Aliens, dans le but de remplir la cboCouleursAliens
            SQLiteDataAdapter da2 = new SQLiteDataAdapter("SELECT DISTINCT couleur FROM Espece ORDER BY couleur", maConnec);

            da2.Fill(monDS, "Couleurs");

            cboCouleursAliens.DataSource = monDS.Tables["Couleurs"];
            cboCouleursAliens.DisplayMember = "couleur";
            
            maConnec.Close();
            //AMANDINE

            //AMANDINE
            //Permet de charger tous les aliens à partir d'espèce (en distinguant les alliés et ennemis) dans le grpAliens

            //MessageBox.Show(monDS.Tables["Espece"].Rows[0]["nom"].ToString()); => Return noomahS

            int top = 10;
            int left = 15;

            foreach(DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                GroupBox newGrp = new GroupBox();
                newGrp.Width = 125;
                newGrp.Height = 225;
                newGrp.Top = top;
                newGrp.Left = left;
                newGrp.Text = "";

                PictureBox pbox = new PictureBox();
                pbox.Top = 15;
                pbox.Left = 10;
                pbox.Width = 105;
                pbox.Height = 105;
                pbox.BackColor = Color.White;

                Label lbl = new Label();
                lbl.Top = 15 + pbox.Height + 5;
                lbl.Left = 10;
                lbl.Text = "-> " + ligne["nom"].ToString();
                lbl.ForeColor = Color.FromArgb(31, 234, 204);
                lbl.Font = new Font("Orbitron", 7, FontStyle.Bold);

                Label clr = new Label();
                clr.Top = lbl.Top + lbl.Height - 2;
                clr.Left = 10;
                clr.Text = ligne["couleur"].ToString();
                clr.ForeColor = Color.FromArgb(26, 0, 255);
                clr.Font = new Font("Orbitron", 8, FontStyle.Bold);

                // prochaine étape c'est de checker si l'alien est un allié ou un ennemi pour savoir quoi afficher

                newGrp.Controls.Add(pbox);
                newGrp.Controls.Add(lbl);
                newGrp.Controls.Add(clr);

                panelAliens.Controls.Add(newGrp);

                left += newGrp.Width + 20;

                if (left > 540)
                {
                    left = 15;
                    top += newGrp.Height + 20;
                }
            }

            //AMANDINE

        }

        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Tableau de Bord)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpTableauBord.Visible = true;
            // AMANDINE
        }

        private void btnDecouverteRaces_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Decouverte des Races)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpDecouvRaces.Visible = true;
            // AMANDINE
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Nouvelle Mission)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpNouvMission.Visible = true;
            // AMANDINE
        }

        private void btnInfosPlanete_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Infos Planètes)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpInfosPlan.Visible = true;
            // AMANDINE
        }

        private void btnTbBord_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Tableau de Bord)
            grpDecouvRaces.Visible = false;
            grpInfosPlan.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = true;
            // AMANDINE
        }

        private void btnDecouvRaces_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Découverte des Races)
            grpInfosPlan.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = false;
            grpDecouvRaces.Visible = true;
            // AMANDINE
        }

        private void btnNouvMission_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Nouvelle Mission)
            grpDecouvRaces.Visible = false;
            grpInfosPlan.Visible = false;
            grpTableauBord.Visible = false;
            grpNouvMission.Visible = true;
            // AMANDINE
        }

        private void BtnInfosPlan_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Infos Planètes)
            grpDecouvRaces.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = false;
            grpInfosPlan.Visible = true;
            // AMANDINE
        }

        private void txtNomAliens_KeyPress(object sender, KeyPressEventArgs e)
        {
            // AMANDINE
            // Permet de n'autoriser que les lettres et le retour arrière, shift, espace, entrée etc... Dans la zone de texte permettant de rentrer le nom des aliens
            if(!(Char.IsLetter(e.KeyChar)) && !(Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            // AMANDINE
        }

        private void btnRechercherAliens_Click(object sender, EventArgs e)
        {

        }

    }
}
