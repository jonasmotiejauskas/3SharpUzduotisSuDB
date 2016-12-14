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
    public partial class MainWindow : Form
    {
        DatabaseInterface dbInter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void createCountry_Click(object sender, EventArgs e)
        {
            var createCountry = new CreateCountryWindow();
            createCountry.ShowDialog();
        }

        private void refreshCountrysButton_Click(object sender, EventArgs e)
        {

        }

        private void chooseCountryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
