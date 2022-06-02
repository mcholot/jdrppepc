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
    public partial class creationJoueur : Form
    {
        public creationJoueur()
        {
            InitializeComponent();
        }

        private void creationJoueur_Load(object sender, EventArgs e)
        {

        }

        private async void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPass1.Text == textBoxPass2.Text)
                {
                    string Username = textBoxPseudo.Text;

                    string Firstname = textBoxPrenom.Text;

                    string Lastname = textBoxNom.Text;

                    string Password = textBoxPass1.Text;

                    string response = await api.CreateAsync("auth/signup", new UserCreate(Username, Firstname, Lastname, Password));

                   MessageBox.Show(response);
                    
                    
                    
                    this.Close(); 
                    
                    
                }



                else
                {
                    labelErr.Text = "Les mots de passes sont différents";
                }

            }
            catch (Exception err)
            {
                this.Close();
                MessageBox.Show(err.ToString());
                
            }
            

            
        }
    }
}
