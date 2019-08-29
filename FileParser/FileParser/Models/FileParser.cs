using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    public class FileParser
    {
        private string PathToFile { get; set; }

        private string SubString { get; set; }

        public IStrategy Strategy { private get; set; }


        public FileParser(string path, string subString, IStrategy strategy)
        {
            PathToFile = path;
            SubString=subString;
            Strategy = strategy;
        }
       
        public FileParser()
        {

        }

        public int DoAlgorithn()
        {
           return Strategy.Algorithm(PathToFile, SubString);
        }

    }
}
