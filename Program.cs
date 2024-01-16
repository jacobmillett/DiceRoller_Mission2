using DiceRoller;
using System;
public class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Welcome to the Dice Rolling Game!\n\nHow many dice rolls would you like to simulate?");

        string promptInput = Console.ReadLine();

        if (int.TryParse(promptInput, out int rollCount))
        {
            Rolls diceRoller = new Rolls(rollCount);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer in number form.");
        }

    }
}