using System;

namespace TriangleSort
{
    public abstract class FigureParser
    {
        #region Properties

        protected string[] Arguments { get; private set; }

        #endregion

        #region Ctor

        public FigureParser(string args)
        {
            Arguments = args.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        #endregion

        public virtual bool IsCorrectArgs()
        {
            return Arguments.Length == Settings.SIDES_NUMBER + 1;
        }

        public virtual string GetName()
        {
            if (Arguments.Length > 0)
            {
                return Arguments[0];
            }
            throw new ArgumentException(Settings.WRONG_NUMBER_OF_ARGS);
        }

        public virtual double[] GetSides()
        {
            double[] sides = new double[Arguments.Length - 1];
            for (int i = 0; i < sides.Length; i++)
            {
                Arguments[i + 1] = Arguments[i + 1].Replace(".", ",");
                if (!double.TryParse(Arguments[i + 1], out sides[i]))
                {
                    throw new FormatException(Settings.INCORRECT_INPUT);
                }
                if (sides[i] <= 0)
                {
                    throw new ArgumentOutOfRangeException(sides[i].ToString(), Settings.NEGATIVE_NUMBER_ERROR);
                }
            }

            return sides;
        }

        public abstract IFigureFactory TryParse();
    }
}
