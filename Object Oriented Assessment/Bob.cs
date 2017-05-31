using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Assessment
{
    class Bob : DogRace //all the classes for each person are the same, except the names.
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
                Name = "Bob Burger";
                int cash = Cash;
                Message = "Bob Hasn't Placed A Bet Yet";
            }
        }

        public void PlaceBet()
        {
            if (Count == 1)
            {
                MessageBox.Show("Please reset the race before betting");
            }

            if (betPlaced == true)
            {
                MessageBox.Show("Bob has already placed a bet");
            }

            if (betPlaced == false && betPlaced == false && MyBet <= Cash && MyBet >= 5 && Dog > 0 && Count == 0)
            {
                Message = "Bob Has Placed $" + MyBet + " on Dog: " + Dog;
                Cash = Cash - MyBet;
                betPlaced = true;
            }
            else if (betPlaced == false && MyBet < 6)
            {
                MessageBox.Show("Minimum bet is $5.00");
                betPlaced = false;
            }
            else if (betPlaced == false && Dog == 0)
            {
                MessageBox.Show("Please select a dog to bet on");
                betPlaced = false;
            }
            else if (betPlaced == false && Cash < 5)
            {
                MessageBox.Show("Bob Has insufficent funds to place this bet");
                Message = "BUSTED";
                betPlaced = false;
            }
        }

        public int BetWinner()
        {
            if (Dog == Winner)
            {
                int winning = MyBet * 2;
                Cash = Cash + winning;

                MessageBox.Show("Congratulations " + Name + ". You've won: $" + winning);
            }
            return Cash;
        }

        public int ClearBet()
        {
            MyBet = 0;
            Dog = 0;
            Message = "Bob Hasn't Placed A Bet Yet";

            if (Dog != Winner)
            {
                if (Cash < 5)
                {
                    Message = "BUSTED";
                    betPlaced = false;
                }
            }
            return MyBet;
        }

        public void BetLoser()
        {
            if (Dog != Winner)
            {
                MessageBox.Show("Bob lost the bet");
            }
        }
    }
}
