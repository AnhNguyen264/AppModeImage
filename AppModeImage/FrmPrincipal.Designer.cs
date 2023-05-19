namespace AppModeImage
{
    partial class FrmPrincipal
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
            this.vsiLuminosité = new VisualArrays.VisualCells.VisualInt();
            this.panAjustements = new System.Windows.Forms.Panel();
            this.lblNomModeImage = new System.Windows.Forms.Label();
            this.lblNetteté = new System.Windows.Forms.Label();
            this.vsiNetteté = new VisualArrays.VisualCells.VisualInt();
            this.lblTeinte = new System.Windows.Forms.Label();
            this.vsiTeinte = new VisualArrays.VisualCells.VisualInt();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.vsiCouleur = new VisualArrays.VisualCells.VisualInt();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContraste = new System.Windows.Forms.Label();
            this.vsiContraste = new VisualArrays.VisualCells.VisualInt();
            this.lblLuminosité = new System.Windows.Forms.Label();
            this.btnModeImageSuivant = new System.Windows.Forms.Button();
            this.btnMémoriser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.panAjustements.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsiLuminosité
            // 
            this.vsiLuminosité.BackColor = System.Drawing.Color.DarkGray;
            this.vsiLuminosité.BorderColor = System.Drawing.Color.Black;
            this.vsiLuminosité.FocusColor = System.Drawing.Color.Gray;
            this.vsiLuminosité.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiLuminosité.ForeColor = System.Drawing.Color.White;
            this.vsiLuminosité.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiLuminosité.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiLuminosité.Location = new System.Drawing.Point(17, 64);
            this.vsiLuminosité.Minimum = 0;
            this.vsiLuminosité.Name = "vsiLuminosité";
            this.vsiLuminosité.Size = new System.Drawing.Size(197, 25);
            this.vsiLuminosité.TabIndex = 3;
            this.vsiLuminosité.TabStop = false;
            this.vsiLuminosité.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // panAjustements
            // 
            this.panAjustements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panAjustements.Controls.Add(this.lblNomModeImage);
            this.panAjustements.Controls.Add(this.lblNetteté);
            this.panAjustements.Controls.Add(this.vsiNetteté);
            this.panAjustements.Controls.Add(this.lblTeinte);
            this.panAjustements.Controls.Add(this.vsiTeinte);
            this.panAjustements.Controls.Add(this.lblCouleur);
            this.panAjustements.Controls.Add(this.vsiCouleur);
            this.panAjustements.Controls.Add(this.label1);
            this.panAjustements.Controls.Add(this.lblContraste);
            this.panAjustements.Controls.Add(this.vsiContraste);
            this.panAjustements.Controls.Add(this.lblLuminosité);
            this.panAjustements.Controls.Add(this.vsiLuminosité);
            this.panAjustements.Location = new System.Drawing.Point(26, 92);
            this.panAjustements.Name = "panAjustements";
            this.panAjustements.Size = new System.Drawing.Size(237, 303);
            this.panAjustements.TabIndex = 1;
            // 
            // lblNomModeImage
            // 
            this.lblNomModeImage.BackColor = System.Drawing.Color.Silver;
            this.lblNomModeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomModeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomModeImage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNomModeImage.Location = new System.Drawing.Point(55, 12);
            this.lblNomModeImage.Name = "lblNomModeImage";
            this.lblNomModeImage.Size = new System.Drawing.Size(159, 25);
            this.lblNomModeImage.TabIndex = 1;
            this.lblNomModeImage.Text = "Sport";
            this.lblNomModeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomModeImage.Click += new System.EventHandler(this.lblNomModeImage_Click);
            // 
            // lblNetteté
            // 
            this.lblNetteté.Location = new System.Drawing.Point(14, 241);
            this.lblNetteté.Name = "lblNetteté";
            this.lblNetteté.Size = new System.Drawing.Size(200, 13);
            this.lblNetteté.TabIndex = 10;
            this.lblNetteté.Text = "&Netteté :";
            // 
            // vsiNetteté
            // 
            this.vsiNetteté.BackColor = System.Drawing.Color.DarkGray;
            this.vsiNetteté.BorderColor = System.Drawing.Color.Black;
            this.vsiNetteté.FocusColor = System.Drawing.Color.Gray;
            this.vsiNetteté.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNetteté.ForeColor = System.Drawing.Color.White;
            this.vsiNetteté.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiNetteté.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiNetteté.Location = new System.Drawing.Point(17, 256);
            this.vsiNetteté.Maximum = 10;
            this.vsiNetteté.Minimum = 0;
            this.vsiNetteté.Name = "vsiNetteté";
            this.vsiNetteté.Size = new System.Drawing.Size(197, 25);
            this.vsiNetteté.TabIndex = 11;
            this.vsiNetteté.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblTeinte
            // 
            this.lblTeinte.Location = new System.Drawing.Point(14, 191);
            this.lblTeinte.Name = "lblTeinte";
            this.lblTeinte.Size = new System.Drawing.Size(200, 13);
            this.lblTeinte.TabIndex = 8;
            this.lblTeinte.Text = "&Teinte :";
            // 
            // vsiTeinte
            // 
            this.vsiTeinte.BackColor = System.Drawing.Color.DarkGray;
            this.vsiTeinte.BorderColor = System.Drawing.Color.Black;
            this.vsiTeinte.FocusColor = System.Drawing.Color.Gray;
            this.vsiTeinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiTeinte.ForeColor = System.Drawing.Color.White;
            this.vsiTeinte.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiTeinte.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiTeinte.Location = new System.Drawing.Point(17, 208);
            this.vsiTeinte.Maximum = 10;
            this.vsiTeinte.Minimum = -10;
            this.vsiTeinte.Name = "vsiTeinte";
            this.vsiTeinte.Size = new System.Drawing.Size(197, 25);
            this.vsiTeinte.TabIndex = 9;
            this.vsiTeinte.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblCouleur
            // 
            this.lblCouleur.Location = new System.Drawing.Point(14, 145);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(200, 13);
            this.lblCouleur.TabIndex = 6;
            this.lblCouleur.Text = "C&ouleur :";
            // 
            // vsiCouleur
            // 
            this.vsiCouleur.BackColor = System.Drawing.Color.DarkGray;
            this.vsiCouleur.BorderColor = System.Drawing.Color.Black;
            this.vsiCouleur.FocusColor = System.Drawing.Color.Gray;
            this.vsiCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiCouleur.ForeColor = System.Drawing.Color.White;
            this.vsiCouleur.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiCouleur.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiCouleur.Location = new System.Drawing.Point(17, 160);
            this.vsiCouleur.Minimum = 0;
            this.vsiCouleur.Name = "vsiCouleur";
            this.vsiCouleur.Size = new System.Drawing.Size(197, 25);
            this.vsiCouleur.TabIndex = 7;
            this.vsiCouleur.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nom :";
            // 
            // lblContraste
            // 
            this.lblContraste.Location = new System.Drawing.Point(14, 96);
            this.lblContraste.Name = "lblContraste";
            this.lblContraste.Size = new System.Drawing.Size(200, 13);
            this.lblContraste.TabIndex = 4;
            this.lblContraste.Text = "&Constraste :";
            // 
            // vsiContraste
            // 
            this.vsiContraste.BackColor = System.Drawing.Color.DarkGray;
            this.vsiContraste.BorderColor = System.Drawing.Color.Black;
            this.vsiContraste.FocusColor = System.Drawing.Color.Gray;
            this.vsiContraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiContraste.ForeColor = System.Drawing.Color.White;
            this.vsiContraste.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiContraste.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiContraste.Location = new System.Drawing.Point(17, 112);
            this.vsiContraste.Minimum = 0;
            this.vsiContraste.Name = "vsiContraste";
            this.vsiContraste.Size = new System.Drawing.Size(197, 25);
            this.vsiContraste.TabIndex = 5;
            this.vsiContraste.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblLuminosité
            // 
            this.lblLuminosité.Location = new System.Drawing.Point(14, 48);
            this.lblLuminosité.Name = "lblLuminosité";
            this.lblLuminosité.Size = new System.Drawing.Size(200, 13);
            this.lblLuminosité.TabIndex = 2;
            this.lblLuminosité.Text = "&Luminosité :";
            // 
            // btnModeImageSuivant
            // 
            this.btnModeImageSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeImageSuivant.Location = new System.Drawing.Point(26, 42);
            this.btnModeImageSuivant.Name = "btnModeImageSuivant";
            this.btnModeImageSuivant.Size = new System.Drawing.Size(237, 35);
            this.btnModeImageSuivant.TabIndex = 0;
            this.btnModeImageSuivant.Text = "Mode image suivant";
            this.btnModeImageSuivant.UseVisualStyleBackColor = true;
            this.btnModeImageSuivant.Click += new System.EventHandler(this.BtnModeImageSuivant_Click);
            // 
            // btnMémoriser
            // 
            this.btnMémoriser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMémoriser.Location = new System.Drawing.Point(26, 412);
            this.btnMémoriser.Name = "btnMémoriser";
            this.btnMémoriser.Size = new System.Drawing.Size(237, 35);
            this.btnMémoriser.TabIndex = 2;
            this.btnMémoriser.Text = "Mémoriser les ajustements";
            this.btnMémoriser.UseVisualStyleBackColor = true;
            this.btnMémoriser.Click += new System.EventHandler(this.BtnMémoriser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnModeImageSuivant;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 468);
            this.Controls.Add(this.btnMémoriser);
            this.Controls.Add(this.btnModeImageSuivant);
            this.Controls.Add(this.panAjustements);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeImage (Matériel)";
            this.panAjustements.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public System.Windows.Forms.Panel panAjustements;
        public System.Windows.Forms.Button btnModeImageSuivant;
        public System.Windows.Forms.Button btnMémoriser;
        public VisualArrays.VisualCells.VisualInt vsiLuminosité;
        public System.Windows.Forms.Label lblLuminosité;
        public System.Windows.Forms.Label lblContraste;
        public VisualArrays.VisualCells.VisualInt vsiContraste;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTeinte;
        public VisualArrays.VisualCells.VisualInt vsiTeinte;
        public System.Windows.Forms.Label lblCouleur;
        public VisualArrays.VisualCells.VisualInt vsiCouleur;
        public VisualArrays.VisualCells.VisualInt vsiNetteté;
        public System.Windows.Forms.Label lblNomModeImage;
        public System.Windows.Forms.Label lblNetteté;
    }
}

