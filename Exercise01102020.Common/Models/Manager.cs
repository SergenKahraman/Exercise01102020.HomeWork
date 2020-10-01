using Exercise01102020.Common.Abstractions;
using System.Windows.Forms;

namespace Exercise01102020.Common.Models
{
    public class Manager : SporEmployee, ISporEmployee
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddTeam(Team Team)
        {
            if (this.Team != null)
            {
                var result = MessageBox.Show("Bu yöneticinin bir takımı var\nYinede değiştirilsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            this.Team = Team;
            Team.Manager = this;
        }
    }
}
