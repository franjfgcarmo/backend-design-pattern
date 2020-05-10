using TPV.v1.Tickets;

namespace TPV.v1.Menus
{
    public abstract class Command
    {
        public Ticket Ticket { set; protected get; }

        protected Command(string title)
        {
            Title = title;
        }

        public string Title { get; }
        public abstract void Execute();
        public void Set(Ticket ticket)
        {
            Ticket = ticket;
        }
    }
}
