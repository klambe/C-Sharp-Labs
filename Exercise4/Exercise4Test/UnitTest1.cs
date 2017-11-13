using System;
using Exercise4;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Exercise4Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenValidPlayerIsAddedToTeamThenCollectionContainsPlayer()
        {
            SoccerPlayer s1 = new SoccerPlayer(SoccerPlayer.Position.striker, "Kevin", 13, Gender.Male);
            SoccerTeam team = new SoccerTeam(13, "Tigers", Gender.Male);
            team.AddPlayer(s1);
            Assert.AreEqual(team["Kevin"], s1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenInValidPlayerIsAddedToTeamThenCollectionDoesNotContainPlayer()
        {
            SoccerPlayer s1 = new SoccerPlayer(SoccerPlayer.Position.striker, "John", 14, Gender.Male);
            SoccerTeam team = new SoccerTeam(13, "Rovers", Gender.Male);
            team.AddPlayer(s1);
            Assert.AreNotEqual(team["John"], s1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenFemalePlayerIsAddedToMaleTeamThenCollectionDoesNotContainTheFemalePlayer()
        {
            SoccerPlayer s1 = new SoccerPlayer(SoccerPlayer.Position.striker, "Mary", 13, Gender.Female);
            SoccerTeam team = new SoccerTeam(13, "Tigers", Gender.Male);
            team.AddPlayer(s1);
            Assert.AreNotEqual(team["John"], s1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenATeamBelowMinimumAgeIsPassedToConstructorthenArgumentExceptionIsThrown()
        {

            SoccerTeam team = new SoccerTeam(4, "Tigers", Gender.Male);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenAddingTheSamePlayerTwiceToTeamThenArgumentExceptionIsThrown()
        {

            SoccerPlayer s1 = new SoccerPlayer(SoccerPlayer.Position.striker, "Kevin", 13, Gender.Male);
            SoccerTeam team = new SoccerTeam(13, "Tigers", Gender.Male);
            team.AddPlayer(s1);
            team.AddPlayer(s1);
            Assert.Fail();
        }

        [TestMethod]
        public void WhenTeamIsCreatedThenEmptyCollectionIsCreated()
        {           
            SoccerTeam team = new SoccerTeam(13, "Tigers", Gender.Male);           
            Assert.AreEqual(team.Players.Count, 0);
        }


    }
}
