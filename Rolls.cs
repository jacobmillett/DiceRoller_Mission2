using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Rolls
    {
        public int diceRolls;
        public int[] counters = new int[12];
        public string displayMessage;


        public Rolls(int diceRolls)
        {
            this.diceRolls = diceRolls;
            this.displayMessage = $"DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = {diceRolls}.\n\n";

            Random random = new Random();
            for (int iCount=0; iCount<diceRolls; iCount++)
            {
                int firstDie = random.Next(1, 7);
                int secondDie = random.Next(1, 7);
                int dieSum = firstDie + secondDie;
                counters[dieSum-1]++;
            }

            for (int iCount = 0; iCount <= counters.Length - 2; iCount++)
            {
                int percentage = (counters[iCount + 1] * 100) / diceRolls;
                displayMessage += $"{iCount + 2}: {new string('*', percentage)}\n";
            }

            Console.WriteLine(displayMessage);
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

            
        }
        
            

        



    }
}
