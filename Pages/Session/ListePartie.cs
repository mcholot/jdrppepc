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
    public partial class ListePartie : Form
    {
        public ListePartie()
        {
            InitializeComponent();
        }
        public static List<Sessions> List = new List<Sessions>();
        private async void ListePartie_LoadAsync(object sender, EventArgs e)
        {
            if (List.Count == 0)
            {
                string response = await api.getAllAsync("/sessions");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                List = JSserializer.Deserialize<List<Sessions>>(response);

            }

            
            dataGridView1.DataSource = List;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {   
            
            //int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //ecranPartie partie = new ecranPartie(id);
            //partie.ShowDialog();
            
        }
    }
}
