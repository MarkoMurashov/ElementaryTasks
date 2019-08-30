using System.IO;
using System;

namespace Task4FileParser
{
    class Replacer: IStrategy
    {        
        public string NewString { get; set; }

        public Replacer(string newString)  
        {
            NewString = newString;
        }

        public int Algorithm(string path, string substr)
        {
            bool noMatch = true;
            var allStrings = File.ReadAllLines(path);

            uint checkedLinesNumber = 0;
            using (StreamWriter write = new StreamWriter(path))
            {
                foreach (var str in allStrings)
                {
                    if (str.Contains(substr) && noMatch)
                    {
                        noMatch = false;
                        checkedLinesNumber++;
                    }
                    write.WriteLine(str.Replace(substr, NewString));
                }

            }

            if (noMatch)
            {
                throw new System.Exception(Settings.NO_MATCH);
            }

            return (int)checkedLinesNumber;
        }
    }
}
