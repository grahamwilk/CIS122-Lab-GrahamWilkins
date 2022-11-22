namespace Mayflower_Project.Models
{
    public class FileGateWay
    {
        public List<Person> GetPeople(string aPath)
        {
            List<Person> aListOfPeople = new List<Person>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            Person aPerson = new Person();
            allRows = File.ReadAllLines(aPath);


            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aPerson = new Person();
                aPerson.FirstName = aRow[0];
                aPerson.LastName = aRow[1];
                aListOfPeople.Add(aPerson);
                index = index + 1;
            }

            return aListOfPeople;
        }
    }
}
