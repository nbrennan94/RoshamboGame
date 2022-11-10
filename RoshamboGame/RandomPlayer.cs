using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboGame
{
    public class RandomPlayer : Player
    {
        public override string GenerateRoshambo()
        {
            Random random = new Random();
            int randomValue = random.Next(1, 4);
            Roshambo randomThrow = (Roshambo)randomValue;

            return $"{randomThrow}";
        }
    }
}
