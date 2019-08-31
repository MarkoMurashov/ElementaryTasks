using Boards.Enums;

namespace Boards.Interfaces
{
    interface IValid
    {
        Operation GetValidArgs(string[] args);
    }
}
