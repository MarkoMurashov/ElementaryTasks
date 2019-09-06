using System;
using System.IO;

namespace ConsoleArgsValidation
{
    public class CommandLineValidation : IValid
    {
        public T GetValidOperation<T>(string[] args) where T : Enum
        {
            if (!Enum.IsDefined(typeof(T), args.Length))
            {
                throw new FormatException("Ooops ... Data was incorrectly entered.");
            }

            return (T)Enum.ToObject(typeof(T), args.Length);
        }

        public float GetValidFloatArg(string str)
        {
            if (!float.TryParse(str, out float result))
            {
                throw new FormatException("Wrong float data");
            }
            return result;
        }

        public int GetValidIntArg(string str)
        {
            if (!int.TryParse(str, out int result))
            {
                throw new FormatException("Wrong int data");
            }
            return result;
        }

        public byte GetValidByteArg(string str)
        {
            if (!byte.TryParse(str, out byte result))
            {
                throw new FormatException("Wrong byte data");
            }
            return result;
        }

        public bool GetValidPath(string str)
        {
            if (!File.Exists(str))
            {
                throw new FormatException("Ooops ... Path was incorrectly entered.");
            }
            return true;
        }


    }
}

