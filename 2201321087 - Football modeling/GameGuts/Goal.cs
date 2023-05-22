using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201321087___Football_modeling
{
    internal class Goal
    {
        public string PlayerName { get; private set; }
        public int Minute { get; private set; }

        public Goal(ManOfTheFoot player, int minute)
        {
            PlayerName = player.Name;
            Minute = minute;
        }

        public Goal(string playerName, int minute)
        {
            PlayerName = playerName;
            Minute = minute;
        }
    }
}
