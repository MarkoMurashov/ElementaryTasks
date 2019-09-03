using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArgsValidation
{
    public interface IValid
    {
        T GetValidArgs<T>(string[] args) where T : Enum;

        float GetValidFloatArg(string str);

        int GetValidIntArg(string str);

        bool CheckPath(string str);
<<<<<<< HEAD

        int ParsePositiveNumber(string str, int maxValue);

        void ExchangeIntValue(ref int first, ref int second);

        string[] GetValidTriangleArgs(string args);

        double[] GetDoublesFromConsole(string[] str);
=======
>>>>>>> de62eef0f5643959982235afdf2f916c07e519c1
    }
}
