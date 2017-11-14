using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class SoccerPlayer :SportsPlayer
    {
        public enum Position                                   // underlying type is int
        {
            goalkeeper, defender, midfielder, striker                                // 0, 1, 2
        }
        public Position PlayerPosition { get; set; }

        public SoccerPlayer(Position position, string name, int age, Gender gender) : base(name, age, gender)
        {
            PlayerPosition = position;
        }

        public SoccerPlayer():base("",0, Gender.Male)
        {
            PlayerPosition = Position.defender;
        }

        public override string ToString()
        {
            return String.Format("Gender: {0} Name: {1} Age: {2} position {3}", PlayerGender, Name, Age,  PlayerPosition);
        }
    }
}
