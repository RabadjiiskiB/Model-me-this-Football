using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Game
    {
        private List<Player> team1;
        private List<Player> team2;
        private Referee referee;
        private Referee assistant_referee;
        private Referee assistant_referee2;
        private List<Goals> goals;
        private string result;
        private Team winner;
        public Game(List<Player> team1, List<Player> team2, Referee referee, Referee assistant_referee, Referee assistant_referee2, List<Goals> goals, string result, Team winner)
        {
            while(team1.Count<=11)
            {
                this.team1.Add(team1[0]);
            }
            while(team2.Count<=11)
            {
                this.team2.Add(team2[0]);
            }

            this.referee = referee;
            this.assistant_referee = assistant_referee;
            this.assistant_referee2 = assistant_referee2;
            this.goals = goals;
            this.result = result;
            this.winner = winner;
        }
    }
}
