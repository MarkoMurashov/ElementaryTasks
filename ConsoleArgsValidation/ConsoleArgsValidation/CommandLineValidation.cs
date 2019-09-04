using System;
using System.IO;

namespace ConsoleArgsValidation
{
    public class CommandLineValidation: IValid
    {
        public T GetValidArgs<T>(string[] args) where T : Enum
        {
            if (!Enum.IsDefined(typeof(T), args.Length))
            {
                throw new Exception("Ooops ... Data was incorrectly entered.");
            }

            return (T)Enum.ToObject(typeof(T), args.Length);
        }

        public float GetValidFloatArg(string str)
        {
            if (!float.TryParse(str, out float result))
            {
                throw new Exception("Wrong float data");
            }
            return result;
        }

        public int GetValidIntArg(string str)
        {
            if (!int.TryParse(str, out int result))
            {
                throw new Exception("Wrong int data");
            }
            return result;
        }

        public bool CheckPath(string str)
        {
            if (!File.Exists(str))
            {
                throw new Exception("Ooops ... Path was incorrectly entered.");
            }
            return true;
        }

<<<<<<< HEAD

=======
>>>>>>> parent of fc07733... Merge branch 'master' of https://github.com/MarkoMurashov/ElementaryTasks
        public int ParsePositiveNumber(string str, int maxValue)
        {
            if (!int.TryParse(str, out int num))
            {
                throw new Exception("Ooops ... Data was incorrectly entered.");
            }
            if (num > maxValue)
            {
                throw new Exception("Very big number :(");
            }
            if (num < 0)
            {
                throw new Exception("Please enter a positive integer number.");
            }

            return num;
        }

        public void ExchangeIntValue(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }

        public string[] GetValidTriangleArgs(string args)
        {
            string[] parser  = args.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!(parser.Length > 3))
            {
                throw new Exception("Wrong number of args :(");
            }           
            return parser;
        }

        public double[] GetDoublesFromConsole(string[] str)
        {
            double[] sides = new double[str.Length-1];
            for (int i = 0; i < sides.Length; i++)
            {
                str[i+1] = str[i + 1].Replace(".", ",");
                if (!double.TryParse(str[i + 1], out sides[i]))
                {
                    throw new Exception("The sides of the triangle are incorrectly entered.");
                }
            }
            

            return sides;
        }

        public bool IsTriangleExist(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }
<<<<<<< HEAD

=======
>>>>>>> parent of fc07733... Merge branch 'master' of https://github.com/MarkoMurashov/ElementaryTasks
    }
}
