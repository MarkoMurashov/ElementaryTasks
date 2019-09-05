using System;

using ConsoleArgsValidation;
namespace Task6TicketAnalyzer
{
    static class ParametrsParser
    {
        public static byte TryPowerParse(this IValid valid, string str)
        {
            byte power = valid.
               GetValidByteArg(str);
            if(power % 2 == 1)
            {
                throw new Exception(Settings.LENGTH_ERROR);
            }
            if (power > 6)
            {
                throw new Exception(Settings.VALUE_ERROR);
            }

            return power;
        }
    }
}
