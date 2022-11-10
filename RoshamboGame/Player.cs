using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboGame
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int RoshamboValue { get; set; }

        public abstract string GenerateRoshambo();
    }
}
