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
    public partial class ListeRace : Form
    {
        public ListeRace()
        {
            InitializeComponent();
        }

        public static List<object> List = new List<object>();
        private async void ListeRace_Load(object sender, EventArgs e)
        {


            if (List.Count == 0)
            {
                string response = await api.getAllAsync("/races");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                List = JSserializer.Deserialize<List<object>>(response);

            }
            
            dataGridView1.DataSource = List;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
        }
    }
}
