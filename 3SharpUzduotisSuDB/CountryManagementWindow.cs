using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3SharpUzduotisSuDB
{
    public partial class CountryManagementWindow : Form
    {

        DatabaseInterface dbInter = DatabaseInterface.Instance;

        public Valstybe country { get; set; }

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
            using (var db = new KaraiIrMusiaiContainer())
            {
                var query = from b in db.ValstybeSet
                            where b.Pavadinimas == countryName
                            select b;

                foreach (var b in query)
                {
                    country = b;
                }
            }
            countryNameLabel.Text = countryName;
        }
    }
}
