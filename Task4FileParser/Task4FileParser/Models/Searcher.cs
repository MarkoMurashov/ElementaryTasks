using System;

using System.IO;

namespace Task4FileParser
{
    class Searcher: IStrategy
    {

        public int Algorithm(string path, string substr)
        {
            int numberOfSubstrings = 0;
            foreach (var line in File.ReadLines(path))
            {
                if (line.Contains(substr))
                {
                    numberOfSubstrings += line.Split(new string[] { substr }, StringSplitOptions.None).Length - 1;
                }
            }

            return numberOfSubstrings;
        }

       
    }
}
