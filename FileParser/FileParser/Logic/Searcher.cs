using System;

using System.IO;

namespace FileParser
{
    class Searcher: ISearch 
    {
        public int SearchSubstring(string path, string substring)
        {
            int result = 0;              
            foreach (var line in File.ReadLines(path))
            {
               if (line.Contains(substring))
               {
                 result += line.Split(new string[] { substring }, StringSplitOptions.None).Length-1;
               }
            }        
            
            return result;
        }
    }
}
