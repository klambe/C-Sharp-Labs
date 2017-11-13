using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections;

namespace Exercise4
{
    public enum TeamGender                                   // underlying type is int
    {
        Male, Female, Other                                // 0, 1, 2
    }
    public class SoccerTeam : IEnumerable<SoccerPlayer>
    {
        public const int MinAge = 5;


        int ageLimit;

        List<SoccerPlayer> players = new List<SoccerPlayer>();
        
       

        public String TeamName { get; set; }
        public Gender TeamGender { get; set; }

        public int AgeLimit
        {
            get
            {
                return ageLimit;
            }
            set
            {
                if (value > MinAge)
                {
                    ageLimit = value;

                }
                else
                {
                    throw new ArgumentException("Exception: Age Limit for a Team must be >= " + MinAge);
                }

            }
        }

        public Collection<SoccerPlayer> Players
        {
            get
            {
                return new Collection<SoccerPlayer>(players);
            }
        }

        //indexer

        public SoccerPlayer this[string name]
        {
            get
            {
                var findPlayer = players.Where(p => p.Name.ToLower() == name.ToLower()).Select(p => p).FirstOrDefault();

                if (findPlayer == null)
                {
                    throw new ArgumentException("Exception: Player " + name + " is not in the soccer team " + TeamName);
                }
                else
                {
                    return findPlayer;
                }
            }
        }


        public SoccerTeam(int ageLimit, string teamName, Gender teamGender)
        {
            AgeLimit = ageLimit;
            TeamName = teamName;
            TeamGender = teamGender;                       
        }

        public IEnumerator<SoccerPlayer> GetEnumerator()
        {
            foreach (SoccerPlayer s in players)
            {
                yield return s;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // call generic implementation above
            return this.GetEnumerator();
        }

        public void AddPlayer(SoccerPlayer player)
        {

            if (players == null)                            // empty
            {
                players.Add(player);
            }
            else
            {
                if (players.Contains(player))               // already in the team, Contains uses Equals for SoccerPlayer to test presence
                {
                    throw new ArgumentException("Exception: player " + player.Name + " is already in the team");
                }
                else
                {
                    // add the plater
                    if (player.PlayerGender == TeamGender)
                    {
                        if (player.Age <= AgeLimit)
                        {
                            players.Add(player);
                        }
                        else
                        {
                            throw new ArgumentException("Exception: player " + player.Name + " is too old for team " + TeamName);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Exception: player " + player.Name + " is " + player.PlayerGender + " while team is " + TeamGender);
                    }

                }
            }
        }
    }
}
