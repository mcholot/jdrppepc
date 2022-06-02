
namespace formjdrppe
{
    partial class connexion
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
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Modif_Valid_IP = new System.Windows.Forms.Button();
            this.Button_Annule_Modif = new System.Windows.Forms.Button();
            this.TextBox_Adresse_serveur = new System.Windows.Forms.TextBox();
            this.Button_Defaut_Adresse = new System.Windows.Forms.Button();
            this.Panel_Haut = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Bas = new System.Windows.Forms.Panel();
            this.Button_User = new System.Windows.Forms.Button();
            this.Button_Admin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Button_Connexion = new System.Windows.Forms.Button();
            this.Panel_Haut.SuspendLayout();
            this.Panel_Bas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresse serveur :";
            // 
            // Button_Modif_Valid_IP
            // 
            this.Button_Modif_Valid_IP.BackColor = System.Drawing.Color.Gray;
            this.Button_Modif_Valid_IP.Location = new System.Drawing.Point(514, 221);
            this.Button_Modif_Valid_IP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Modif_Valid_IP.Name = "Button_Modif_Valid_IP";
            this.Button_Modif_Valid_IP.Size = new System.Drawing.Size(81, 34);
            this.Button_Modif_Valid_IP.TabIndex = 10;
            this.Button_Modif_Valid_IP.Text = "Modifier";
            this.Button_Modif_Valid_IP.UseVisualStyleBackColor = false;
            this.Button_Modif_Valid_IP.Click += new System.EventHandler(this.Button_Modif_Valid_IP_Click);
            // 
            // Button_Annule_Modif
            // 
            this.Button_Annule_Modif.BackColor = System.Drawing.Color.Gray;
            this.Button_Annule_Modif.Location = new System.Drawing.Point(514, 265);
            this.Button_Annule_Modif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Annule_Modif.Name = "Button_Annule_Modif";
            this.Button_Annule_Modif.Size = new System.Drawing.Size(81, 30);
            this.Button_Annule_Modif.TabIndex = 11;
            this.Button_Annule_Modif.Text = "Annuler modif";
            this.Button_Annule_Modif.UseVisualStyleBackColor = false;
            this.Button_Annule_Modif.Visible = false;
            this.Button_Annule_Modif.Click += new System.EventHandler(this.Button_Annule_Modif_Click);
            // 
            // TextBox_Adresse_serveur
            // 
            this.TextBox_Adresse_serveur.Enabled = false;
            this.TextBox_Adresse_serveur.Location = new System.Drawing.Point(304, 224);
            this.TextBox_Adresse_serveur.Name = "TextBox_Adresse_serveur";
            this.TextBox_Adresse_serveur.Size = new System.Drawing.Size(197, 26);
            this.TextBox_Adresse_serveur.TabIndex = 12;
            this.TextBox_Adresse_serveur.Text = "http://127.0.0.1:8080/";
            // 
            // Button_Defaut_Adresse
            // 
            this.Button_Defaut_Adresse.BackColor = System.Drawing.Color.Gray;
            this.Button_Defaut_Adresse.Location = new System.Drawing.Point(514, 303);
            this.Button_Defaut_Adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Defaut_Adresse.Name = "Button_Defaut_Adresse";
            this.Button_Defaut_Adresse.Size = new System.Drawing.Size(81, 30);
            this.Button_Defaut_Adresse.TabIndex = 13;
            this.Button_Defaut_Adresse.Text = "Défaut";
            this.Button_Defaut_Adresse.UseVisualStyleBackColor = false;
            this.Button_Defaut_Adresse.Visible = false;
            this.Button_Defaut_Adresse.Click += new System.EventHandler(this.Button_Defaut_Adresse_Click);
            // 
            // Panel_Haut
            // 
            this.Panel_Haut.Controls.Add(this.textBoxPass);
            this.Panel_Haut.Controls.Add(this.textBoxPseudo);
            this.Panel_Haut.Controls.Add(this.label2);
            this.Panel_Haut.Controls.Add(this.label1);
            this.Panel_Haut.Location = new System.Drawing.Point(173, 29);
            this.Panel_Haut.Name = "Panel_Haut";
            this.Panel_Haut.Size = new System.Drawing.Size(328, 165);
            this.Panel_Haut.TabIndex = 14;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(15, 111);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(292, 26);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(15, 34);
            this.textBoxPseudo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(292, 26);
            this.textBoxPseudo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pseudo";
            // 
            // Panel_Bas
            // 
            this.Panel_Bas.Controls.Add(this.Button_User);
            this.Panel_Bas.Controls.Add(this.Button_Admin);
            this.Panel_Bas.Controls.Add(this.linkLabel1);
            this.Panel_Bas.Controls.Add(this.Button_Connexion);
            this.Panel_Bas.Location = new System.Drawing.Point(173, 267);
            this.Panel_Bas.Name = "Panel_Bas";
            this.Panel_Bas.Size = new System.Drawing.Size(328, 162);
            this.Panel_Bas.TabIndex = 15;
            // 
            // Button_User
            // 
            this.Button_User.BackColor = System.Drawing.Color.Gray;
            this.Button_User.Location = new System.Drawing.Point(177, 73);
            this.Button_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_User.Name = "Button_User";
            this.Button_User.Size = new System.Drawing.Size(134, 49);
            this.Button_User.TabIndex = 11;
            this.Button_User.Text = "user";
            this.Button_User.UseVisualStyleBackColor = false;
            this.Button_User.Click += new System.EventHandler(this.Button_User_Click);
            // 
            // Button_Admin
            // 
            this.Button_Admin.BackColor = System.Drawing.Color.Gray;
            this.Button_Admin.Location = new System.Drawing.Point(19, 73);
            this.Button_Admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Admin.Name = "Button_Admin";
            this.Button_Admin.Size = new System.Drawing.Size(150, 49);
            this.Button_Admin.TabIndex = 10;
            this.Button_Admin.Text = "Admin";
            this.Button_Admin.UseVisualStyleBackColor = false;
            this.Button_Admin.Click += new System.EventHandler(this.Button_Admin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(127, 127);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inscription";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Button_Connexion
            // 
            this.Button_Connexion.BackColor = System.Drawing.Color.Gray;
            this.Button_Connexion.Location = new System.Drawing.Point(19, 20);
            this.Button_Connexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Connexion.Name = "Button_Connexion";
            this.Button_Connexion.Size = new System.Drawing.Size(292, 49);
            this.Button_Connexion.TabIndex = 8;
            this.Button_Connexion.Text = "Connexion";
            this.Button_Connexion.UseVisualStyleBackColor = false;
            this.Button_Connexion.Click += new System.EventHandler(this.Button_Connexion_Click);
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Panel_Bas);
            this.Controls.Add(this.Panel_Haut);
            this.Controls.Add(this.Button_Defaut_Adresse);
            this.Controls.Add(this.TextBox_Adresse_serveur);
            this.Controls.Add(this.Button_Annule_Modif);
            this.Controls.Add(this.Button_Modif_Valid_IP);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "connexion";
            this.Load += new System.EventHandler(this.connexion_Load);
            this.Panel_Haut.ResumeLayout(false);
            this.Panel_Haut.PerformLayout();
            this.Panel_Bas.ResumeLayout(false);
            this.Panel_Bas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Modif_Valid_IP;
        private System.Windows.Forms.Button Button_Annule_Modif;
        private System.Windows.Forms.TextBox TextBox_Adresse_serveur;
        private System.Windows.Forms.Button Button_Defaut_Adresse;
        private System.Windows.Forms.Panel Panel_Haut;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Bas;
        private System.Windows.Forms.Button Button_User;
        private System.Windows.Forms.Button Button_Admin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Button_Connexion;
    }
}