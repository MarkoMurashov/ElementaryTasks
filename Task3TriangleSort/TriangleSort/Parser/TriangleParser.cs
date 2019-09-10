using System;

namespace TriangleSort
{
    public class TriangleParser : FigureParser
    {
        #region Ctor 

        public TriangleParser(string args)
            : base(args)
        {

        }

        #endregion

        public override IFigureFactory TryParse()
        {
            if (!IsCorrectArgs())
            {
                throw new ArgumentException(Settings.WRONG_NUMBER_OF_ARGS);
            }

            double[] sides = GetSides();
            string name = GetName();

            if (!Triangle.IsTriangleExist(sides[0], sides[1], sides[2]))
            {
                throw new ArgumentException(Settings.NOT_EXIST);
            }

            return new TriangleFactory(name, sides);
        }
    }
}
