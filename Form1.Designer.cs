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
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.btnDecouvRaces = new System.Windows.Forms.Button();
            this.btnNouvMission = new System.Windows.Forms.Button();
            this.BtnInfosPlan = new System.Windows.Forms.Button();
            this.grpTableauBord = new System.Windows.Forms.GroupBox();
            this.grpDecouvRaces = new System.Windows.Forms.GroupBox();
            this.grpInfosPlan = new System.Windows.Forms.GroupBox();
            this.grpNouvMission = new System.Windows.Forms.GroupBox();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.btnTableauBord = new System.Windows.Forms.Button();
            this.btnDecouverteRaces = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnInfosPlanete = new System.Windows.Forms.Button();
            this.btnTbBord = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPageMenu);
            this.tabMenu.Controls.Add(this.tabPagePrincipal);
            this.tabMenu.Location = new System.Drawing.Point(-11, -36);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1289, 927);
            this.tabMenu.TabIndex = 4;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.BackColor = System.Drawing.Color.Black;
            this.tabPagePrincipal.Controls.Add(this.btnTbBord);
            this.tabPagePrincipal.Controls.Add(this.btnDecouvRaces);
            this.tabPagePrincipal.Controls.Add(this.btnNouvMission);
            this.tabPagePrincipal.Controls.Add(this.BtnInfosPlan);
            this.tabPagePrincipal.Controls.Add(this.grpTableauBord);
            this.tabPagePrincipal.Controls.Add(this.grpDecouvRaces);
            this.tabPagePrincipal.Controls.Add(this.grpNouvMission);
            this.tabPagePrincipal.Controls.Add(this.grpInfosPlan);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 29);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1281, 894);
            this.tabPagePrincipal.TabIndex = 1;
            this.tabPagePrincipal.Text = "tabPage2";
            // 
            // btnDecouvRaces
            // 
            this.btnDecouvRaces.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnDecouvRaces;
            this.btnDecouvRaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDecouvRaces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnDecouvRaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouvRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecouvRaces.Location = new System.Drawing.Point(35, 273);
            this.btnDecouvRaces.Name = "btnDecouvRaces";
            this.btnDecouvRaces.Size = new System.Drawing.Size(225, 150);
            this.btnDecouvRaces.TabIndex = 1;
            this.btnDecouvRaces.UseVisualStyleBackColor = true;
            this.btnDecouvRaces.Click += new System.EventHandler(this.btnDecouvRaces_Click);
            // 
            // btnNouvMission
            // 
            this.btnNouvMission.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnNouvMission;
            this.btnNouvMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNouvMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnNouvMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvMission.Location = new System.Drawing.Point(35, 421);
            this.btnNouvMission.Name = "btnNouvMission";
            this.btnNouvMission.Size = new System.Drawing.Size(225, 150);
            this.btnNouvMission.TabIndex = 2;
            this.btnNouvMission.UseVisualStyleBackColor = true;
            this.btnNouvMission.Click += new System.EventHandler(this.btnNouvMission_Click);
            // 
            // BtnInfosPlan
            // 
            this.BtnInfosPlan.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnInfosPlanete;
            this.BtnInfosPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInfosPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnInfosPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.BtnInfosPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.BtnInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfosPlan.Location = new System.Drawing.Point(35, 569);
            this.BtnInfosPlan.Name = "BtnInfosPlan";
            this.BtnInfosPlan.Size = new System.Drawing.Size(225, 150);
            this.BtnInfosPlan.TabIndex = 3;
            this.BtnInfosPlan.UseVisualStyleBackColor = true;
            this.BtnInfosPlan.Click += new System.EventHandler(this.BtnInfosPlan_Click);
            // 
            // grpTableauBord
            // 
            this.grpTableauBord.BackColor = System.Drawing.Color.Black;
            this.grpTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTableauBord.Location = new System.Drawing.Point(290, 20);
            this.grpTableauBord.Name = "grpTableauBord";
            this.grpTableauBord.Size = new System.Drawing.Size(950, 825);
            this.grpTableauBord.TabIndex = 4;
            this.grpTableauBord.TabStop = false;
            this.grpTableauBord.Visible = false;
            // 
            // grpDecouvRaces
            // 
            this.grpDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDecouvRaces.Location = new System.Drawing.Point(290, 20);
            this.grpDecouvRaces.Name = "grpDecouvRaces";
            this.grpDecouvRaces.Size = new System.Drawing.Size(955, 828);
            this.grpDecouvRaces.TabIndex = 5;
            this.grpDecouvRaces.TabStop = false;
            this.grpDecouvRaces.Visible = false;
            // 
            // grpInfosPlan
            // 
            this.grpInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpInfosPlan.Location = new System.Drawing.Point(290, 20);
            this.grpInfosPlan.Name = "grpInfosPlan";
            this.grpInfosPlan.Size = new System.Drawing.Size(955, 828);
            this.grpInfosPlan.TabIndex = 6;
            this.grpInfosPlan.TabStop = false;
            this.grpInfosPlan.Visible = false;
            // 
            // grpNouvMission
            // 
            this.grpNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpNouvMission.Location = new System.Drawing.Point(290, 20);
            this.grpNouvMission.Name = "grpNouvMission";
            this.grpNouvMission.Size = new System.Drawing.Size(955, 828);
            this.grpNouvMission.TabIndex = 6;
            this.grpNouvMission.TabStop = false;
            this.grpNouvMission.Visible = false;
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
            this.tabPageMenu.Size = new System.Drawing.Size(1281, 894);
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
            this.btnTableauBord.Location = new System.Drawing.Point(165, 433);
            this.btnTableauBord.Name = "btnTableauBord";
            this.btnTableauBord.Size = new System.Drawing.Size(346, 327);
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
            this.btnDecouverteRaces.Location = new System.Drawing.Point(873, 487);
            this.btnDecouverteRaces.Name = "btnDecouverteRaces";
            this.btnDecouverteRaces.Size = new System.Drawing.Size(259, 255);
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
            this.btnNouvelleMission.Location = new System.Drawing.Point(719, 256);
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
            // btnTbBord
            // 
            this.btnTbBord.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnTableauBord;
            this.btnTbBord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTbBord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnTbBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTbBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTbBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbBord.Location = new System.Drawing.Point(35, 126);
            this.btnTbBord.Name = "btnTbBord";
            this.btnTbBord.Size = new System.Drawing.Size(225, 150);
            this.btnTbBord.TabIndex = 0;
            this.btnTbBord.UseVisualStyleBackColor = true;
            this.btnTbBord.Click += new System.EventHandler(this.btnTbBord_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1258, 864);
            this.Controls.Add(this.tabMenu);
            this.MaximumSize = new System.Drawing.Size(1280, 920);
            this.MinimumSize = new System.Drawing.Size(1280, 920);
            this.Name = "frmAccueil";
            this.Text = "Gestion des missions";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
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
    }
}

