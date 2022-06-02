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
    public partial class partieEnCours : Form
    {
        public partieEnCours()
        {
            InitializeComponent();
        }

        private void partieEnCours_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.View_Partie_Perso'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //int idJoueur = global.idJoueurConnecte;

            //if(global.isAdmin == true)
            //{
            //    this.view_Partie_PersoTableAdapter2.Fill(this.dataSet1.View_Partie_Perso);
            //}
            //else
            //{
            //    this.view_Partie_PersoTableAdapter2.FillBy(this.dataSet1.View_Partie_Perso, idJoueur);

            //}



            //basejdrDataContext db = new basejdrDataContext();

            // var q = from p in db.View_Partie_Perso

            //   where p.id_joueur == global.idJoueurConnecte

            //  select p;


            // foreach(View_Partie_Perso partie in q)
            // {
            //     dataGridView1.Rows.Add(partie.nom,partie.Expr1);
            // }
        }

        
    }
}
