
namespace EnvelopeAnalyzer
{
    class Envelope
    {
        public float Width { get; set; }

        public float Length { get; set; }

        public Envelope(float width, float length)
        {
            Width = width;
            Length = length;
        }

        public Status Compare(Envelope envelope2)
        {
            if(this < envelope2)
            {
                return Status.FirstInSecond;
            }

            if (envelope2 < this)
            {
                return Status.SecondInFirst;
            }
            if (this == envelope2)
            {
                return Status.Equal;
            }

                return Status.None;            
        }

        #region Operation override

        public static bool operator ==(Envelope first, Envelope second)
        {
            return (first.Width == second.Width && first.Length == second.Width);
        }

        public static bool operator >(Envelope first, Envelope second)
        {
            return ((first.Length > second.Length && first.Width > second.Width)
                 || (first.Length > second.Width && first.Width > second.Length));
        }

        public static bool operator <(Envelope first, Envelope second)
        {
            return ((first.Length < second.Length && first.Width < second.Width)
                 || (first.Length < second.Width && first.Width < second.Length));
        }

        public static bool operator !=(Envelope first, Envelope second)
        {
            return (first.Width != second.Width && first.Length != second.Width);
        }

        #endregion
    }
}
