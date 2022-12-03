namespace Lab4
{
    public class FileRoot
    {
        public string workingDirectory;
        public string projectRoot;
        public string filename = "data.csv";
        public string filePath;
        public string newFilename = "data.psv";
        public string newFilePath;

        public FileRoot()
        {
            //Get the current working directory
            workingDirectory = Directory.GetCurrentDirectory();

            //Get the project root
            projectRoot = Path.GetFullPath(Path.Combine(workingDirectory, @"..\..\..\"));

            //Get the full filepath
            filePath = Path.Combine(projectRoot, filename);

            //Get the full filepath for the new file we will create
            newFilePath = Path.Combine(projectRoot, newFilename);
        }

        internal List<string> LoadData()
        {
            List<string> list = new List<string>();

            // FIrst, Last, Address, City, State, Postal
            using (var reader = new StreamReader(filePath))
            {
                //Read each entry
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    list.Add(line);
                }
            }

            return list;
        }

        internal void WriteNewDataFile(List<Person> people)
        {
            //Write our new data
            using (var writer = new StreamWriter(newFilePath))
            {
                foreach (var person in people)
                {
                    writer.WriteLine(person.ToString());
                }
            }
        }
    }
}