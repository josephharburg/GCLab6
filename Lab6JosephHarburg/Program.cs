using System;

namespace Lab6JosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Welcome to the Dice Roller!\n[.][:]");
            Console.WriteLine("Please enter the number of sides you want the die to have:");
            string userInput = Console.ReadLine();
            //get user input;
            while (repeat)
            {
                while (repeat)
                {
                    
                    
                    //validate user input;
                    bool correct = int.TryParse(userInput, out int total);

                    if (correct)
                    {
                        int diceRollOne = DiceRoll(total);
                        int diceRollTwo = DiceRoll(total);
                        Console.WriteLine($"Dice One: {diceRollOne}\nDice Two: {diceRollTwo}");
                        Console.WriteLine(NameOfRoll(diceRollOne, diceRollTwo));
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry thats not a valid response please enter a positive number:");
                        repeat = true;
                    }
                }
                //valdiate yes or no response
                repeat = true;
                while (repeat)
                {
                    Console.WriteLine("Would you like to try again?");
                    string response = Console.ReadLine().ToLower();
                    if (response == "y" || response == "yes")
                    {
                        repeat = false;
                    }
                    else if (response == "n" || response == "no")
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a yes, no, y, or n please!");
                    }
                }
                repeat = true;
            }
        }
        
        public static int DiceRoll(int userInput)
        {
            Random dice = new Random();
            return dice.Next(1, userInput + 1);
        }

        public static string NameOfRoll(int dicerollone, int dicerolltwo)
        {
            if(dicerollone == 1 && dicerolltwo == 1)
            {
                return "You got Snake Eyes!";
            }
            else if (dicerollone == 6 && dicerolltwo == 6)
            {
                return "You got a Box Car!";
            }
            else
            {
                return "";
            }
        }




    }
}
