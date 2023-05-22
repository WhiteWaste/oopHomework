using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201321087___Football_modeling
{
    class Game
    {
        public delegate void OnGoal(Team scoringTeam, Goal goal);
        public delegate void OnGameEnd(Team winner, Team loser, Goal[] goals);

        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public Referee assistantRef1 { get; private set; }
        public Referee assistantRef2 { get; private set; }
        
        private Goal[] goals;
        private Team? winner;

        public Game(Team team1, Team team2, Referee mainReferee, Referee assistant1, Referee assistant2) 
        {
            if (team1.Players.Length > 11 || team2.Players.Length > 11) 
                throw new Exception("Teams in games must have only 11 players");
            
            Team1 = team1;
            Team2 = team2;

            Referee = mainReferee;
            assistantRef1 = assistant1;
            assistantRef2 = assistant2;
        }

        public void GameResult(OnGoal onGoal, OnGameEnd onGameEnd)
        {
            goals = new Goal[Random.Shared.Next(1, 7)];
            
            int t1Points = 0, t2Points = 0;
            Team? currentTeam = null;
            int time = 5;
            for(int goalIndex = 0; goalIndex < goals.Length; goalIndex++)
            {
                if(Random.Shared.Next(2) == 0)
                {
                    currentTeam = Team1;
                    t1Points++;
                }
                else
                {
                    currentTeam = Team2;
                    t2Points++;
                }
                goals[goalIndex] = new Goal(currentTeam.Players[Random.Shared.Next(11)], time);
                time += Random.Shared.Next(5, 18);
                
                onGoal(currentTeam, goals[goalIndex]);
            }

            Team loser;
            if (t1Points > t2Points) 
            { 
                winner = Team1; 
                loser = Team2; 
            }
            else if (t2Points > t1Points)
            {
                winner = Team2;
                loser = Team1;
            }
            else
            {
                winner = currentTeam;
                loser = currentTeam == Team1 ? Team2 : Team1;
            }

            onGameEnd(winner, loser, goals);
        }

        public Team GetWinner()
        {
            if (winner == null) throw new Exception("No game has been played");
            return winner;
        }
    }
}
