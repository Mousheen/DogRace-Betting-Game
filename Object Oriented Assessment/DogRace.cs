using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Assessment
{
    class DogRace //fairly simple class to determine the winner of the race and to give a message to reset the race if the user clicks it twice
    {
        public static int Winner { get; set; } //variable can be used in the the child classe as well the information it contains.
        public static int Count = 0; //counts the number of times the user clicks the race button.

        Random rnd = new Random();

        public int winningDog()
        {
            if (Count == 0)
            {
                int winningDog = rnd.Next(1, 5);
                Winner = winningDog;
                //MessageBox.Show("Dog: " + Winner.ToString() + " is the Winner");  //Messagebox to check the winner.
                Count++;
            }
            else
            {
                MessageBox.Show("Please Reset Race");
                Winner = 5;
            }
            return Winner;
        }

        public int resetCount()
        {
            Count = 0;
            return Count;
        }

    }
}
