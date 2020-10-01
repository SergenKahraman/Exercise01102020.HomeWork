using Exercise01102020.Common.Models;

namespace Exercise01102020.Common.Abstractions
{
    public class SporEmployee
    {
        public SporEmployee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string LastName { get; set; }
        public Team Team { get; set; }
    }
}