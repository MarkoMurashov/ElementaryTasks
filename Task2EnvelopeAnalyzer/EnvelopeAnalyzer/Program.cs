using Assistant;

using EnvelopeAnalyzer.Interfaces;

namespace EnvelopeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Helper.AnalyzeEnvelopes();
            //} while (Assistant.Helper.ContinueWork(Settings.CONTINUE));

            IEnvelopeCreate factory = new EnvelopeFactory();

            Envelope first = factory.Create(2, 3);
            Envelope second = factory.Create(3, 4);

        }
    }
}
