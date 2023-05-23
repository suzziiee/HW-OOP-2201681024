using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_2201681024
{
    public class Team
    {
        private List<FootballPlayer> footballPlayers;
        public Team(Coach coach, List<FootballPlayer> footballPlayers)
        {
            Coach = coach;
            FootballPlayers = footballPlayers;
            footballPlayers = new List<FootballPlayer>();
        }

        public Coach Coach { get; set; }
        public List<FootballPlayer> FootballPlayers { get; set; }
        public double AverageAge;
    }
}
