
namespace EnvelopeAnalyzer
{
    static class Helper
    {
        static Envelope[] envelopes = new Envelope[Envelope.QUANTITY];
        static void CreateEnvelopes()
        {
            for (int i = 0; i < envelopes.Length; i++)
            {
                envelopes[i] = new Envelope(Validator.CheckData(string.Format(Settings.WIDTH, i + 1)),
                                        Validator.CheckData(string.Format(Settings.LENGTH, i + 1)));
            }
        }

        public static void AnalyzeEnvelopes()
        {
            CreateEnvelopes();
            UI.ShowAnswer(envelopes[0].Compare(envelopes[1]));
        }

        public static bool ContinueWork()
        {
            UI.ShowMessage(Settings.CONTINUE);
            string agrement = UI.ReadData().ToUpper();

            return agrement == Settings.SMALL_YES || agrement == Settings.BIG_YES;
        }
    }
}
