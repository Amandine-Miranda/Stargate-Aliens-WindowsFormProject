namespace SAE24STARGATE
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.btnTableauBord = new System.Windows.Forms.Button();
            this.btnDecouverteRaces = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnInfosPlanete = new System.Windows.Forms.Button();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.btnTbBord = new System.Windows.Forms.Button();
            this.btnDecouvRaces = new System.Windows.Forms.Button();
            this.btnNouvMission = new System.Windows.Forms.Button();
            this.BtnInfosPlan = new System.Windows.Forms.Button();
            this.grpInfosPlan = new System.Windows.Forms.GroupBox();
            this.grpDecouvRaces = new System.Windows.Forms.GroupBox();
            this.panelAliens = new System.Windows.Forms.Panel();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.btnRechercherAliens = new System.Windows.Forms.Button();
            this.cboCouleursAliens = new System.Windows.Forms.ComboBox();
            this.txtNomAliens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomAlien = new System.Windows.Forms.Label();
            this.grpTableauBord = new System.Windows.Forms.GroupBox();
            this.btnFutur = new System.Windows.Forms.Button();
            this.btnPasse = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.grpMissionsTDB = new System.Windows.Forms.GroupBox();
            this.grpNouvMission = new System.Windows.Forms.GroupBox();
            this.panelPlanetes = new System.Windows.Forms.Panel();
            this.tabMenu.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.grpInfosPlan.SuspendLayout();
            this.grpDecouvRaces.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.grpTableauBord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPageMenu);
            this.tabMenu.Controls.Add(this.tabPagePrincipal);
            this.tabMenu.Location = new System.Drawing.Point(-10, -35);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1288, 928);
            this.tabMenu.TabIndex = 4;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.BackColor = System.Drawing.Color.Black;
            this.tabPageMenu.BackgroundImage = global::SAE24STARGATE.Properties.Resources.BGimg1;
            this.tabPageMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageMenu.Controls.Add(this.btnTableauBord);
            this.tabPageMenu.Controls.Add(this.btnDecouverteRaces);
            this.tabPageMenu.Controls.Add(this.btnNouvelleMission);
            this.tabPageMenu.Controls.Add(this.btnInfosPlanete);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 29);
            this.tabPageMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(1280, 895);
            this.tabPageMenu.TabIndex = 0;
            this.tabPageMenu.Text = "tabPage1";
            // 
            // btnTableauBord
            // 
            this.btnTableauBord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableauBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatAppearance.BorderSize = 0;
            this.btnTableauBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableauBord.Font = new System.Drawing.Font("Orbitron", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauBord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTableauBord.Location = new System.Drawing.Point(165, 432);
            this.btnTableauBord.Name = "btnTableauBord";
            this.btnTableauBord.Size = new System.Drawing.Size(346, 328);
            this.btnTableauBord.TabIndex = 0;
            this.btnTableauBord.Text = "Tableau\r\nde bord";
            this.btnTableauBord.UseVisualStyleBackColor = false;
            this.btnTableauBord.Click += new System.EventHandler(this.btnTableauBord_Click);
            // 
            // btnDecouverteRaces
            // 
            this.btnDecouverteRaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecouverteRaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatAppearance.BorderSize = 0;
            this.btnDecouverteRaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecouverteRaces.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecouverteRaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouverteRaces.Location = new System.Drawing.Point(873, 488);
            this.btnDecouverteRaces.Name = "btnDecouverteRaces";
            this.btnDecouverteRaces.Size = new System.Drawing.Size(260, 255);
            this.btnDecouverteRaces.TabIndex = 1;
            this.btnDecouverteRaces.Text = "Découverte \r\ndes races";
            this.btnDecouverteRaces.UseVisualStyleBackColor = false;
            this.btnDecouverteRaces.Click += new System.EventHandler(this.btnDecouverteRaces_Click);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatAppearance.BorderSize = 0;
            this.btnNouvelleMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvelleMission.Location = new System.Drawing.Point(718, 255);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(208, 198);
            this.btnNouvelleMission.TabIndex = 2;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // btnInfosPlanete
            // 
            this.btnInfosPlanete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfosPlanete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatAppearance.BorderSize = 0;
            this.btnInfosPlanete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfosPlanete.Font = new System.Drawing.Font("Orbitron", 12F);
            this.btnInfosPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnInfosPlanete.Location = new System.Drawing.Point(348, 275);
            this.btnInfosPlanete.Name = "btnInfosPlanete";
            this.btnInfosPlanete.Size = new System.Drawing.Size(168, 158);
            this.btnInfosPlanete.TabIndex = 3;
            this.btnInfosPlanete.Text = "Infos planètes";
            this.btnInfosPlanete.UseVisualStyleBackColor = false;
            this.btnInfosPlanete.Click += new System.EventHandler(this.btnInfosPlanete_Click);
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.BackColor = System.Drawing.Color.Black;
            this.tabPagePrincipal.Controls.Add(this.btnTbBord);
            this.tabPagePrincipal.Controls.Add(this.btnDecouvRaces);
            this.tabPagePrincipal.Controls.Add(this.btnNouvMission);
            this.tabPagePrincipal.Controls.Add(this.BtnInfosPlan);
            this.tabPagePrincipal.Controls.Add(this.grpInfosPlan);
            this.tabPagePrincipal.Controls.Add(this.grpDecouvRaces);
            this.tabPagePrincipal.Controls.Add(this.grpTableauBord);
            this.tabPagePrincipal.Controls.Add(this.grpNouvMission);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 29);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1280, 895);
            this.tabPagePrincipal.TabIndex = 1;
            this.tabPagePrincipal.Text = "tabPage2";
            // 
            // btnTbBord
            // 
            this.btnTbBord.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnTableauBord;
            this.btnTbBord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTbBord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnTbBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTbBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTbBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbBord.Location = new System.Drawing.Point(34, 126);
            this.btnTbBord.Name = "btnTbBord";
            this.btnTbBord.Size = new System.Drawing.Size(225, 151);
            this.btnTbBord.TabIndex = 0;
            this.btnTbBord.UseVisualStyleBackColor = true;
            this.btnTbBord.Click += new System.EventHandler(this.btnTbBord_Click);
            // 
            // btnDecouvRaces
            // 
            this.btnDecouvRaces.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnDecouvRaces;
            this.btnDecouvRaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDecouvRaces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDecouvRaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouvRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecouvRaces.Location = new System.Drawing.Point(34, 272);
            this.btnDecouvRaces.Name = "btnDecouvRaces";
            this.btnDecouvRaces.Size = new System.Drawing.Size(225, 151);
            this.btnDecouvRaces.TabIndex = 1;
            this.btnDecouvRaces.UseVisualStyleBackColor = true;
            this.btnDecouvRaces.Click += new System.EventHandler(this.btnDecouvRaces_Click);
            // 
            // btnNouvMission
            // 
            this.btnNouvMission.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnNouvMission;
            this.btnNouvMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNouvMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnNouvMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvMission.Location = new System.Drawing.Point(34, 422);
            this.btnNouvMission.Name = "btnNouvMission";
            this.btnNouvMission.Size = new System.Drawing.Size(225, 151);
            this.btnNouvMission.TabIndex = 2;
            this.btnNouvMission.UseVisualStyleBackColor = true;
            this.btnNouvMission.Click += new System.EventHandler(this.btnNouvMission_Click);
            // 
            // BtnInfosPlan
            // 
            this.BtnInfosPlan.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnInfosPlanete;
            this.BtnInfosPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInfosPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.BtnInfosPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.BtnInfosPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.BtnInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfosPlan.Location = new System.Drawing.Point(34, 569);
            this.BtnInfosPlan.Name = "BtnInfosPlan";
            this.BtnInfosPlan.Size = new System.Drawing.Size(225, 151);
            this.BtnInfosPlan.TabIndex = 3;
            this.BtnInfosPlan.UseVisualStyleBackColor = true;
            this.BtnInfosPlan.Click += new System.EventHandler(this.BtnInfosPlan_Click);
            // 
            // grpInfosPlan
            // 
            this.grpInfosPlan.Controls.Add(this.panelPlanetes);
            this.grpInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInfosPlan.Location = new System.Drawing.Point(290, 20);
            this.grpInfosPlan.Name = "grpInfosPlan";
            this.grpInfosPlan.Size = new System.Drawing.Size(950, 825);
            this.grpInfosPlan.TabIndex = 6;
            this.grpInfosPlan.TabStop = false;
            this.grpInfosPlan.Visible = false;
            // 
            // grpDecouvRaces
            // 
            this.grpDecouvRaces.Controls.Add(this.panelAliens);
            this.grpDecouvRaces.Controls.Add(this.grpFiltres);
            this.grpDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDecouvRaces.Location = new System.Drawing.Point(290, 20);
            this.grpDecouvRaces.Name = "grpDecouvRaces";
            this.grpDecouvRaces.Size = new System.Drawing.Size(950, 825);
            this.grpDecouvRaces.TabIndex = 5;
            this.grpDecouvRaces.TabStop = false;
            this.grpDecouvRaces.Visible = false;
            // 
            // panelAliens
            // 
            this.panelAliens.AutoScroll = true;
            this.panelAliens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAliens.ForeColor = System.Drawing.Color.Black;
            this.panelAliens.Location = new System.Drawing.Point(21, 220);
            this.panelAliens.Name = "panelAliens";
            this.panelAliens.Size = new System.Drawing.Size(910, 580);
            this.panelAliens.TabIndex = 7;
            // 
            // grpFiltres
            // 
            this.grpFiltres.Controls.Add(this.btnRechercherAliens);
            this.grpFiltres.Controls.Add(this.cboCouleursAliens);
            this.grpFiltres.Controls.Add(this.txtNomAliens);
            this.grpFiltres.Controls.Add(this.label1);
            this.grpFiltres.Controls.Add(this.lblNomAlien);
            this.grpFiltres.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.grpFiltres.Location = new System.Drawing.Point(21, 20);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Size = new System.Drawing.Size(910, 180);
            this.grpFiltres.TabIndex = 1;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // btnRechercherAliens
            // 
            this.btnRechercherAliens.BackgroundImage = global::SAE24STARGATE.Properties.Resources.iconeLoupe1;
            this.btnRechercherAliens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRechercherAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherAliens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRechercherAliens.Location = new System.Drawing.Point(785, 42);
            this.btnRechercherAliens.Name = "btnRechercherAliens";
            this.btnRechercherAliens.Size = new System.Drawing.Size(95, 95);
            this.btnRechercherAliens.TabIndex = 4;
            this.btnRechercherAliens.UseVisualStyleBackColor = true;
            this.btnRechercherAliens.Click += new System.EventHandler(this.btnRechercherAliens_Click);
            // 
            // cboCouleursAliens
            // 
            this.cboCouleursAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboCouleursAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCouleursAliens.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCouleursAliens.ForeColor = System.Drawing.Color.White;
            this.cboCouleursAliens.FormattingEnabled = true;
            this.cboCouleursAliens.Location = new System.Drawing.Point(182, 104);
            this.cboCouleursAliens.Name = "cboCouleursAliens";
            this.cboCouleursAliens.Size = new System.Drawing.Size(546, 33);
            this.cboCouleursAliens.TabIndex = 3;
            this.cboCouleursAliens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCouleursAliens_KeyPress);
            // 
            // txtNomAliens
            // 
            this.txtNomAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtNomAliens.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAliens.ForeColor = System.Drawing.Color.White;
            this.txtNomAliens.Location = new System.Drawing.Point(182, 44);
            this.txtNomAliens.Name = "txtNomAliens";
            this.txtNomAliens.Size = new System.Drawing.Size(546, 33);
            this.txtNomAliens.TabIndex = 2;
            this.txtNomAliens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAliens_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(35, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Couleur :";
            // 
            // lblNomAlien
            // 
            this.lblNomAlien.AutoSize = true;
            this.lblNomAlien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblNomAlien.Location = new System.Drawing.Point(35, 46);
            this.lblNomAlien.Name = "lblNomAlien";
            this.lblNomAlien.Size = new System.Drawing.Size(72, 25);
            this.lblNomAlien.TabIndex = 0;
            this.lblNomAlien.Text = "Nom :";
            // 
            // grpTableauBord
            // 
            this.grpTableauBord.BackColor = System.Drawing.Color.Black;
            this.grpTableauBord.Controls.Add(this.btnFutur);
            this.grpTableauBord.Controls.Add(this.btnPasse);
            this.grpTableauBord.Controls.Add(this.btnPresent);
            this.grpTableauBord.Controls.Add(this.grpMissionsTDB);
            this.grpTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTableauBord.Location = new System.Drawing.Point(290, 20);
            this.grpTableauBord.Name = "grpTableauBord";
            this.grpTableauBord.Size = new System.Drawing.Size(950, 825);
            this.grpTableauBord.TabIndex = 4;
            this.grpTableauBord.TabStop = false;
            this.grpTableauBord.Visible = false;
            // 
            // btnFutur
            // 
            this.btnFutur.Location = new System.Drawing.Point(614, 28);
            this.btnFutur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFutur.Name = "btnFutur";
            this.btnFutur.Size = new System.Drawing.Size(255, 77);
            this.btnFutur.TabIndex = 4;
            this.btnFutur.Text = "button3";
            this.btnFutur.UseVisualStyleBackColor = true;
            // 
            // btnPasse
            // 
            this.btnPasse.Location = new System.Drawing.Point(81, 28);
            this.btnPasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPasse.Name = "btnPasse";
            this.btnPasse.Size = new System.Drawing.Size(255, 77);
            this.btnPasse.TabIndex = 3;
            this.btnPasse.Text = "button2";
            this.btnPasse.UseVisualStyleBackColor = true;
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(350, 28);
            this.btnPresent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(255, 77);
            this.btnPresent.TabIndex = 2;
            this.btnPresent.Text = "button1";
            this.btnPresent.UseVisualStyleBackColor = true;
            // 
            // grpMissionsTDB
            // 
            this.grpMissionsTDB.Location = new System.Drawing.Point(81, 106);
            this.grpMissionsTDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMissionsTDB.MaximumSize = new System.Drawing.Size(788, 692);
            this.grpMissionsTDB.MinimumSize = new System.Drawing.Size(788, 692);
            this.grpMissionsTDB.Name = "grpMissionsTDB";
            this.grpMissionsTDB.Padding = new System.Windows.Forms.Padding(0);
            this.grpMissionsTDB.Size = new System.Drawing.Size(788, 692);
            this.grpMissionsTDB.TabIndex = 0;
            this.grpMissionsTDB.TabStop = false;
            // 
            // grpNouvMission
            // 
            this.grpNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNouvMission.Location = new System.Drawing.Point(290, 20);
            this.grpNouvMission.Name = "grpNouvMission";
            this.grpNouvMission.Size = new System.Drawing.Size(950, 825);
            this.grpNouvMission.TabIndex = 6;
            this.grpNouvMission.TabStop = false;
            this.grpNouvMission.Visible = false;
            // 
            // panelPlanetes
            // 
            this.panelPlanetes.AutoScroll = true;
            this.panelPlanetes.Location = new System.Drawing.Point(5, 15);
            this.panelPlanetes.Name = "panelPlanetes";
            this.panelPlanetes.Size = new System.Drawing.Size(940, 805);
            this.panelPlanetes.TabIndex = 0;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1256, 855);
            this.Controls.Add(this.tabMenu);
            this.MaximumSize = new System.Drawing.Size(1278, 911);
            this.MinimumSize = new System.Drawing.Size(1278, 911);
            this.Name = "frmAccueil";
            this.Text = "Gestion des missions";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.grpInfosPlan.ResumeLayout(false);
            this.grpDecouvRaces.ResumeLayout(false);
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.grpTableauBord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTableauBord;
        private System.Windows.Forms.Button btnDecouverteRaces;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnInfosPlanete;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.GroupBox grpTableauBord;
        private System.Windows.Forms.Button BtnInfosPlan;
        private System.Windows.Forms.Button btnNouvMission;
        private System.Windows.Forms.Button btnDecouvRaces;
        private System.Windows.Forms.Button btnTbBord;
        private System.Windows.Forms.GroupBox grpDecouvRaces;
        private System.Windows.Forms.GroupBox grpNouvMission;
        private System.Windows.Forms.GroupBox grpInfosPlan;
        private System.Windows.Forms.GroupBox grpMissionsTDB;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnFutur;
        private System.Windows.Forms.Button btnPasse;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomAlien;
        private System.Windows.Forms.ComboBox cboCouleursAliens;
        private System.Windows.Forms.TextBox txtNomAliens;
        private System.Windows.Forms.Button btnRechercherAliens;
        private System.Windows.Forms.Panel panelAliens;
        private System.Windows.Forms.Panel panelPlanetes;
    }
}

