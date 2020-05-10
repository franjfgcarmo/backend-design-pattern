using System;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public class DisplayViewerOperation : TicketOperation
    {

        public override void Visit(Header head)
        {
            Console.WriteLine($"DIS: Head: {head.Date}");
        }

        public override void Visit(SaleLine saleLine)
        {
            Console.WriteLine($"DIS: Product {saleLine.Id} - {saleLine.Units}units : {saleLine.Price}eu");
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            Console.WriteLine($"DIS: Repetition {repetitionLine.Number}: {repetitionLine.Price}eu");
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            Console.WriteLine($"DIS: Cancelled {cancellationLine.Number}: {cancellationLine.Price}eu");
        }

        public override void Visit(ReturnLine returnLine)
        {
            Console.WriteLine($"DIS: Devoltion {returnLine.Id} - {returnLine.Units}: {returnLine.Price}eu");
        }

        public override void Visit(Footer footer)
        {
            Console.WriteLine($"DIS: Foot: {footer.TotalPrice}");
        }
    }
}
