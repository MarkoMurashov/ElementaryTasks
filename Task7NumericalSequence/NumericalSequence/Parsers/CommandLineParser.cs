using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    public class CommandLineParser
    {
        private string[] Arguments { get; set; }

        public CommandLineParser(string[] args)
        {
            Arguments = args;
        }

        public T GetOperation<T>() where T : Enum
        {
            if (!Enum.IsDefined(typeof(T), Arguments.Length))
            {
                throw new FormatException(Settings.WRONG_DATA);
            }

            return (T)Enum.ToObject(typeof(T), Arguments.Length);
        }
    }
}
