using System;

using ConsoleArgsValidation;

namespace EnvelopeAnalyzer
{
    class EnvelopeFactory
    {
        private EnvelopeFactory()
        {

        }

        public static Envelope Create(IValid valid, float width, float length)
        {
            if(width <= 0.0 || length <= 0.0)
            {
                throw new Exception(Settings.NEGATIVE_DATA);
            }

            return new Envelope(width, length);
        }
    }
}
