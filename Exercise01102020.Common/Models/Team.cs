using System.ComponentModel;
using System.Windows.Forms;

namespace Exercise01102020.Common.Models
{
    public class Team
    {
        public Team(string teamName)
        {
            TeamName = teamName;
            Players = new BindingList<Player>();
        }
        public Coach Coach { get; set; }
        public Manager Manager { get; set; }
        public BindingList<Player> Players { get; set; }
        public string TeamName { get; set; }

        public void AssignCoach(Coach coach)
        {
            if (this.Coach != null)
            {
                var result = MessageBox.Show("Bu takımın bir koçu var\nYinede değiştirilsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    this.Coach.Team = null;
                }
                
            }
            this.Coach = coach;
            if (coach.Team != null)
            {
                coach.Team.Coach = null;
            }
            coach.Team = this;
        }

        public void AssignManager(Manager manager)
        {
            if (this.Manager != null)
            {
                var result = MessageBox.Show("Bu takımın bir koçu var\nYinede değiştirilsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    this.Manager.Team = null;
                }
            }
            
            this.Manager = manager;
            if (manager.Team != null)
            {
                manager.Team.Manager = null;
            }
            manager.Team = this;
        }

        public void AssignPlayers(params Player[] players)
        {
            foreach (var P in players)
            {
                if (P.Team != null)
                {
                    P.Team.Players.Remove(P);
                }
                Players.Add(P);
                P.Team = this;
            }
        }



        public override string ToString()
        {
            return TeamName;
        }
    }
}