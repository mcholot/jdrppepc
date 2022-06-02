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
    public partial class ListeJoueur : Form
    {
       

        private CurrencyManager currencyManager = null;
        public ListeJoueur()
        {
            InitializeComponent();
        }


        public static List<Users> allUsers = new List<Users>();
        private async void ListeJoueur_Load(object sender, EventArgs e)
        {
            if (allUsers.Count == 0)
            {
                //object[] response = await api.getAllAsync("/users");
                string response = await api.getAllAsync("/users");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                allUsers = JSserializer.Deserialize<List<Users>>(response);
                
            }
                dataGridUser.DataSource = allUsers;
                dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dataGridUser.AllowUserToOrderColumns = true;
                dataGridUser.AllowUserToResizeColumns = true;
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
