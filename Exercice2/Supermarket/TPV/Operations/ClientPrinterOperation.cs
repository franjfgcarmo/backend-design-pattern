using System;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public class ClientPrinterOperation : TicketOperation
    {

        public override void Visit(Header head)
        {
            Console.WriteLine($"CLI: Head: {head.Date}");
        }

        public override void Visit(SaleLine saleLine)
        {
            Console.WriteLine($"CLI: Product {saleLine.Id} - {saleLine.Units}units : {saleLine.Price}eu");
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            Console.WriteLine($"CLI: Repetition {repetitionLine.Number}: {repetitionLine.Number}eu");
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            Console.WriteLine($"CLI: Cancelled {cancellationLine.Number}: {cancellationLine.Price}eu");
        }

        public override void Visit(ReturnLine returnLine)
        {
            Console.WriteLine($"CLI: Devoltion {returnLine.Id} - {returnLine.Units}: {returnLine.Price}eu");
        }

        public override void Visit(Footer footer)
        {
            Console.WriteLine($"CLI: Foot: {footer.TotalPrice}");
        }

    }
}
