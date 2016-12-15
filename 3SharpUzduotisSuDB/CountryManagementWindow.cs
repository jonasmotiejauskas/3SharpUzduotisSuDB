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
        public CountryManagementWindow()
        {
            InitializeComponent();
        }

        private void changeCountryName_Click(object sender, EventArgs e)
        {

        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
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
    }
}
