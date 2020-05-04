using System;
using System.Windows.Forms;

namespace Recipe_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            // Variables
            int celsius;  
            int fahrenheit;
            // Conversion from TextBox to Integer
            if (Int32.TryParse(txtCelsius.Text, out celsius)){}
            // Calculating fahrenheit from celsius
            fahrenheit = ((celsius / 5) * 9) + 32;
            // Assigning the variable to the Text Box
            txtFahrenheit.Text = fahrenheit.ToString();
        }

        private void btnCups_Click(object sender, EventArgs e)
        {
            // Variables
            int milliliters;
            double cups;
            // Conversion from TextBox to Integer
            if (Int32.TryParse(txtMilliliters.Text, out milliliters)) { }
            // Calculating milliliters to cups
            cups = milliliters / 263.59;
            // Assigning the variable to the Text Box
            txtCups.Text = cups.ToString();
        }
    }
}
