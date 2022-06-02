using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formjdrppe
{

    public partial class creationPersonnageJoueur : Form
    {
       

        private int bonusTotal = 10;
        private static int bonusTotalBase = 10;
        private int bonusPv = 0;
        private int bonusIni = 0;
        private int bonusForce = 0;
        private int bonusAgi = 0;
        private int bonusIntel = 0;
        private int bonusSocial = 0;
        private int bonusCac = 0;
        private int bonusAD = 0;
        private int bonusDef = 0;
        private static Dictionary<string, string> dictImage= new Dictionary<string, string>();

        public creationPersonnageJoueur()
        {
            InitializeComponent();
        }

        private void creationPersonnageJoueur_Load(object sender, EventArgs e)
        {

            //refreshStat();
            
            //DirectoryInfo dir = new DirectoryInfo(@".\\images");
            //FileInfo[] imageFiles = dir.GetFiles("*.jpg");
            //ImageList imageList1 = new ImageList();
            //foreach (FileInfo f in imageFiles)
            //{
            //    imageList1.Images.Add(Image.FromFile(f.FullName));


            //    string name = f.Name.Replace(".jpg", "");
            //    dictImage[f.FullName] = name;
            //    listeImage.DataSource = new BindingSource(dictImage, null);
            //    listeImage.DisplayMember = "Value";
            //    listeImage.ValueMember = "Key";

            //}


            //pictureBox.Image = imageList1.Images[0];


        }

        private void BonusTextBox()
        {
            
            textBoxBonusTotal.Text = bonusTotal.ToString();
            textBoxBonusPv.Text =  bonusPv.ToString();
            textBoxBonusIni.Text = bonusIni.ToString();
            textBoxBonusForce.Text = bonusForce.ToString();
            textBoxBonusAgi.Text = bonusAgi.ToString();
            textBoxBonusIntel.Text = bonusIntel.ToString();
            textBoxBonusSocial.Text = bonusSocial.ToString();
            textBoxBonusCac.Text = bonusCac.ToString();
            textBoxBonusAd.Text = bonusAD.ToString();
            textBoxBonusDef.Text = bonusDef.ToString();
        }

        private void StatTextBox()
        {
            //textBoxStatPv.Text = pers.pv.ToString();
            //textBoxStatIni.Text = pers.initiative.ToString();
            //textBoxStatForce.Text = pers.force.ToString();
            //textBoxStatAgi.Text = pers.agilite.ToString();
            //textBoxStatIntel.Text = pers.intelligence.ToString();
            //textBoxStatSocial.Text = pers.social.ToString();
            //textBoxStatCac.Text = pers.dgt_cc.ToString();
            //textBoxStatAd.Text = pers.dgt_ad.ToString();
            //textBoxStatDef.Text = pers.def.ToString();
        }
        private void Stats()
        {
            int raceId = Convert.ToInt32(comboBoxRace.SelectedValue);
            int classeId = Convert.ToInt32(comboBoxClasse.SelectedValue);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (bonusTotal == 0 && textBoxNom.Text != "")
            //{

            //    basejdrDataContext db = new basejdrDataContext();


            //    pers.nom = textBoxNom.Text;

            //    pers.niveau = 1;

            //    pers.txt_long = "";

            //    pers.img = "";

            //    pers.id_joueur = global.idJoueurConnecte;

            //    pers.id_class = Convert.ToInt32(comboBoxClasse.SelectedValue);

            //    pers.id_race = Convert.ToInt32(comboBoxRace.SelectedValue);

            //    pers.pnj = false;

            //    pers.img = ((KeyValuePair<string, string>)listeImage.SelectedItem).Key;




            //    Stats();

            //    db.PERSONNAGE.InsertOnSubmit(pers);
            //    try
            //    {
            //        db.SubmitChanges();
            //    }
            //    catch (Exception err)
            //    {
            //        Console.WriteLine(err);
            //        // Make some adjustments.
            //        // ...
            //        // Try again.
            //        db.SubmitChanges();
            //    }

            //    this.Close();
            //}
            //else
            //{
            //    if (bonusTotal != 0)
            //    {
            //        MessageBox.Show("Dépensez tous vos points dans les bonus");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Votre personnage se nomme personne ? Pensez à vous donner un nom !");
            //    }
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshStat();
        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshStat();
        }

        private int compteurPlus(int stat )
        {
            if(bonusTotal > 0 && stat < 5)
            {
                bonusTotal -= 1;
                
                return 1;
                
            }
            return 0;
            
        }
        private int compteurMoins(int stat)
        {
            if(bonusTotal < bonusTotalBase && stat > 0)
            {
                bonusTotal += 1;

                return 1;
            }
            return 0;

        }

        private void refreshStat()
        {
            Stats();
            BonusTextBox();
            StatTextBox();
        }

        private void buttonPlusPv_Click(object sender, EventArgs e)
        {
            bonusPv += compteurPlus(bonusPv);
            refreshStat();
        }
        private void buttonPlusIni_Click(object sender, EventArgs e)
        {
            bonusIni += compteurPlus(bonusIni);
            refreshStat();
        }

        private void buttonPlusForce_Click(object sender, EventArgs e)
        {
            bonusForce += compteurPlus(bonusForce);
            refreshStat();
        }

        private void buttonPlusAgi_Click(object sender, EventArgs e)
        {
            bonusAgi += compteurPlus(bonusAgi);
            refreshStat();
        }

        private void buttonPlusIntel_Click(object sender, EventArgs e)
        {
            bonusIntel += compteurPlus(bonusIntel);
            refreshStat();
        }

        private void buttonPlusSoc_Click(object sender, EventArgs e)
        {
            bonusSocial += compteurPlus(bonusSocial);
            refreshStat();
        }

        private void buttonPlusCac_Click(object sender, EventArgs e)
        {
            bonusCac += compteurPlus(bonusCac);
            refreshStat();
        }

        private void buttonPlusAd_Click(object sender, EventArgs e)
        {
            bonusAD += compteurPlus(bonusAD);
            refreshStat();
        }

        private void buttonPlusDef_Click(object sender, EventArgs e)
        {
            bonusDef += compteurPlus(bonusDef);
            refreshStat();
        }

        private void buttonMoinsPv_Click(object sender, EventArgs e)
        {
            bonusPv -= compteurMoins(bonusPv);
            refreshStat();
        }

        private void buttonMoinsIni_Click(object sender, EventArgs e)
        {

            bonusIni -= compteurMoins(bonusIni);
            refreshStat();
        }

        private void buttonMoinsForce_Click(object sender, EventArgs e)
        {
            bonusForce -= compteurMoins(bonusForce);
            refreshStat();
        }

        private void buttonMoinsAgi_Click(object sender, EventArgs e)
        {
            bonusAgi -= compteurMoins(bonusAgi);
            refreshStat();
        }

        private void buttonMoinsIntel_Click(object sender, EventArgs e)
        {
            bonusIntel -= compteurMoins(bonusIntel);
            refreshStat();
        }

        private void buttonMoinsSoc_Click(object sender, EventArgs e)
        {
            bonusSocial -= compteurMoins(bonusSocial);
            refreshStat();
        }

        private void buttonMoinsCac_Click(object sender, EventArgs e)
        {
            bonusCac -= compteurMoins(bonusCac);
            refreshStat();
        }

        private void buttonMoinsAd_Click(object sender, EventArgs e)
        {
            bonusAD -= compteurMoins(bonusAD);
            refreshStat();
        }

        private void buttonMoinsDef_Click(object sender, EventArgs e)
        {
            bonusDef -= compteurMoins(bonusDef);
            refreshStat();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void listeImage_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void listeImage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selected = ((KeyValuePair<string, string>)listeImage.SelectedItem).Key;

            pictureBox.Image = Image.FromFile(selected);
        }
    }
}
