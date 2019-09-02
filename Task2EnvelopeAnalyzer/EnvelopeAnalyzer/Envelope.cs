
namespace EnvelopeAnalyzer
{
    class Envelope
    {
        public const int QUANTITY = 2;
        public float Width { get; set; }

        public float Length { get; set; }

        public Envelope(float width, float length)
        {
            Width = width;
            Length = length;
        }
        
        public static bool operator ==(Envelope first, Envelope second)
        {
            return (first.Width == second.Width && first.Length == second.Width);
        }

        public static bool operator >(Envelope first, Envelope second)
        {
            return (first.Width > second.Width && first.Length > second.Width);
        }

        public static bool operator <(Envelope first, Envelope second)
        {
            return (first.Width < second.Width && first.Length < second.Width);
        }

        public static bool operator !=(Envelope first, Envelope second)
        {
            return (first.Width != second.Width && first.Length != second.Width);
        }
    }
}
