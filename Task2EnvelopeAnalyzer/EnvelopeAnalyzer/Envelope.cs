
namespace EnvelopeAnalyzer
{
    class Envelope
    {
        public const int QUANTITY = 2;
        double Width { get; set; }

        double Length { get; set; }


        public Envelope(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public bool Compare(Envelope envelope2)
        {
            return ((this.Length < envelope2.Length && this.Width < envelope2.Width)
                 || (this.Length < envelope2.Width && this.Width < envelope2.Length)
                 || (envelope2.Length < this.Length && envelope2.Width < this.Width)
                 || (envelope2.Length < this.Width && envelope2.Width < this.Length));
            
        }
    }
}
