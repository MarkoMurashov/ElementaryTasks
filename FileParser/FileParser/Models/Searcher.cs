using System;

using System.IO;

namespace FileParser
{
    class Searcher: FileParser, IStrategy
    {

        public int Algorithm(string path, string substr)
        {
            int NumberOfOccurrences = 0;
            foreach (var line in File.ReadLines(path))
            {
                if (line.Contains(substr))
                {
                    NumberOfOccurrences += line.Split(new string[] { substr }, StringSplitOptions.None).Length - 1;
                }
            }

            return NumberOfOccurrences;
        }

       
    }
}
