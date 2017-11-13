using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public enum Gender                                   // underlying type is int
    {
        Male, Female, Other                                // 0, 1, 2
    }
    public abstract class SportsPlayer
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender PlayerGender { get; set; }
       
       public SportsPlayer(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            PlayerGender = gender;
        }

        public override string ToString()
        {
            return String.Format("Gender: {0} Name: {1} Age: {2}",PlayerGender,Age,PlayerGender);
        }
    }
}
