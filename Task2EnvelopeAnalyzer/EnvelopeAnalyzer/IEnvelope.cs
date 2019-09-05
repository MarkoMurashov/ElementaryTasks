namespace EnvelopeAnalyzer
{
    interface IEnvelope
    {
        float Width { get; set; }

        float Length { get; set; }

        Status Compare(IEnvelope second);
    }
}
