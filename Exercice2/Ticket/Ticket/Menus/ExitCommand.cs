namespace Tickets.v1.Menus
{
    public class ExitCommand : Command
    {
        public bool Closed { private set; get; }
        public ExitCommand() : base("salir")
        {
            Reset();
        }

        public override void Execute()
        {
            Ticket.Close();
            Closed = true;
        }
        public void Reset()
        {
            Closed = false;
        }
    }
}