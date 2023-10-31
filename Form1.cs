using System;
using System.Windows.Forms;

namespace Craps
{

    // author @lhamilton2
    // C# program for game of Craps
    public partial class frmMain : Form
    {
        private int bankBalance = 100; // Initial bank balance
        private int point = 0; // Point value
        public frmMain()
        {
            InitializeComponent();
        }

        // Start btnRoll_Click method
        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Check if the user entered valid bet
            if (int.TryParse(txtboxBetValue.Text, out int betAmount))
            {
                if (betAmount <= bankBalance)
                {
                    // Generate the random dice values
                    Random r = new Random();
                    int dice1 = r.Next(1, 7);
                    int dice2 = r.Next(1, 7);
                    int sum = dice1 + dice2;

                    // Update labels to display dice values
                    lblDiceValue1.Text = "First die value: " + dice1.ToString();
                    lblDiceValue2.Text = "Second die value: " + dice2.ToString();

                    // Determine game outcome
                    if (point == 0)
                    {
                        // First throw
                        if (sum == 7 || sum == 11)
                        {
                            bankBalance += betAmount;
                            lblDisplay.Text = "You win!";
                        }
                        else if (sum == 2 || sum == 3 || sum == 12)
                        {
                            bankBalance -= betAmount;
                            lblDisplay.Text = "You lose!";
                        }
                        else
                        {
                            point = sum;
                            lblDisplay.Text = "Point is " + point;
                        }
                    }
                    else
                    {
                        // Subsequent throws
                        if (sum == 7)
                        {
                            bankBalance -= betAmount;
                            lblDisplay.Text = "Sorry! You lose.";
                            point = 0;
                        }
                        else if (sum == point)
                        {
                            bankBalance += betAmount;
                            lblDisplay.Text = "You win!";
                            point = 0;
                        }
                    }

                    // Update bank balance label
                    lblBankBalance.Text = "Bank Balance: $" + bankBalance;
                }
                else
                {
                    MessageBox.Show("Not enough money to place this bet!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet.");
            }
        }
        // End btnRoll_Click method

        private void lblBankBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblDiceValue1_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
