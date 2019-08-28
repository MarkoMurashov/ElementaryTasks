using System;
using System.IO;

using Assistant;

namespace FileParser
{
    class Helper
    {
        public static int SearchSubstring(string path, string substring)
        {
            int result = 0;
            if (Validator.IsFileExist(path))
            {
                using (StreamReader reading = new StreamReader(path))
                {
                    string str;
                    while ((str = reading.ReadLine()) != null)
                    {
                        if (str.Contains(substring))
                        {
                            result += str.Split(new string[] { substring }, StringSplitOptions.None).Length - 1;
                        }
                    }                   
                }
            }

                return result;                         
        }

        public static void ReplaceStringInFile(string path, string oldstring, string newstring)
        {
            if (Validator.IsFileExist(path) && SearchSubstring(path,oldstring)>0)
            {
                string[] allStrings = File.ReadAllLines(path);
                using (StreamWriter write = new StreamWriter(path))
                {
                    foreach (var str in allStrings)
                    {                       
                       write.WriteLine(str.Replace(oldstring, newstring));                                                 
                    }

                }
                UI.ShowMessageWithNewLine(Settings.DONE);
            }
            else
            {
                ShowAnswer();
            }
        }

        public static void ShowAnswer(int answer=0)
        {
            if (answer > 0)
            {
                UI.ShowMessageWithNewLine(answer.ToString() + Settings.MATCH);
            }
            else
            {
                UI.ShowMessageWithNewLine(Settings.NO_MATCH);               
            }
        }

    }
}
