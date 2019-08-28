
namespace FileParser
{
    class Settings
    {
        public const string WRONG_PATH = "Ooops ... Path was incorrectly entered.";

        public const string INSTRUCTION = @"The program has two modes:
- Read the number of occurrences of a line in a text file.
- Do replace the string with another in the specified file
The program should accept input arguments at startup:
<file path> <line for counting>
<file path> <search string> <replacement string>";

        public const string NO_MATCH = "No matching in the file";

        public const string MATCH = " matching in the file";

        public const string WRONG_NUMBER_OF_ARGS = "Wrong number of args :(";

        public const string DONE = "Done";
    }
}
