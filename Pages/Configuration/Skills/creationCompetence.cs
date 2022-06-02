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
    public partial class creationCompetence : Form
    {
        public creationCompetence()
        {
            InitializeComponent();
        }

        private void creationCompetence_Load(object sender, EventArgs e)
        {
           

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string Name = textBoxNom.Text;

            string Stat = comboBox1.SelectedItem.ToString();

            CreateSkills classe = new CreateSkills(Name, Stat);

            string response = await api.CreateAsync("skills", classe);

            MessageBox.Show(response);


            this.Close();
        }
    }
    
}
