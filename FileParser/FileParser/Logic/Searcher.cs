using System;

using System.IO;

namespace FileParser
{
    class Searcher: FileParser, IStrategy
    {
        public int NumberOfOccurrences {get; set;}

        public Searcher(string path, string oldString)
            :base(path, oldString)
        {

        }

        public void Algorithm()
        {
            int result = 0;
            foreach (var line in File.ReadLines(this.Path))
            {
                if (line.Contains(this.SubString))
                {
                    result += line.Split(new string[] { this.SubString }, StringSplitOptions.None).Length - 1;
                }
            }

            NumberOfOccurrences= result;
        }

       
    }
}
