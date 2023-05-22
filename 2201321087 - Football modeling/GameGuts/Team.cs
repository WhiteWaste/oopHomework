using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201321087___Football_modeling
{
    class Team
    {
        public string TeamName { get; set; }
        public Coach Coach { get; private set; }
        public ManOfTheFoot[] Players { get; private set; }

        public Team(Coach coach, params ManOfTheFoot[] players)
        {
            if (players.Length < 11) throw new Exception("The team must have at least 11 players");
            if (players.Length > 22) throw new Exception("The team must have at most 22 players");

            Coach = coach;
            Players = players;
        }
        public int GetAverageAgeOfPlayers()
        {
            int ageSum = 0;
            return ageSum;
        }
    }
}
