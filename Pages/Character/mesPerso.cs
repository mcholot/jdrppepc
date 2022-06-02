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
    public partial class mesPerso : Form
    {
        public mesPerso()
        {
            InitializeComponent();
        }

        private void mesPerso_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet2.View_personnage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.view_personnageTableAdapter.FillBy(this.dataSet2.View_personnage, global.idJoueurConnecte);

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //FichePerso ficheperso = new FichePerso(id);

            //ficheperso.ShowDialog();
        }
    }
}
