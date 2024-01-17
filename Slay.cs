using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Slay
    {
        public Slay()
        {

        }
        public int[] RollDie(int rollz)
        {
            // import the random package so we can roll die randomly
            Random random = new Random();

            // Array that holds the count of the comination of the two dices 
            int[] rollNumCounts = new int[11];


            // Dice roll for specified times and count number of times 
            for (int count = 0; count < rollz; count++)
            {

                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int sumMaddness = die1 + die2;

                rollNumCounts[sumMaddness - 2]++;
            }

            return rollNumCounts;
        }
    }
}
