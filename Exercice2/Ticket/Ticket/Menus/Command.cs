namespace Tickets.v1.Menus
{
    public abstract class Command
    {
        public Ticket Ticket { set; protected get; }
        private string title;
        protected Command(string title) { }
        public string Title { 
            get{
                return title;
            }
        }
        protected abstract void Execute();
    }
}
