namespace Mayflower_Project.Models
{
    public class Person
    {
        private string firstName = "n/a";
        private string lastName = "n/a";

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public override string ToString()
        {
            string msg = "";
            msg += "First Name: " + this.FirstName + "\n";
            msg += "Last Name: " + this.LastName + "\n";
            return msg;
        }
    }
}
