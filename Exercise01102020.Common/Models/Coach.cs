using Exercise01102020.Common.Abstractions;
using System.Windows.Forms;

namespace Exercise01102020.Common.Models
{
    public class Coach : SporEmployee, ISporEmployee
    {
        public Coach(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddTeam(Team Team)
        {
            if (this.Team != null)
            {
                var result = MessageBox.Show("Bu Koçun bir takımı var\nYinede değiştirilsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            this.Team = Team;
            if (Team.Coach != null)
            {
                Team.Coach.Team = null;
            }
            Team.Coach = this;
        }
    }
}