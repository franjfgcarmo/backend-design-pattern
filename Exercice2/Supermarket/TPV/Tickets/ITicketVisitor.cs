
namespace TPV.v1.Tickets
{
    public interface ITicketVisitor
	{
		void Visit(Header head);

		void Visit(SaleLine saleLine);

		void Visit(RepetitionLine repetitionLine);

		void Visit(CancellationLine cancellationLine);

		void Visit(ReturnLine returnLine);

		void Visit(Footer footer);
	}
}