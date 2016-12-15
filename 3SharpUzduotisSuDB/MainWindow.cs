using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3SharpUzduotisSuDB
{
    public partial class MainWindow : Form
    {
        DatabaseInterface dbInter = DatabaseInterface.Instance;

        public MainWindow()
        {
            InitializeComponent();
            List<string> countryNameList = dbInter.getAllCountryNames();
            countrys.DataSource = countryNameList;
            SoundPlayer music = new SoundPlayer(@"C:\Users\Vartotojas\Desktop\3uzd\3SharpUzduotisSuDB\3SharpUzduotisSuDB\Resources\BackgroundMusic.wav");
            music.PlayLooping();
        }

        private void createCountry_Click(object sender, EventArgs e)
        {
            var createCountry = new CreateCountryWindow();
            createCountry.ShowDialog();
        }

        private void refreshCountrysButton_Click(object sender, EventArgs e)
        {
            List<string> countryNameList = dbInter.getAllCountryNames();
            countrys.DataSource = countryNameList;
        }

        private void chooseCountryButton_Click(object sender, EventArgs e)
        {
            if(countrys.SelectedItem != null)
            {
                Hide();
                var chooseCountry = new CountryManagementWindow(countrys.SelectedItem.ToString());
                chooseCountry.ShowDialog();
                Close();
            }           
        }

        private void allPowersButton_Click(object sender, EventArgs e)
        {
            List<Karvedys> allWarriors = dbInter.GetAllWarriors();
            List<Valstybe> allCountrys = dbInter.GetAllCountrys();

            var sb = new StringBuilder();

            var query = from warrior in allWarriors
                        join country in allCountrys
                        on warrior.Tarnauja equals country
                        group warrior by country.Pavadinimas;

            foreach (var rez in query)
            {
                foreach (var b in rez)
                {
                    sb.Append("Warrior Name: ").Append(b.Vardas).Append(", He serves: ").Append(b.Tarnauja.Pavadinimas).Append(", His power is: ").Append(b.PulkuSkaicius.ToString()).Append("\n");
                }
                sb.Append("\n");
            }

            MessageBox.Show(sb.ToString(), "Country Powers", MessageBoxButtons.OK);
        }
    }
}
