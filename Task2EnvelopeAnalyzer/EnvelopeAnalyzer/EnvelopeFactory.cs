using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnvelopeAnalyzer.Interfaces;

namespace EnvelopeAnalyzer
{
    class EnvelopeFactory: IEnvelopeCreate
    {
        public Envelope Create(float width, float length)
        {
            return new Envelope(width, length);
        }
    }
}
