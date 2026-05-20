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
    public partial class Alien : UserControl
    {
        public Alien()
        {
            InitializeComponent();
        }

        public Alien(String nom, String couleur, String origine, String armeOuInstrument, String cheminImage, Boolean arme, String niveauBienveillanceDangerosite, int posLeft, int posTop)
        {
            InitializeComponent();
            lblNom.Text = "-> " + nom;
            lblCouleur.Text = couleur;
            lblOrigine.Text = origine;
            lblArmeInstrument.Text = armeOuInstrument;
            //pbox.Image = Image.FromFile(cheminImage);
            if (arme)
            {
                lblArmeInstrument.ForeColor = Color.FromArgb(184, 143, 255); //violet
                lblAllieEnnemi.ForeColor = Color.FromArgb(184, 143, 255); //violet
                lblAllieEnnemi.Text = "-- Ennemi --";
                lblBienveillanceDangerosite.Text = "Dangerosité : " + niveauBienveillanceDangerosite;
                lblBienveillanceDangerosite.ForeColor = Color.FromArgb(184, 143, 255); //violet
            }
            else
            {
                lblArmeInstrument.ForeColor = Color.FromArgb(165, 255, 64); //vert
                lblAllieEnnemi.ForeColor = Color.FromArgb(165, 255, 64); // vert
                lblAllieEnnemi.Text = "-- Allié --";
                lblBienveillanceDangerosite.Text = "Bienveillance : " + niveauBienveillanceDangerosite;
                lblBienveillanceDangerosite.ForeColor = Color.FromArgb(165, 255, 64); // vert 
            }
            this.Left = posLeft;
            this.Top = posTop;
        }

        public System.Drawing.ContentAlignment setAlignement
        {
            set { lblOrigine.TextAlign = value; }
        }

    }
}
