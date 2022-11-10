using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboGame
{
    public static class Validator
    {
        public static string GetOtherPlayer(HumanPlayer humanPlayer)
        {

            while (true)
            {
                Console.WriteLine($"{humanPlayer.Name}, who would you like to play against? Rocco or Sandy? Warning: Answer is case sensitive.");
                string userSelection = Console.ReadLine();
                if (userSelection == "Rocco" || userSelection == "Sandy")
                {
                    return userSelection;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not an option.");
                }
            }
        }

        public static int IntegerValidator(int minValue, int maxValue, string input)
        {
            int returnValue;
            try
            {
                returnValue = int.Parse(input);
            }
            catch(FormatException)
            {
                return -1;
            }
            if (returnValue < minValue || returnValue > maxValue)
            {
                return -1;
            }
            return returnValue;
        }

        public static bool NumberValidationWithResponse(int minValue, int maxValue, string input)
        {
            if (IntegerValidator(minValue, maxValue, input) == -1)
            {
                Console.WriteLine("Sorry, that number is invalid.");
                Console.WriteLine("It may be out of range or not a valid integer. Let's try again.");
                return false;
            }
            return true;
        }

        public static int GetValidIntegerInputFromUser(HumanPlayer humanPlayer)
        {
            bool isValidInput = false;
            string userInput = "";
            while (isValidInput == false)
            {
                Console.WriteLine($"{humanPlayer.Name}, rock, paper, or scissors?");
                Console.WriteLine("1 - Rock, 2 - Paper, 3 - Scissors");
                userInput = Console.ReadLine();
                isValidInput = NumberValidationWithResponse(1, 3, userInput);
            }

            return int.Parse(userInput);

        }
    }
}
