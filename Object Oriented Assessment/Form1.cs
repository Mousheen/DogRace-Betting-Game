using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Assessment
{
    public partial class Form1 : Form
    {
        DogRace objRaceWinner = new DogRace(); //declaring all the classes so I can use them in the form, I've created seperate classes for each of the betors. 
        Joe objJoe = new Joe();
        Bob objBob = new Bob();
        Al objAl = new Al();

        public Form1() //initialising the form to load up all my betor information into the textboxes and labels. 
        {
            InitializeComponent();

            objJoe.UpdateLabels();
            objBob.UpdateLabels();
            objAl.UpdateLabels();

            txtJoe.Text = objJoe.Message;
            txtBob.Text = objBob.Message;
            txtAl.Text = objAl.Message;

            lbJoe.Text = "Joe's Cash: $" + objJoe.Cash;
            lbAl.Text = "Al's Cash: $" + objAl.Cash;
            lbBob.Text = "Bob's Cash: $" + objBob.Cash;

        }

        private void btnRace_Click(object sender, EventArgs e) //race button calls on all the classes to simulate the race winner and people who have bets on the race. 
        {
            int Winner = Convert.ToInt16(objRaceWinner.winningDog()); //loading the racewinner and converting it to a int so i can use it in my if statement for the pictures to change.

            if (Winner == 0) //displays different pictures depending on who won. I could've made this into the dograce class but felt it was less lines of code to do it this was.
            {
                pbRaceStart.Image = Properties.Resources.RaceStart;
            }
            else if (Winner == 1)
            {
                pbRaceStart.Image = Properties.Resources.DogOne;
            }
            else if (Winner == 2)
            {
                pbRaceStart.Image = Properties.Resources.DogTwo;
            }
            else if (Winner == 3)
            {
                pbRaceStart.Image = Properties.Resources.DogThree;
            }
            else if (Winner == 4)
            {
                pbRaceStart.Image = Properties.Resources.DogFour;
            }

            if (objJoe.betPlaced == true) // controls if joe has placed a bet and what happens if he wins or looses. All funstions are in the class. 
            {
                objJoe.BetLoser(); //runs and checks if the bet lost.
                objJoe.BetWinner(); //runs and checks if the bet won.
                objRaceWinner.resetCount(); //resets information.
                objJoe.ClearBet(); //clears the bets
                txtJoe.Text = objJoe.Message; //displays appropriate message
                lbJoe.Text = "Joe's Cash: $" + objJoe.Cash.ToString(); //updates the labels.
                objJoe.betPlaced = false; //makes the bet placed variable false after the race. 
                pbRaceStart.Image = Properties.Resources.RaceStart; //resets the picture after the message box, I did orignally had it on the winning photo but it didn't look good having the winning photo always there until the next race.
            }

            if (objBob.betPlaced == true) //same as above code.
            {
                objBob.BetLoser();
                objBob.BetWinner();
                objRaceWinner.resetCount();
                objBob.ClearBet();
                txtBob.Text = objBob.Message;
                lbBob.Text = "Bob's Cash: $" + objBob.Cash.ToString();
                objBob.betPlaced = false;
                pbRaceStart.Image = Properties.Resources.RaceStart;
            }

            if (objAl.betPlaced == true) //same as above code.
            {
                objAl.BetLoser();
                objAl.BetWinner();
                objRaceWinner.resetCount();
                objAl.ClearBet();
                txtAl.Text = objAl.Message;
                lbAl.Text = "Al's Cash: $" + objAl.Cash.ToString();
                objAl.betPlaced = false;
                pbRaceStart.Image = Properties.Resources.RaceStart;
            }

            if (txtAl.Text == "BUSTED" && txtBob.Text == "BUSTED" && txtJoe.Text == "BUSTED") // i made a simple if statement to reset the form and show a message when all players go bust.
            {
                MessageBox.Show("ALL PLAYERS HAVE LOST" + "\nGAME OVER!!!!!!");
                Form1 NewForm = new Form1(); //to reduce the code I just destroyed the old form and load up a new form for the player after the game is over.
                NewForm.Show();
                this.Dispose(false);
            }

            nudBettor.Value = 5; // at the end of each race I want the values in the numberupdown box to be reset for the next round. 
            nudDog.Value = 1;
        }

        private void btnReset_Click(object sender, EventArgs e) //resets the counts so the player can race again. Instead of disabling and re-enabling the race button I have made it so that the user has to reset the race. 
        {
            int Reset; // I didn't have any issues with disabling the buttons it was just a different approach I wanted to take for the reset button.
            Reset = objRaceWinner.resetCount();
            pbRaceStart.Image = Properties.Resources.RaceStart;
        }

        private void btnPlaceBet_Click(object sender, EventArgs e) //this checks if the player wants to place a bet and if its valid. 
        {
            if (rbJoe.Checked == true) //if the radio button for the player is checked than it will carry out the command. Each bet needs to be individually placed. 
            {
                objJoe.Dog = Convert.ToInt32(nudDog.Value);
                objJoe.MyBet = Convert.ToInt32(nudBettor.Value);

                objJoe.PlaceBet();
                lbJoe.Text = "Joe's Cash: $" + objJoe.Cash.ToString();
                txtJoe.Text = objJoe.Message; //text fields update when the player bets and when he hasn't placed a bet. I could've made it display if he won or not but decided it was confusing when placing another bet. 
            }

            if (rbBob.Checked == true)
            {
                objBob.Dog = Convert.ToInt32(nudDog.Value);
                objBob.MyBet = Convert.ToInt32(nudBettor.Value);

                objBob.PlaceBet();
                lbBob.Text = "Bob's Cash: $" + objBob.Cash.ToString();
                txtBob.Text = objBob.Message;
            }

            if (rbAl.Checked == true)
            {
                objAl.Dog = Convert.ToInt32(nudDog.Value);
                objAl.MyBet = Convert.ToInt32(nudBettor.Value);

                objAl.PlaceBet();
                lbAl.Text = "Al's Cash: $" + objAl.Cash.ToString();
                txtAl.Text = objAl.Message;
            }
        }

        private void nudBettor_ValueChanged(object sender, EventArgs e) //I've programmed the updownnumber box to not go higher than the amount of money that the player has as well the limits, Min: 5, Max: 15
        {
            if (rbJoe.Checked && objJoe.Cash < nudBettor.Value && objJoe.Cash >= 5)
            {
                nudBettor.Value = objJoe.Cash;
            }
            else if (rbJoe.Checked && objJoe.Cash < 5)
            {
                nudBettor.Value = 5;
            }

            if (rbBob.Checked && objBob.Cash < nudBettor.Value && objBob.Cash >= 5)
            {
                nudBettor.Value = objBob.Cash;
            }
            else if (rbBob.Checked && objBob.Cash < 5)
            {
                nudBettor.Value = 5;
            }

            if (rbAl.Checked && objAl.Cash < nudBettor.Value && objAl.Cash >= 5)
            {
                nudBettor.Value = objAl.Cash;
            }
            else if (rbAl.Checked && objAl.Cash < 5)
            {
                nudBettor.Value = 5;
            }
        }
    }
}
