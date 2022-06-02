using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formjdrppe
{
    public partial class home : Form
    {

        public static chat chatFen;
        public home()
        {
            InitializeComponent();
        }


        private void home_Load(object sender, EventArgs e)
        {
            connexion fenetreConnexion = new connexion();
            fenetreConnexion.ShowDialog();
            if (global.ACCES_PROGRAMME == false)
            {
                this.Close();
            }
            if(global.isAdmin == false)
            {
                joueursToolStripMenuItem.Visible = false;
                nouvellePartieToolStripMenuItem.Visible = false;
                afficherLesPartiesToolStripMenuItem.Visible = false;
                configurationToolStripMenuItem.Visible = false;
                afficherTousLesPersonnagesToolStripMenuItem.Visible = false;
            }
            else
            {
                mesPersonnagesToolStripMenuItem.Visible = false;
                partieEnCoursToolStripMenuItem.Visible = false;
            }

        }

        private Form activeForm = null;
        public void childFen(Form child)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = child;
            child.MdiParent = this;
            //child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            //panelParent.Visible = true;
            panelParent.Controls.Add(child);
            //panelParent.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (global.isAdmin == true) 
            { 
                creationPerso nouveauPerso = new creationPerso();
                nouveauPerso.ShowDialog();
            }
            else
            {
                creationPersonnageJoueur persoJoueur = new creationPersonnageJoueur();
                persoJoueur.ShowDialog();
            }
        }

        

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creationPartie nouvellePartie = new creationPartie();
            nouvellePartie.ShowDialog();
        }

        private void afficherTousLesPersonnagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListePerso Persos = new ListePerso();
            childFen(Persos);
        }

        private void afficherTousLesJoueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeJoueur joueur = new ListeJoueur();
            childFen(joueur);
        }

        private void afficherLesPartiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListePartie partie = new ListePartie();
            childFen(partie);
        }

        private void nouvelleClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creationClasse classe = new creationClasse();
            classe.ShowDialog();
        }

        private void nouvelleRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creationRace race = new creationRace();
            race.ShowDialog();
        }

        private void nouvelleCompétenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creationCompetence comp = new creationCompetence();
            comp.ShowDialog();
        }

        

        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partieEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partieEnCours rare = new partieEnCours();
            childFen(rare);
        }

        private void mesPersonnagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mesPerso Persos = new mesPerso();
            childFen(Persos);
        }

        private void personnageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            creationJoueur joueur = new creationJoueur();
            joueur.ShowDialog();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chatFen = new chat();
            chatFen.ShowDialog();
        }

        private void nouvelObjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creationObjets obj = new creationObjets();
            obj.ShowDialog();
        }

        private async void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (global.ACCES_PROGRAMME == true)
            {
                await api.LogoutAsync();

            }
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log log = new log();
            childFen(log);
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClasse fen = new ListeClasse();
            childFen(fen);
        }

        private void listesDesRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeRace fen = new ListeRace();
            childFen(fen);
        }

        private void listeDesObjetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeObjets fen = new ListeObjets();
            childFen(fen);
        }

        private void listeCompétencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeCompetences fen = new ListeCompetences();
            childFen(fen);
        }
    }
}
