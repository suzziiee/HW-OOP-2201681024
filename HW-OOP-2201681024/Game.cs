using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_2201681024
{
    public class Game
    {
        private List<AssistantReferee> assistantReferees2;
        
        public Game(Team team1, Team team2, List<AssistantReferee> assistantReferees, Referee referee, int GameResult, string Winner)
        {
            Team1 = team1;
            Team2 = team2;
            AssistantReferees = assistantReferees;
            assistantReferees2= new List<AssistantReferee>(2);
            Referee = referee;
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        public Referee Referee { get; set; }
        public int GameResult;
        public string Winner;
        
    }
}
