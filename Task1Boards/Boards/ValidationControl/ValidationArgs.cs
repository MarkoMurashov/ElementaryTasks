using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Boards.Interfaces;
using Boards.Enums;

namespace Boards.ValidationControl
{
    class ValidationArgs: IValid
    {
        public Operation GetValidArgs(string[] args)
        {
            if (!Enum.IsDefined(typeof(Operation), args.Length))
            {
                throw new Exception(Settings.WRONG_NUMBER_OF_ARGS);
            }

            return (Operation)Enum.ToObject(typeof(Operation), args.Length);
        }
    }
}
