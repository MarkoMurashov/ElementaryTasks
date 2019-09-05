using System;
using System.Linq;
using System.IO;

namespace Task6TicketAnalyzer
{
    class FileParser : ISourceAlgorithm
    {
        public TicketType GetAlgType(string path)
        {
            string algType = File.ReadLines(path).First();

            Enum.TryParse(algType, out TicketType type);

            return type;
        }
    }
}
