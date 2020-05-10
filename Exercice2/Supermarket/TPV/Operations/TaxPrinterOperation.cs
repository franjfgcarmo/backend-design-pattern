using System;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public class TaxPrinterOperation : TicketOperation
    {

        public override void Visit(Header head)
        {
            Console.WriteLine($"TAX: Head: {head.Date}");
        }

        public override void Visit(SaleLine saleLine)
        {
            Console.WriteLine($"TAX: Product {saleLine.Id} - {saleLine.Units}units : {saleLine.Price}eu");
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            Console.WriteLine($"TAX: Repetition {repetitionLine.Number}: {repetitionLine.Price}eu");
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            Console.WriteLine($"TAX: Cancelled {cancellationLine.Number}: {cancellationLine.Price}eu");
        }

        public override void Visit(ReturnLine returnLine)
        {
            Console.WriteLine($"TAX: Devoltion {returnLine.Id} - {returnLine.Units}: {returnLine.Price}eu");
        }

        public override void Visit(Footer footer)
        {
            Console.WriteLine($"TAX: Foot: {footer.TotalPrice}");
        }
    }
}
