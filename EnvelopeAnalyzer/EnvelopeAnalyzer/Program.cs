using Assistant;

namespace EnvelopeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Helper.AnalyzeEnvelopes();
            } while (Assistant.Helper.ContinueWork(Settings.CONTINUE));
        }
    }
}
