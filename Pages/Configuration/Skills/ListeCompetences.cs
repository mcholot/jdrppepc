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
    public partial class ListeCompetences : Form
    {
        public static List<Skills> List = new List<Skills>();
        public ListeCompetences()
        {
            InitializeComponent();
        }

        private async void ListeCompetences_Load(object sender, EventArgs e)
        {
            if (List.Count == 0)
            {
                string response = await api.getAllAsync("/skills");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                List = JSserializer.Deserialize<List<Skills>>(response);

            }

            
            dataGridView1.DataSource = List;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
        }

        
        
    }
}
