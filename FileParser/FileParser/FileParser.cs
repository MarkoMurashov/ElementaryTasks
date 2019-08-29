using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    public abstract class FileParser
    {
        public string Path { get; set; }

        public string SubString { get; set; }

        public IStrategy Strategy { private get; set; }


        public FileParser(string path, string subString, IStrategy strategy)
        {
            Path = path;
            SubString=subString;
            Strategy = strategy;
        }

        public FileParser(string path, string subString)
        {
            Path = path;
            SubString = subString;
        }

        public void DoAlgorithn()
        {
            Strategy.Algorithm();
        }

    }
}
