using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formjdrppe
{
    public partial class connexion : Form
    {

        bool mode_modif = false;
        public connexion()
        {
            InitializeComponent();
        }

        private void connexion_Load(object sender, EventArgs e)
        {

            Panel_Haut.Enabled = true;
            Panel_Bas.Enabled = true;
            Lecture_Fichier_Adresse_serveur();

            //if (api.client!=null)
            //{}
                //Button_Modif_Valid_IP.Visible = false;
            
        }


        private async void IsValidUser(string userName, string password)
        {
            // api Login 
            
            

        }

        
        //private async void Log_et_delog(string username, string password)
        //{

        //    this.Cursor = System.Windows.Forms.Cursors.AppStarting;
        //    UserLogin userlogin = new UserLogin(username, password);
        //    Panel_Haut.Enabled = false;
        //    Panel_Bas.Enabled = false;


        //    bool isValidUser = await api.LoginAsync(userlogin);

        //    if (isValidUser == true)
        //    {
                
        //        global.ConnectedUser = await api.GetUserAsync();

        //        if (global.ConnectedUser.admin == true)
        //        {
        //            global.isAdmin = true;
        //        }


        //        if (global.ConnectedUser!=null)
        //        {
        //            var rep = await api.LogoutAsync();

        //            if (rep != null)
        //            {
        //                Login(username, password);

        //            }
        //        }
                
        //    }
        //    else
        //    {
        //        this.Cursor = System.Windows.Forms.Cursors.Default;
        //        Panel_Haut.Enabled = true;
        //        Panel_Bas.Enabled = true;
        //    }           

           

        //}
     
        private async void Login(string username, string password)
        {

            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            UserLogin userlogin = new UserLogin(username, password);
            Panel_Haut.Enabled = false;
            Panel_Bas.Enabled = false;


            try
            {


                bool isValidUser = await api.LoginAsync(userlogin);


                


                if (isValidUser == true)
                {
                    global.ConnectedUser = await api.GetUserAsync();

                    if (global.ConnectedUser.Admin == true)
                    { 
                    global.isAdmin = true;
                    }

                    if (global.ConnectedUser != null)
                    {
                        global.ACCES_PROGRAMME = true;
                        this.Close();
                    }

                }
                else
                {
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    Panel_Haut.Enabled = true;
                    Panel_Bas.Enabled = true;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                this.Cursor = System.Windows.Forms.Cursors.Default;
                Panel_Haut.Enabled = true;
                Panel_Bas.Enabled = true;
            }

        }

        private void Button_Connexion_Click(object sender, EventArgs e)
        {
            

            string username = textBoxPseudo.Text;
            string password = textBoxPass.Text;

            Login(username , password);
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            string username = textBoxPseudo.Text;
            string password = textBoxPass.Text;
            if (e.KeyCode == Keys.Enter) Login(username, password);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creationJoueur nouveauJoueur = new creationJoueur();
            nouveauJoueur.ShowDialog();
        }

        

        private void Button_Admin_Click(object sender, EventArgs e)
        {
            Login("admin", "P@ssword1");
            

        }

        private void Button_User_Click(object sender, EventArgs e)
        {
            //Log_et_delog("User", "P@sword1");
            Login("User", "P@ssword1");
        }

        

             
        // Modifier
        private void Button_Modif_Valid_IP_Click(object sender, EventArgs e)
        {            
            if (mode_modif)
            {
                api.ipApi= TextBox_Adresse_serveur.Text ;
            }

            Affiche_bouton_et_saisie();

        }

        // Annuler
        private void Button_Annule_Modif_Click(object sender, EventArgs e)
        {

            TextBox_Adresse_serveur.Text = api.ipApi;
            Affiche_bouton_et_saisie();
        }

        // remettre par défaut
        private void Button_Defaut_Adresse_Click(object sender, EventArgs e)
        {
            TextBox_Adresse_serveur.Text = api.ipAppiDefaut;
            api.ipApi = api.ipAppiDefaut;
            Affiche_bouton_et_saisie();

        }

        // affichage des bouton et enregistrement fichier
        void Affiche_bouton_et_saisie()
        {
            // inversion du mode
            mode_modif = !mode_modif;
            if (mode_modif == false)
            {
                Ecriture_Fichier_Adresse_serveur();
                Button_Modif_Valid_IP.Text = "Modifier";
                Button_Annule_Modif.Visible = false;
                Button_Defaut_Adresse.Visible = false;
                TextBox_Adresse_serveur.Enabled = false;
                Panel_Haut.Enabled = true;
                Panel_Bas.Enabled = true;

            }
            else
            {
                Button_Modif_Valid_IP.Text = "Valider";
                Button_Annule_Modif.Visible = true;
                Button_Defaut_Adresse.Visible = true;
                TextBox_Adresse_serveur.Enabled = true;
                Panel_Haut.Enabled = false;
                Panel_Bas.Enabled = false;

            }
        }
        // lecture fichier
        private bool Lecture_Fichier_Adresse_serveur()
        {
            // adresse par défaut
            api.ipApi = api.ipAppiDefaut;
            TextBox_Adresse_serveur.Text = api.ipApi;
           

            String ligne = null;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                System.IO.StreamReader flux_fichier = new System.IO.StreamReader("Adresse_serveur.txt");
                //Read the first line of text
                ligne = flux_fichier.ReadLine();
                //Continue to read until you reach end of file
                if (ligne != null)
                {
                    api.ipApi = ligne;
                    TextBox_Adresse_serveur.Text = api.ipApi;
                    
                }
                //close the file
                flux_fichier.Close();



                return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }
        // ecriture fichier
        private bool Ecriture_Fichier_Adresse_serveur()
        {
          

            if (TextBox_Adresse_serveur.Text != "")
            {
                
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    System.IO.StreamWriter flux_fichier = new System.IO.StreamWriter("Adresse_serveur.txt");
                    //Read the first line of text
                    flux_fichier.WriteLine(api.ipApi);

                    flux_fichier.Close();

                    return true;
                }
                catch (Exception e)
                {

                }
            }


            return false;
        }
    }
}
