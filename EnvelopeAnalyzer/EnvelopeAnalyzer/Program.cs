
namespace EnvelopeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Helper.AnalyzeEnvelopes();
            } while (Helper.ContinueWork());
        }
    }
}
