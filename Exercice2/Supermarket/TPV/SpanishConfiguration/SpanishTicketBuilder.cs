

using TPV.v1.Countries;
using TPV.v1.Operations;
using TPV.v1.Tickets;

namespace TPV.v1.SpanishConfiguration
{
	public class SpanishTicketBuilder : TicketBuilder
	{
		public SpanishTicketBuilder()
		{
			//Configuro las operacion que va a tener: global y de linea
			TicketOperationComposite lineTicketOperationComposite = new TicketOperationComposite();
			lineTicketOperationComposite.Add(new PriceCalculatorOperation());
			lineTicketOperationComposite.Add(new ClientPrinterOperation());
			lineTicketOperationComposite.Add(new TaxPrinterOperation());
			lineTicketOperation = lineTicketOperationComposite;
			TicketOperationComposite globalTicketOperationComposite = new TicketOperationComposite();
			lineTicketOperationComposite.Add(new PriceCalculatorOperation());
			lineTicketOperationComposite.Add(new ClientPrinterOperation());
			lineTicketOperationComposite.Add(new TaxPrinterOperation());
			globalTicketOperation = globalTicketOperationComposite;
		}

		public override Ticket Build()
		{
			//Construyo el ticket y lo devuelvo.
			Ticket ticket = new Ticket(new SpanishHead(), new SpanishFooter());
			ticket.SetLineTicketOperation(lineTicketOperation);
			ticket.SetGlobalTicketOperation(lineTicketOperation);
			lineTicketOperation.Set(ticket);
			globalTicketOperation.Set(ticket);
			return ticket;
		}
	}
}
