using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalyzer.Interfaces
{
    interface IEnvelopeCreate
    {
        Envelope Create(float width, float height);
    }
}
