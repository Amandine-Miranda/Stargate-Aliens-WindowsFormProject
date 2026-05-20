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
                newGrp.Height = 250;
                newGrp.Top = top;
                newGrp.Left = left;
                newGrp.Text = "";


                PictureBox pbox = new PictureBox();
                pbox.Top = 15;
                pbox.Left = 10;
                pbox.Width = 105;
                pbox.Height = 105;
                pbox.BackColor = Color.White;

                newGrp.Controls.Add(pbox);

                Label lbl = new Label();
                lbl.Top = 15 + pbox.Height + 5;
                lbl.Left = 10;
                lbl.Text = "-> " + ligne["nom"].ToString();
                lbl.ForeColor = Color.FromArgb(31, 234, 204);   // Le fameux turquoise
                lbl.Font = new Font("Orbitron", 7, FontStyle.Bold);

                newGrp.Controls.Add(lbl);

                Label clr = new Label();
                clr.Top = lbl.Top + lbl.Height - 2;
                clr.Left = 10;
                clr.Text = ligne["couleur"].ToString();
                clr.ForeColor = Color.FromArgb(36, 107, 255); // Le fameux bleu
                clr.Font = new Font("Orbitron", 8, FontStyle.Bold);

                newGrp.Controls.Add(clr);

                //Initialise un label de base "Origine inconnue" au cas-où on ne trouve pas l'origine de l'alien
                Label origine = new Label();
                origine.Top = clr.Top + clr.Height - 2;
                origine.Left = 10;
                origine.Text = "\t?";
                origine.TextAlign = ContentAlignment.TopCenter;
                origine.ForeColor = Color.FromArgb(31, 234, 204);    //Le fameux turquoise
                origine.Font = new Font("Orbitron", 7, FontStyle.Bold);

                //Permet de savoir d'où vient l'alien en parcourant les données de la table Habiter, tout en gérant bien la mise en page avec 
                foreach (DataRow ligne2 in monDS.Tables["Habiter"].Rows)
                {
                    if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        origine.TextAlign = ContentAlignment.TopLeft;

                        origine.ForeColor = Color.FromArgb(31, 234, 204); // Le fameux turquoise
                        if (origine.Text == "\t?")
                        {
                            origine.Text = ligne2["nomPlanete"].ToString() + "/";
                        }
                        else
                        {
                            origine.Text += ligne2["nomPlanete"].ToString() + "/";

                            if (origine.Text.Length >= 16)
                            {
                                origine.Text = origine.Text.Substring(0, origine.Text.Length - ligne2["nomPlanete"].ToString().Length - 1) + "\n" + ligne2["nomPlanete"].ToString() + "/";
                            }
                        }
                    }
                }

                //On doit enlever le slash de fin, mais pas si c'est origine inconnue, car il n'y en a pas
                if(origine.Text.Substring(origine.Text.Length - 1, 1) == "/")
                {
                    origine.Text = origine.Text.Substring(0, origine.Text.Length - 1);
                }

                newGrp.Controls.Add(origine);


                //Permet de savoir si l'alien actuel est un allié 
                foreach (DataRow ligne2 in monDS.Tables["Allie"].Rows)
                {
                    if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        Label allie = new Label();
                        allie.Top = 0;
                        allie.Left = lbl.Left;
                        allie.Text = "Allié";
                        allie.TextAlign = ContentAlignment.TopCenter;
                        allie.ForeColor = Color.FromArgb(165, 255, 64);   // Joli vert néon
                        allie.Font = new Font("Orbitron", 7, FontStyle.Bold);


                        Label instrument = new Label();
                        instrument.Top = origine.Top + origine.Height;
                        instrument.Left = 10;
                        instrument.ForeColor = Color.FromArgb(165, 255, 64);    // Joli vert neon
                        instrument.Font = new Font("Orbitron", 7, FontStyle.Bold);
                        instrument.Height = 50;

                        instrument.Text = ligne2["instrumentMusique"].ToString();

                        // Permet d'afficher les instruments qui ont un long nom bien

                        if (instrument.Text.Length >= 16)
                        {
                            instrument.Text = "";
                            String[] instrumentTab = new String[5];
                            instrumentTab = ligne2["instrumentMusique"].ToString().Split(' ');
                            foreach (String mot in instrumentTab)
                            {
                                if (instrument.Text.Length >= 16)
                                {
                                    instrument.Text += "\n" + mot;
                                }
                                else
                                {
                                    instrument.Text += mot + " ";
                                }
                            }

                        }

                        newGrp.Controls.Add(allie);
                        newGrp.Controls.Add(instrument);
                        break;
                    }
                }

                //Permet de savoir si l'alien actuel est un ennemi
                foreach (DataRow ligne3 in monDS.Tables["Ennemi"].Rows)
                {
                    if (ligne3["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        Label ennemi = new Label();
                        ennemi.Top = 0;
                        ennemi.Left = lbl.Left;
                        ennemi.Text = "Ennemi";
                        ennemi.TextAlign = ContentAlignment.TopCenter;
                        ennemi.ForeColor = Color.FromArgb(184, 143, 255);   // Joli violet
                        ennemi.Font = new Font("Orbitron", 7, FontStyle.Bold);

                        Label arme = new Label();
                        arme.Top = origine.Top + origine.Height;
                        arme.Left = 10;
                        arme.ForeColor = Color.FromArgb(184, 143, 255); // Joli violet
                        arme.Font = new Font("Orbitron", 7, FontStyle.Bold);
                        arme.Height = 50;

                        arme.Text = ligne3["typeArme"].ToString();

                        // Permet d'afficher les armes qui ont un long nom bien

                        if (arme.Text.Length >= 16)
                        {
                            arme.Text = "";
                            String[] armeTab = new String[5];
                            armeTab = ligne3["typeArme"].ToString().Split(' ');
                            foreach (String mot in armeTab)
                            {
                                if (arme.Text.Length >= 16)
                                {
                                    arme.Text += "\n" + mot;
                                }
                                else
                                {
                                    arme.Text += mot + " ";
                                }
                            }
                        }

                        newGrp.Controls.Add(ennemi);
                        newGrp.Controls.Add(arme);
                        break;
                    }
                }

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
            grpTableauBord.Controls.Clear();    //Leo , clear la groupbox qui affiche les missions pour eviter les bugs où des missions sont déja affichées.
            // AMANDINE
        }

        private void btnDecouverteRaces_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Decouverte des Races)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpDecouvRaces.Visible = true;
            grpTableauBord.Controls.Clear();    //Leo , clear la groupbox qui affiche les missions pour eviter les bugs où des missions sont déja affichées.
            // AMANDINE
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Nouvelle Mission)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpNouvMission.Visible = true;
            grpTableauBord.Controls.Clear();    //Leo , clear la groupbox qui affiche les missions pour eviter les bugs où des missions sont déja affichées.
            // AMANDINE
        }

        private void btnInfosPlanete_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Infos Planètes)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpInfosPlan.Visible = true;
            grpTableauBord.Controls.Clear();    //Leo , clear la groupbox qui affiche les missions pour eviter les bugs où des missions sont déja affichées.
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
