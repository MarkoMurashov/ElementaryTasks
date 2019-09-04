using System;

using ConsoleArgsValidation;

namespace EnvelopeAnalyzer
{
    class EnvelopeFactory
    {
        private EnvelopeFactory()
        {

        }

        public static Envelope Create(IValid valid, string strWidth, string strLength)
        {
            float width = valid.GetValidFloatArg(strWidth);

            float length = valid.GetValidFloatArg(strLength);
            if (width <= 0.0 || length <= 0.0)
            {
                throw new Exception(Settings.NEGATIVE_DATA);
            }

            return new Envelope(width, length);
        }
    }
}
