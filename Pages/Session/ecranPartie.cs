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
    public partial class ecranPartie : Form
    {
        int id_p;
        List<ChildPerso> listChild = new List<ChildPerso>();
        public ecranPartie(int id_partie)
        {
            id_p = id_partie;
            InitializeComponent();
        }




        private void ecranPartie_Load(object sender, EventArgs e)
        {
            int i = 1;
            //using (var cnx = new basejdrDataContext())
            //{

            //    int X_fenetre = 0;
            //    var requeteLinq = from table in cnx.PERSO_PARTIE
            //                      where table.id_partie == id_p
            //                      select table;
                
            //    foreach(PERSO_PARTIE perso in requeteLinq)
            //    {
            //        var reqPerso = from table in cnx.View_personnage
            //                          where table.id_perso == perso.id_perso
            //                          select table;


            //        View_personnage personnage = reqPerso.First();

            //        ChildPerso newchild = new ChildPerso(personnage);
            //        listChild.Add(newchild);
            //        //newchild.Left = X_fenetre;
            //        //X_fenetre = X_fenetre + 250;
            //        newchild.MdiParent = this;
            //        //newchild.Show();
            //        newchild.TopLevel = false;
            //        newchild.FormBorderStyle = FormBorderStyle.None;
            //        newchild.Dock = DockStyle.Fill;
            //        recherche_Panel_index(i).Visible = true;
            //        recherche_Panel_index(i).Controls.Add(newchild);
            //        recherche_Panel_index(i).Tag = newchild;
            //        newchild.BringToFront();
            //        newchild.Show();
            //        i++;
            //    }

            //    chat chatChild = new chat();

            //    //listChild.Add(chatChild);
            //    //newchild.Left = X_fenetre;
            //    //X_fenetre = X_fenetre + 250;
            //    chatChild.MdiParent = this;
            //    //newchild.Show();
            //    chatChild.TopLevel = false;
            //    chatChild.FormBorderStyle = FormBorderStyle.None;
            //    chatChild.Dock = DockStyle.Fill;
            //    //recherche_Panel_index(i).Visible = true;
            //    //recherche_Panel_index(i).Controls.Add(chatChild);
            //    //recherche_Panel_index(i).Tag = chatChild;
            //    panelChat.Controls.Add(chatChild);
            //    chatChild.BringToFront();
            //    chatChild.Show();
            //}

            //this.LayoutMdi(MdiLayout.TileHorizontal);   
        }


        private System.Windows.Forms.Panel recherche_Panel(string nom)
        {

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    if (c.Name == nom)
                    {
                        return (Panel)c;
                    }
                }

            }
            return null;

        }

        private System.Windows.Forms.Panel recherche_Panel_index(int index)
        {
            if(index > 0 && index <= 6)
            {
                return recherche_Panel("panel" + index);

            }
            return null;

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
