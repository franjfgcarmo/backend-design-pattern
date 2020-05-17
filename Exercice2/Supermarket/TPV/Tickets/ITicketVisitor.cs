
namespace TPV.v1.Tickets
{
	/// <summary>
	/// Patrón visitor, cada una del parte que tiene que visitar: cabecera, pie, cada linea.
	/// </summary>
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