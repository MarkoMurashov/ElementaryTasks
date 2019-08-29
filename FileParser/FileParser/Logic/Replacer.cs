using System.IO;


namespace FileParser
{
    class Replacer:FileParser, IStrategy
    {        
        public string NewString { get; set; }

        public Replacer(string path,string oldString, string newString)  
            :base(path, oldString)
        {
            NewString = newString;
        }

        public void Algorithm()
        {
            bool noMatch = true;
            var allStrings = File.ReadAllLines(this.Path);
            using (StreamWriter write = new StreamWriter(this.Path))
            {
                foreach (var str in allStrings)
                {
                    if (str.Contains(this.SubString) && noMatch)
                    {
                        noMatch = false;
                    }
                    write.WriteLine(str.Replace(this.SubString, NewString));
                }

            }

            if (noMatch)
            {
                throw new System.Exception(Settings.NO_MATCH);
            }


        }
    }
}
