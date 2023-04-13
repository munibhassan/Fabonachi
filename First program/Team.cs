using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class Team
    {
        private string teamName;
        private int noOfPlayers;

        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }

        // Getters and setters for the member variables
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public int NoOfPlayers
        {
            get { return noOfPlayers; }
            set { noOfPlayers = value; }
        }

        // Method to add players to the team
        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        // Method to remove players from the team
        public bool RemovePlayer(int count)
        {
            if (noOfPlayers - count < 0)
            {
                // Can't have negative number of players, so return false
                return false;
            }
            else
            {
                noOfPlayers -= count;
                return true;
            }
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
        {
            // Call the base class constructor with the provided parameters
        }

        // Method to change the team name
        public void ChangeTeamName(string name)
        {
            TeamName = name;
        }

    }
}
