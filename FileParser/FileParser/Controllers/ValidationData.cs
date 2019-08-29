using System;
using System.IO;


namespace FileParser
{
    static class ValidationData
    {
        public static string CheckPath(this string str)
        {
            if (!File.Exists(str))
            {
                throw new Exception(Settings.WRONG_PATH);
            }
            return str;
        }
    }
}
