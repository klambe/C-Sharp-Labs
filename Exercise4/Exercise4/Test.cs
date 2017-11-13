using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Test
    {
        static void Main(string[] args)
        {
            SoccerPlayer s1 = new SoccerPlayer(SoccerPlayer.Position.striker, "Kevin", 13, Gender.Male);
            SoccerPlayer s2 = new SoccerPlayer(SoccerPlayer.Position.striker, "John", 14, Gender.Male);

            SoccerPlayer s3 = new SoccerPlayer(SoccerPlayer.Position.striker, "Mary", 13, Gender.Female);
            SoccerTeam team = new SoccerTeam(13, "Tigers", Gender.Male);

            team.AddPlayer(s1);

            try
            {
                team.AddPlayer(s2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            try
            {
                team.AddPlayer(s3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            //s1 = team["John"];
            Console.WriteLine(team["Kevin"]);

            if(team["Kevin"].Name == s1.Name)
            {
                Console.WriteLine("Match found");
            }

            try
            {
                Console.WriteLine(team["John"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

           

        }
    }
}
