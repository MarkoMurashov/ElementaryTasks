using System;

using ConsoleArgsValidation;

namespace EnvelopeAnalyzer
{
    class Envelope: IEnvelope
    {
        public float Width { get; set; }

        public float Length { get; set; }

        private Envelope(float width, float length)
        {
            Width = width;
            Length = length;
        }

        public Status Compare(IEnvelope second)
        {
            if ((Length > second.Length && Width > second.Width)
                 || (Length > second.Width && Width > second.Length))
            {
                return Status.FirstInSecond;
            }

            if ((Length < second.Length && Width < second.Width)
                 || (Length < second.Width && Width < second.Length))
            {
                return Status.SecondInFirst;
            }
            if (Width == second.Width && Length == second.Width)
            {
                return Status.Equal;
            }

                return Status.None;            
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
