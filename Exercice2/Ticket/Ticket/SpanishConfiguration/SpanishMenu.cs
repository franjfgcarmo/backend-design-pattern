using Tickets.v1.Menus;

namespace Tickets.v1.SpanishConfiguration
{
    public class SpanishMenu : Menu
    {
        protected override void SetCommand()
        {
            commands.Add(new SaleLineCommand());
            commands.Add(new RepetitionLineCommand());
            commands.Add(new ReturnLineCommand());
            commands.Add(new CancellationLineCommand());
        }
    }
}
