using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArgsValidation
{
    public interface IValid
    {
        T GetValidOperation<T>(string[] args) where T : Enum;

        float GetValidFloatArg(string str);

        int GetValidIntArg(string str);

        byte GetValidByteArg(string str);

        bool GetValidPath(string str);

    }
}
