namespace parking
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fICHIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOUVEAUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAUVEGARDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oUTILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fICHIERToolStripMenuItem,
            this.eDITIONToolStripMenuItem,
            this.oUTILSToolStripMenuItem,
            this.aIDEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fICHIERToolStripMenuItem
            // 
            this.fICHIERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOUVEAUToolStripMenuItem,
            this.sAUVEGARDERToolStripMenuItem,
            this.connexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fICHIERToolStripMenuItem.Name = "fICHIERToolStripMenuItem";
            this.fICHIERToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fICHIERToolStripMenuItem.Text = "FICHIER";
            // 
            // nOUVEAUToolStripMenuItem
            // 
            this.nOUVEAUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkerToolStripMenuItem,
            this.vehiculeToolStripMenuItem,
            this.proprietaireToolStripMenuItem,
            this.rayonToolStripMenuItem,
            this.utilisateurToolStripMenuItem});
            this.nOUVEAUToolStripMenuItem.Name = "nOUVEAUToolStripMenuItem";
            this.nOUVEAUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOUVEAUToolStripMenuItem.Text = "nouveau";
            this.nOUVEAUToolStripMenuItem.Click += new System.EventHandler(this.nOUVEAUToolStripMenuItem_Click);
            // 
            // parkerToolStripMenuItem
            // 
            this.parkerToolStripMenuItem.Name = "parkerToolStripMenuItem";
            this.parkerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.parkerToolStripMenuItem.Text = "historique";
            this.parkerToolStripMenuItem.Click += new System.EventHandler(this.parkerToolStripMenuItem_Click_1);
            // 
            // vehiculeToolStripMenuItem
            // 
            this.vehiculeToolStripMenuItem.Name = "vehiculeToolStripMenuItem";
            this.vehiculeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.vehiculeToolStripMenuItem.Text = "enregistrer un bus";
            this.vehiculeToolStripMenuItem.Click += new System.EventHandler(this.vehiculeToolStripMenuItem_Click);
            // 
            // proprietaireToolStripMenuItem
            // 
            this.proprietaireToolStripMenuItem.Name = "proprietaireToolStripMenuItem";
            this.proprietaireToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.proprietaireToolStripMenuItem.Text = "enregistrer un chauffeur";
            this.proprietaireToolStripMenuItem.Click += new System.EventHandler(this.proprietaireToolStripMenuItem_Click_1);
            // 
            // rayonToolStripMenuItem
            // 
            this.rayonToolStripMenuItem.Name = "rayonToolStripMenuItem";
            this.rayonToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.rayonToolStripMenuItem.Text = "enregistrer un depart";
            this.rayonToolStripMenuItem.Click += new System.EventHandler(this.rayonToolStripMenuItem_Click_1);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.utilisateurToolStripMenuItem.Text = "enregistrer un client";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // sAUVEGARDERToolStripMenuItem
            // 
            this.sAUVEGARDERToolStripMenuItem.Name = "sAUVEGARDERToolStripMenuItem";
            this.sAUVEGARDERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sAUVEGARDERToolStripMenuItem.Text = "sauvegarder";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connexionToolStripMenuItem.Text = "connexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "quitter";
            // 
            // eDITIONToolStripMenuItem
            // 
            this.eDITIONToolStripMenuItem.Name = "eDITIONToolStripMenuItem";
            this.eDITIONToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.eDITIONToolStripMenuItem.Text = "EDITION";
            // 
            // oUTILSToolStripMenuItem
            // 
            this.oUTILSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametreToolStripMenuItem});
            this.oUTILSToolStripMenuItem.Name = "oUTILSToolStripMenuItem";
            this.oUTILSToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.oUTILSToolStripMenuItem.Text = "OUTILS";
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.parametreToolStripMenuItem.Text = "parametre";
            this.parametreToolStripMenuItem.Click += new System.EventHandler(this.parametreToolStripMenuItem_Click);
            // 
            // aIDEToolStripMenuItem
            // 
            this.aIDEToolStripMenuItem.Name = "aIDEToolStripMenuItem";
            this.aIDEToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aIDEToolStripMenuItem.Text = "AIDE";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::parking.Properties.Resources.clé;
            this.button1.Location = new System.Drawing.Point(-10, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 393);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(401, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "FORMULAIRE PRINCIPALE";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fICHIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOUVEAUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAUVEGARDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oUTILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIDEToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem parkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}