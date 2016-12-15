using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3SharpUzduotisSuDB
{
    public partial class CountryManagementWindow : Form
    {

        DatabaseInterface dbInter = DatabaseInterface.Instance;
        List<Karvedys> valstybesKarvedziai;

        public Valstybe country { get; set; }
        public List<Karvedys> troops = new List<Karvedys>();

        public CountryManagementWindow(string countryName)
        {
            InitializeComponent();
            RefreshCountry(countryName);
            LoadWarriors();
            BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void CountryManagementWindow_Load(object sender, EventArgs e)
        {

        }


        private void changeCountryName_Click(object sender, EventArgs e)
        {
            if (changeNameInput != null)
            {
                dbInter.UpdateCountrysName(country.Pavadinimas, changeNameInput.Text);
                RefreshCountry(changeNameInput.Text);
            }
        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
            dbInter.DeleteCountry(country.Pavadinimas);
            Hide();
            var menu = new MainWindow();
            menu.ShowDialog();
            Close();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new MainWindow();
            menu.ShowDialog();
            Close();
        }

        private void RefreshCountry(string countryName)
        {
            country = dbInter.GetCountryByName(countryName);
            countryNameLabel.Text = countryName;
            countryDates.Text = country.Susikure.ToShortDateString();
        }

        private void addWarriorButton_Click(object sender, EventArgs e)
        {
            if (warriorNameLabel.Text != "")
            {
                dbInter.GenerateNewWarrior(warriorNameLabel.Text, new Random().Next(1, 50), country);
            }

            LoadWarriors();
        }

        private void LoadWarriors()
        {
            var visiKarvedziai = dbInter.GetAllWarriors();
            valstybesKarvedziai = new List<Karvedys>();

            foreach (var b in visiKarvedziai)
            {
                if(b.Tarnauja == country)
                {
                    valstybesKarvedziai.Add(b);
                }
            }

            var sts = new List<string>();

            foreach (var b in valstybesKarvedziai)
            {
                var sb = new StringBuilder();
                sb.Append(b.Vardas);
                sts.Add(sb.ToString());
            }
            thisCountryWarriors.DataSource = sts;
        }

        private void executionButton_Click(object sender, EventArgs e)
        {
            if(thisCountryWarriors.SelectedItem != null)
            {
                dbInter.RemoveWarrior(thisCountryWarriors.SelectedItem.ToString());
                LoadWarriors();
            }
        }

        private void warriorTrainButton_Click(object sender, EventArgs e)
        {
            if (thisCountryWarriors.SelectedItem != null)
            {
                int chance = new Random().Next(0, 100);
                if (chance < 20)
                {
                    dbInter.RemoveWarrior(thisCountryWarriors.SelectedItem.ToString());
                    MessageBox.Show("Your Warrior has accidentally Died!", "Failure", MessageBoxButtons.OK);
                }
                else if (chance < 70)
                {
                    dbInter.TrainWarrior(thisCountryWarriors.SelectedItem.ToString(), 2);
                    MessageBox.Show("Your Warrior feels stronger!", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    dbInter.TrainWarrior(thisCountryWarriors.SelectedItem.ToString(), -3);
                    MessageBox.Show("Your Warrior feels tired!", "Failure", MessageBoxButtons.OK);
                }
                LoadWarriors();
            }
        }
    }
}
