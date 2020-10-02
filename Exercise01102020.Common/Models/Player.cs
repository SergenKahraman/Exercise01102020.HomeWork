using Exercise01102020.Common.Abstractions;
using System.Net.Http;
using System.Windows.Forms;

namespace Exercise01102020.Common.Models
{
    public class Player : SporEmployee, ISporEmployee
    {
        public Player(string firstName, string lastName, int licenseNo) : base(firstName, lastName)
        {
            LicenseNo = licenseNo;
        }
        public int LicenseNo { get; set; }

        public void AddTeam(Team Team)
        {
            if (this.Team != null)
            {
                var result = MessageBox.Show("Bu oyuncunun bir takımı var\nYinede değiştirilsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    this.Team.Players.Remove(this);
                }
            }
            this.Team = Team;
            Team.Players.Add(this);
        }




        public override string ToString()
        {
            return FullName;
        }
    }
}