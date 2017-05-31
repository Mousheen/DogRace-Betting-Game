using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Assessment
{
    class Joe : DogRace
    {
        public string Name { get; set; }
        public int MyBet { get; set; }
        public int Cash = 50;
        public bool betPlaced = false;
        public bool MyRadioButton = true;
        public string MyLabel { get; set; }
        public int Dog { get; set; }
        public string Message { get; set; }

        public void UpdateLabels()
        {
            if (MyRadioButton == true)
            {
                Name = "Joe Wheeler";
                int cash = Cash;
                Message = "Joe Hasn't Placed A Bet Yet";
            }
        } //updates the labels 

        public int PlaceBet() //theres various number of checks that I made in order to be able to place a bet. 
        {
            if (Count == 1) //instead of disabling the race button I made it so that when you press it twice it shows you need to reset the dog race.
            {
                MessageBox.Show("Please reset the race before betting"); //i didn't want the user to rest the amount of money they had so i used the reset button to reset the race instead.
            }

            if (betPlaced == true) //if bet is already placed than nothing happens except a message box, the below code if not carried out if a bet is already placed. 
            {
                MessageBox.Show("Joe has already placed a bet");            
            }

            if (betPlaced == false && MyBet <= Cash && MyBet >= 5 && Dog > 0 && Count == 0)
            {
                Message = "Joe Has Placed $" + MyBet + " on Dog: " + Dog;
                Cash = Cash - MyBet;
                betPlaced = true;
            }
            else if (betPlaced == false && MyBet < 6) //When I had this at 5 it was showing me a message when the money was on 5, but making this 6 solved the problem. 
            {
                MessageBox.Show("Minimum bet is $5.00"); //minimum amount that a player is allowed to bet is $5
                betPlaced = false;
            }
            else if (betPlaced == false && Cash < 5) //if cash drops below 5 than the player goes bust because the minimum bet allowed is $5
            {
                MessageBox.Show("Joe has insufficent funds to place this bet");
                Message = "BUSTED";
                betPlaced = false;
            }
            return MyBet;
        }

        public int BetWinner() //checks if the winning dog matches the betors dog. 
        {
            if (Dog == Winner)
            {
                int winning = MyBet * 2;
                Cash = Cash + winning;

                MessageBox.Show("Congratulations " + Name + ". You've won: $" + winning);
            }
            return Cash;
        }

        public void ClearBet()
        {
            MyBet = 0;
            Dog = 0;
            Message = "Joe Hasn't Placed A Bet Yet";

            if (Cash < 5)
            {
                Message = "BUSTED";
                betPlaced = false;                 
            }
        } //clears the players bet after the race so it doesn't accidently carry over to the next race. 

        public void BetLoser()
        {
            if(Dog != Winner)
            {
                MessageBox.Show("Joe lost the bet");
            }
        } //code for when the player looses his bet
    }
}
