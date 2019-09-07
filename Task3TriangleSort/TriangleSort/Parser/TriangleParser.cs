using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSort
{
    public class TriangleParser : FigureParser
    {

        public TriangleParser(string  args)
            :base(args)
        {
           
        }

                
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
 