using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        private string coach;
        private List<Player> players;
        private int age;
        public Team(string coach, List<Player> players)
        {
            if(players.Count>=11 && players.Count <= 22)
            {
                this.coach = coach;
                this.players = players;
                int sum = 0;
                foreach (Player player in players)
                {
                    sum += player.Age;
                }
                this.age = sum / players.Count;
            }
            else if(players.Count <11)
            {
                Console.WriteLine("Player count is not sufficient");
            }
            else if (players.Count > 22)
            {
                Console.WriteLine("Too many players");
            }
        }
    }
}
