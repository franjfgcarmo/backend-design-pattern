    namespace Tickets.v1.Tickets
{
    public interface TicketVisitor
    {
		void Visit(Header head);

		void Visit(SaleLine saleLine);

		void Visit(RepetitionLine repetitionLine);
			
		void Visit(CancellationLine cancellationLine);

		void Visit(ReturnLine returnLine);

		void Visit(Footer footer);
	}
}