using TPV.v1.Countries;
using TPV.v1.Operations;
using TPV.v1.Tickets;

namespace TPV.v1.FrenchConfiguration
{
    public class FrenchTicketBuilder : TicketBuilder
    {
        public FrenchTicketBuilder()
        {
            lineTicketOperation = new PriceCalculatorOperation();
            TicketOperationComposite globalTicketOperationComposite = new TicketOperationComposite();
            globalTicketOperationComposite.Add(new PriceCalculatorOperation());
            globalTicketOperationComposite.Add(new TaxPrinterOperation());
            globalTicketOperation = globalTicketOperationComposite;
        }

        public override Ticket Build()
        {
            Ticket ticket = new Ticket(new FrenchHead(), new FrenchFooter());
            ticket.SetLineTicketOperation(lineTicketOperation);
            ticket.SetGlobalTicketOperation(lineTicketOperation);
            lineTicketOperation.Set(ticket);
            globalTicketOperation.Set(ticket);
            return ticket;
        }
    }
}