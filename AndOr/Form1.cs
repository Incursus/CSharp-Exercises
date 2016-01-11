using System;
using System.Windows.Forms;

namespace AndOr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void recommendButton_Click(object sender, EventArgs e)
        {
            var userInput = Convert.ToInt32(priceTextBox.Text);
            int targetPrice = 500;
            var highPrice = userInput >= targetPrice;
            var lowPrice = userInput < targetPrice;

            if (userInput == 666 || userInput == 777)
            {
                MessageBox.Show("Buy a lottery ticket");
                return;
            }
            if (highPrice && warrantyCheckBox.Checked)
            {
                MessageBox.Show("Buy the best model since you have warranty!");
                return;
            }
            if (highPrice)
            {
                MessageBox.Show("Get a warranty with this high of a price!");
            }
            if (lowPrice)
            {
                MessageBox.Show("Don't buy cheap junk!");
            }
        }
    }
}
