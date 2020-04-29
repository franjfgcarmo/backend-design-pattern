using TPV.v1.Tickets;

namespace TPV.v1.Menus
{
    public abstract class Command
    {
        public Ticket Ticket { set; protected get; }
        private string title;
        protected Command(string title) { }
        public string Title
        {
            get
            {
                return title;
            }
        }
        public abstract void Execute();
        public void Set(Ticket ticket)
        {
            Ticket = ticket;
        }
    }
}
