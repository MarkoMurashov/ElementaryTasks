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
    }
}
