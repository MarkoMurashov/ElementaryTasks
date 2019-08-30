using System;

using Task4FileParser.Interfaces;

namespace Task4FileParser
{
    class ValidationArgs: IValid
    {
        public Operation GetValidArgs(string[] args)
        {
            if (!Enum.IsDefined(typeof(Operation), args.Length))
            {
                throw new Exception(Settings.WRONG_NUMBER_OF_ARGS);
            }

            return (Operation)Enum.ToObject(typeof(Operation), args.Length);
        }
    }
}
