using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboGame
{
    public class HumanPlayer : Player
    {
        public override string GenerateRoshambo()
        {
            int userInput = int.Parse(Console.ReadLine());
            Roshambo userChoice = (Roshambo)userInput;
            return $"{userChoice}";
        }
    }
}
