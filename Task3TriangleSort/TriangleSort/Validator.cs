using System;
using Assistant;

namespace TriangleSort
{
    static class Validator
    {
        public static bool IsTriangleExist(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        public static double ChageToDouble(this string str)
        {
            double result;
            str = str.Replace(".", ",");
            if (!double.TryParse(str, out result))
            {
                UI.ShowMessageWithNewLine(Settings.INCORRECT_INPUT);
            }

            return result;
        }

        public static bool RightLength(string[] args)
        {
            return args.Length > 3;
        }

        public static bool CheckTriangleIngo(out string[] args)
        {
            args = UI.ReadData().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            if (!RightLength(args))
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_NUMBER_OF_ARGS);
                return false;
            }
            if (!IsTriangleExist(args[1].ChageToDouble(), args[2].ChageToDouble(), args[3].ChageToDouble()))
            {
                UI.ShowMessageWithNewLine(Settings.NOT_EXIST);
                return false;
            }
            return true;

        }
    }
}
