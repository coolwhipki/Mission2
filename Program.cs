using System;
using System.Security.Cryptography;
using System.Xml.Linq;
using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creating second class
        Slay s = new Slay();

        System.Console.WriteLine("\nWelcome to the dice throwing simulator!\n");

        //input from user
        System.Console.WriteLine("How many dice rolls would you like to stimulate");
        int numRolls = int.Parse(System.Console.ReadLine());

        //Pass NumRolls to second class
        int[] resultArray = s.RollDie(numRolls);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULT\nEach '*' represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls);

        //Print the histogram and the results
        
        for (int eachCount = 0; eachCount < resultArray.Length; eachCount++)
        {
            // calculates the number of stars from rolls
            int numStars = (int)Math.Round(((double)resultArray[eachCount] / numRolls) * 100);

            //create a string of stars based on the number of stars
            string starString = new string('*', numStars);

            // list the numbers and the stars
            System.Console.WriteLine((eachCount + 2) + ": " + starString);

        }

        System.Console.WriteLine("Thank you for playing the dice throwing simulator. Goodbye!");
    }


}