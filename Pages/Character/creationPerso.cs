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
    public partial class creationPerso : Form
    {

        public creationPerso()
        {
            InitializeComponent();
        }

        private void creationPerso_Load(object sender, EventArgs e)
        {
            
            competences();
            objets();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creationJoueur nouveauJoueur = new creationJoueur();
            nouveauJoueur.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void competences()
        {
            //using (var cnx = new basejdrDataContext())
            //{
            //    var req = from table in cnx.COMPETENCE
            //            select table;

            //    foreach (COMPETENCE comp in req)
            //    {
            //        checkedListCompetence.Items.Add(comp.nom);
            //    }
            //}
        }


        private void objets()
        {
            //using (var cnx = new basejdrDataContext())
            //{
            //    var req = from table in cnx.OBJET
            //              select table;

            //    foreach (OBJET obj in req)
            //    {
            //        checkedListObjet.Items.Add(obj.nom);
            //    }
            //}
        }
        private void Stats()
        {
            int raceId = Convert.ToInt32(comboBoxRace.SelectedValue);
            int classeId = Convert.ToInt32(comboBoxClasse.SelectedValue);
            
               
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           



            //basejdrDataContext db = new basejdrDataContext();
            // this.pers = new PERSONNAGE
            //{
                

            //    nom = textBoxNom.Text,

            //    niveau = Convert.ToInt32(maskedTextBoxNiveau.Text),

            //    txt_long = "",

            //    dgt_cc = Convert.ToInt32(maskedTextBoxDgtCc.Text),

            //    dgt_ad = Convert.ToInt32(maskedTextBoxDgtAd.Text),

            //    def = Convert.ToInt32(maskedTextBoxDef.Text),

            //    img = "",

            //    id_joueur = Convert.ToInt32(comboBoxJoueur.SelectedValue),

            //    id_class = Convert.ToInt32(comboBoxClasse.SelectedValue),

            //    id_race = Convert.ToInt32(comboBoxRace.SelectedValue),

                
            //};

            //Stats();

            //db.PERSONNAGE.InsertOnSubmit(pers);
            //try
            //{
            //    db.SubmitChanges();
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err);
            //    // Make some adjustments.
            //    // ...
            //    // Try again.
            //    db.SubmitChanges();
            //}

            //this.Close();

        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int stat = Stats().GetValue(0);



           // textBox1.Text = Stats().GetValue(1).ToString();



        }

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = Stats().GetValue(1).ToString();

        }

        
    }
}
