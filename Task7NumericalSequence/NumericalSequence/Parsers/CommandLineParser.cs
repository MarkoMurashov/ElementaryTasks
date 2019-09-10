using System;

namespace NumericalSequence
{
    public class CommandLineParser
    {
        #region Properties

        private string[] Arguments { get; set; }

        #endregion

        #region Ctor

        public CommandLineParser(string[] args)
        {
            Arguments = args;
        }

        #endregion

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
