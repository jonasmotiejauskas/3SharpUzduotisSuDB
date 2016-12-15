using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _3SharpUzduotisSuDB
{
    public partial class CountryManagementWindow : Form
    {

        DatabaseInterface dbInter = DatabaseInterface.Instance;

        public Valstybe country { get; set; }
        public List<Karvedys> troops = new List<Karvedys>();

        public CountryManagementWindow(string countryName)
        {
            InitializeComponent();
            RefreshCountry(countryName);
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
            countryNameLabel.Text = country.Pavadinimas;
            countryDates.Text = country.Susikure.ToShortDateString();
        }

        private void CountryManagementWindow_Load(object sender, EventArgs e)
        {

        }

        private void addWarriorButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
