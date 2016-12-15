using System;
using System.Windows.Forms;

namespace _3SharpUzduotisSuDB
{
    public partial class CreateCountryWindow : Form
    {

        DatabaseInterface dbInter;

        public CreateCountryWindow()
        {
            InitializeComponent();
            dbInter = DatabaseInterface.Instance;
        }

        private void createCountryButton_Click(object sender, EventArgs e)
        {
            dbInter.InsertNewCountry(countryNameInput.Text, new DateTime(new Random().Next(1753, 3333), new Random().Next(1, 12), new Random().Next(1, 28)));
            this.Close();
        }

        private void cancelCreateCountryButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
