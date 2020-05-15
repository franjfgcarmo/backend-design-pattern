using System;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public class ScreenViewerOperation : TicketOperation
    {
        public override void Visit(Header head)
        {
            Console.WriteLine($"SCR: Head: {head.Date}");
        }

        public override void Visit(SaleLine saleLine)
        {
            Console.WriteLine($"SCR: Product {saleLine.Id} - {saleLine.Units}units : {saleLine.Price}eu");
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            Console.WriteLine($"SCR: Repetition {repetitionLine.Number}: {repetitionLine.Price}eu");
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            Console.WriteLine($"SCR: Cancelled {cancellationLine.Number}: {cancellationLine.Price}eu");
        }

        public override void Visit(ReturnLine returnLine)
        {
            Console.WriteLine($"SCR: Devoltion {returnLine.Id} - {returnLine.Units}: {returnLine.Price}eu");
        }

        public override void Visit(Footer footer)
        {
            Console.WriteLine($"SCR: Foot: {footer.TotalPrice}");
        }
    }
}
