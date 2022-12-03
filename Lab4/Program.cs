using System.IO;

namespace Lab4
{
    public class Program
    {
        public static List<Person> people = new List<Person>();
        public static List<string> csvEntries = new List<string>();

        public static void Main(string[] args)
        {
            //Instantiate a FileRoot object
            FileRoot fileRoot = new FileRoot();

            //Populate the entries
            Console.WriteLine("Populating the entries of people from the data.csv file...");
            Console.WriteLine("");
            csvEntries = fileRoot.LoadData();

            foreach (string entry in csvEntries)
            {
                //Split the entry by the ',' charater
                var values = entry.Split(',');

                //Add a new person with an address
                people.Add(new Person(values[0], values[1], new Address(values[2], values[3], values[4], values[5])));
            }

            Console.WriteLine("People list has been generated from the csv file...");
            Console.WriteLine("");

            //Sorting time! We'll do it by the comparer we specified in the class
            Console.WriteLine("Sorting the people list by the 'Last Name' property...");
            Console.WriteLine("");
            people.Sort();

            //Last step, write the data to data.psv
            Console.WriteLine("Writing newly sorted data with '|' character separator into data.psv...");
            Console.WriteLine("");
            fileRoot.WriteNewDataFile(people);
        }
    }
}