using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace formjdrppe
{
    public partial class creationPartie : Form
    {
        public static Dictionary<int, string> joueur = new Dictionary<int, string>();
        public static List<int> idJoueursEquipe = new List<int>();
        public Dictionary<int, string> dict_perso = new Dictionary<int, string>();
        public static List<object> checkedItems = new List<object>();
        public creationPartie()
        {
            InitializeComponent();
        }

        private void creationPartie_Load(object sender, EventArgs e)
        {
            getPlayers();


        }

        private async void getPlayers()
        {
            if (joueur.Count == 0)
            {
                string response = await api.getAllAsync("/users");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                List<Users> allUsers = JSserializer.Deserialize<List<Users>>(response);


                foreach (Users user in allUsers)
                {
                    //Users users = JsonConvert.DeserializeObject<Users>(obj.ToString());
                    joueur.Add(user.Id, user.Username);

                }
            }
            listeJoueur.DataSource = joueur.ToList();
            listeJoueur.DisplayMember = "Value";
            listeJoueur.ValueMember = "Key";
        }

        private async void remplirEquipe()
        {

            int label = 1;
            foreach (KeyValuePair<int,string> selectPlayer in checkedItems)
            {
                recherche_Combobox_index(label).DataSource = null;
                recherche_Combobox_index(label).Items.Clear();
                
                var idPlayer = selectPlayer.Key;
                idJoueursEquipe.Add(idPlayer);
                J(label).Text = selectPlayer.Value;
                label++;
            }

            


          

            int i = 1;
            foreach (int joueurid in idJoueursEquipe)
            {
              
                dict_perso.Clear();
                
                Dictionary<int, string> dictChara = new Dictionary<int, string>();
                string response = await api.getAllAsync("/Usercharacter/" + joueurid);
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                List<Characters> characters = JSserializer.Deserialize<List<Characters>>(response);

                if (characters.Count == 0)
                {
                    Characters singleCharacter = JSserializer.Deserialize<Characters>(response);

                    characters.Add(singleCharacter);
                }

                foreach (Characters character in characters)
                {
                    //Characters chara = JsonConvert.DeserializeObject<Characters>(character.ToString());

                    dict_perso.Add(character.Id, character.Name);

                    //listeJoueur.DataSource = perso.ToList();
                    //listeJoueur.DisplayMember = "Value";
                    //listeJoueur.ValueMember = "Key";


                }

                

                recherche_Combobox_index((i)).DataSource = dict_perso.ToList();
                recherche_Combobox_index((i)).DisplayMember = "Value";
                recherche_Combobox_index((i)).ValueMember = "Key";


                //using (var cnx = new basejdrDataContext())
                //{
                //    var requeteLinq = from table in cnx.ViewPersoPseudo
                //                      where table.pseudo == p
                //                      select table;
                //   

                //}
                i++;
            }


        }

        private void persoChoisi()
        {
            listBoxPerso.Items.Clear();
            for (int i = 1; i <= 6; i++)
            {
                if (recherche_Combobox_index(i).SelectedIndex != -1)
                {

                    listBoxPerso.Items.Add(recherche_Combobox_index(i).SelectedItem);
                }
            }
        }
        
        

        private void listeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {

            //remplirEquipe();
        }

        private System.Windows.Forms.ComboBox recherche_Combobox_index(int index )
        {

            return recherche_Combobox("comboBoxJ" + index);

        }


        private System.Windows.Forms.ComboBox recherche_Combobox(string nom) 
        {
           
            foreach(Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    if (c.Name == nom)
                    {
                        return (ComboBox)c;
                    }
                }
                
            }
            return null;
            
        }

        private System.Windows.Forms.Label pseudoJoueur(string nom)
        {
            
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if (c.Name == nom)
                    {
                        return (Label)c;
                    }
                }
            }
            return null;

        }
        private System.Windows.Forms.Label J(int index)
        {

            return pseudoJoueur("J" + index);

        }

       


        //BOUTON CREATION / VALIDATION
        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }
















        private void comboBoxJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }
        private void comboBoxJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ3_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ4_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ5_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ6_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void listeJoueur_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            idJoueursEquipe.Clear();


            //foreach (var selectPlayer in listeJoueur.CheckedItems)
                //idJoueursEquipe.Add(selectPlayer.Key);
                //checkedItems.Add(selectPlayer);
            var i = e.Index;
            
            if (e.NewValue == CheckState.Checked)
            {
                if (!checkedItems.Contains(listeJoueur.Items[e.Index]))
                {
                    checkedItems.Add(listeJoueur.Items[e.Index]);
                }
                
            }

            else
            {
                checkedItems.Remove(listeJoueur.Items[e.Index]);
                
            }

            for (int id = 1; id <= 6; id++)
            {


                recherche_Combobox_index(id).DataSource = null;
                recherche_Combobox_index(id).Items.Clear();
                J(id).Text = "";


            }

            remplirEquipe();


            //foreach (KeyValuePair<int, string> selectPlayer in listeJoueur.CheckedItems)
            //{
            //    if (!idJoueursEquipe.Contains(selectPlayer.Key))
            //    {
            //        idJoueursEquipe.Add(selectPlayer.Key);
            //    }
            //}


        }
    }
    
}
