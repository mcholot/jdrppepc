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
    public partial class ListeObjets : Form
    {
        public ListeObjets()
        {
            InitializeComponent();
        }

        public static List<Items> allItems = new List<Items>();

        private async void ListeObjets_Load(object sender, EventArgs e)
        {
            if (allItems.Count == 0)
            {
                string response = await api.getAllAsync("/items");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                allItems = JSserializer.Deserialize<List<Items>>(response);

            }
            dataGridView2.DataSource = allItems;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = true;
        }
    }
}
