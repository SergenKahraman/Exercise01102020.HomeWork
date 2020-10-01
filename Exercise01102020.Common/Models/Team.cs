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
            }
            this.Coach = coach;
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
            }
            this.Manager = manager;
            manager.Team = this;
        }

        public void AssignPlayers(params Player[] players)
        {
            foreach (var P in players)
            {
                Players.Add(P);
                P.Team = this;
            }
        }
    }
}