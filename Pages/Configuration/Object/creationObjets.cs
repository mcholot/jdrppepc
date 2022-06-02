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
    public partial class creationObjets : Form
    {
        public static List<Rarityitems> ListRarity = new List<Rarityitems>();
        public static Dictionary<int, string> listComboBox = new Dictionary<int, string> ();
        private string responseMsg = "";
        public creationObjets()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string Name = textBoxNom.Text;

            string description = textBoxDesc.Text;

            int idRarity = Convert.ToInt32(comboBoxRarity.SelectedValue.ToString());


            CreateItems race = new CreateItems(Name, description, idRarity);



            string response = await api.CreateAsync("items", race);


            responseMsg = response;


            this.Close();
        }

        private void creationObjets_Load(object sender, EventArgs e)
        {
            comboBoxRarityFill();
        }
        //public static List<Skills> List = new List<Skills>();
        private async void comboBoxRarityFill()
        {
            if (ListRarity.Count == 0)
            {
                string response = await api.getAllAsync("/rarity");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                ListRarity = JSserializer.Deserialize<List<Rarityitems>>(response);


            }
            if (ListRarity.Count != 0)
            {
                foreach(Rarityitems rarity in ListRarity)
                {
                    listComboBox.Add(rarity.Id, rarity.Name);
                }
            
                comboBoxRarity.DataSource = listComboBox.ToList();
                comboBoxRarity.DisplayMember = "Value";
                comboBoxRarity.ValueMember = "Key";
            }
            
        }

        private void comboBoxRarity_SelectedValueChanged(object sender, EventArgs e)
        {
            string test = comboBoxRarity.SelectedValue.ToString();

        }

        private void creationObjets_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (responseMsg != "")
            {
                MessageBox.Show(responseMsg);
            }
        }
    }
}
