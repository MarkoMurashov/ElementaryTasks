using ViewController;

namespace Task6TicketAnalyzer
{
    static class ViewExtension
    {
        public static void PrintLuckyTicket(this IView view, Ticket ticket)
        {
            view.Display(string.Format(Settings.LUCKY_TICKET_AMOUNT, ticket.GetAllLuckyNumber()));
        }
    }
}
