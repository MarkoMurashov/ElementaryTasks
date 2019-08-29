using System.IO;


namespace FileParser
{
    class Replacer: IReplace
    {
        public void ReplaceStringInFile(string path, string oldstring, string newstring)
        {
            bool noMatch = true;
            var allStrings = File.ReadAllLines(path);
            using (StreamWriter write = new StreamWriter(path))
            {
                foreach (var str in allStrings)
                {
                    if (str.Contains(oldstring) && noMatch)
                    {
                        noMatch = false;
                    }
                    write.WriteLine(str.Replace(oldstring, newstring));
                }

            }

            if (noMatch)
            {
                throw new System.Exception(Settings.NO_MATCH);
            }
        }
    }
}
