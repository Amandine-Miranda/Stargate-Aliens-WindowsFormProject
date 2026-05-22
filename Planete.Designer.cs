namespace SAE24STARGATE
{
    partial class Planete
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomPlanete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomPlanete
            // 
            this.lblNomPlanete.AutoSize = true;
            this.lblNomPlanete.BackColor = System.Drawing.Color.Transparent;
            this.lblNomPlanete.Font = new System.Drawing.Font("Orbitron Black", 10F);
            this.lblNomPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblNomPlanete.Location = new System.Drawing.Point(25, 145);
            this.lblNomPlanete.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblNomPlanete.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblNomPlanete.Name = "lblNomPlanete";
            this.lblNomPlanete.Size = new System.Drawing.Size(140, 25);
            this.lblNomPlanete.TabIndex = 0;
            this.lblNomPlanete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Planete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lblNomPlanete);
            this.Name = "Planete";
            this.Size = new System.Drawing.Size(195, 195);
            this.Click += new System.EventHandler(this.Planete_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPlanete;
    }
}
