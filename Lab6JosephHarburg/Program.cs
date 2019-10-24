using System;

namespace Lab6JosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Welcome to the Dice Roller!\n");
            Console.WriteLine("Please enter the number of sides you want the die to have");
            //get user input
            while (repeat)
            {
                string userInput = Console.ReadLine();
                //validate user input
                bool correct = int.TryParse(userInput, out int total);
                if (correct)
                {
                    int diceRollOne = DiceRoll(total);
                    int diceRollTwo = DiceRoll(total);
                    Console.WriteLine($"Roll One: {diceRollOne}\n Roll Two: {diceRollTwo}");
                }
                else
                {
                    Console.WriteLine("Im sorry thats not a valid response please enter a positive number");
                    repeat = true;
                }
            }
            

        }
        public static int DiceRoll(int userInput)
        {
            Random dice = new Random();
            return dice.Next(userInput);

        }

        //public static bool Repeat(string response)
        //{
        //    bool repeating = true;
        //    while(repeating)
        //    response.ToLower();
        //    if (response != "y" && response !="yes" && response != "n" && response != "no")
        //    {
        //        Console
        //        repeating = true;
        //    }
        //}
    }   
}
