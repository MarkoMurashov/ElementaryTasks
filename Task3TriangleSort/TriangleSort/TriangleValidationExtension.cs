using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleArgsValidation;

namespace TriangleSort
{
    static class TriangleValidationExtension
    {
        public static float[] TryTriangleArgsParse(this IValid valid, string str, out string name)
        {
            string[] parser = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!(parser.Length > 3))
            {
                throw new ArgumentException("Wrong number of args :(");
            }
            name = parser[0];

            float[] sides = new float[parser.Length - 1];
            for (int i = 0; i < sides.Length; i++)
            {
                parser[i + 1] = parser[i + 1].Replace(".", ",");
                sides[i] = valid.GetValidFloatArg(parser[i + 1]);
            }

            if (!Triangle.IsTriangleExist(sides[0], sides[1], sides[2]))
            {
                throw new Exception(Settings.NOT_EXIST);
            }

            return sides; 
        }    
    }
}
