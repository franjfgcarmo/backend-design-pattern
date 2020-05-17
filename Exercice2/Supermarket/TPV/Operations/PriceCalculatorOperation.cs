using TPV.v1.Stores;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    /// <summary>
    /// Calculate the price of the products.
    /// </summary>
    public class PriceCalculatorOperation : TicketOperation
    {
        public override void Visit(SaleLine saleLine)
        {
            int price = Store.Instance().GetPrice(saleLine.Id, saleLine.Units);
            saleLine.Price = price;
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            SaleLine line = (SaleLine)ticket.GetLine(repetitionLine.Number);
            int price = Store.Instance().GetPrice(line.Id, line.Units);
            repetitionLine.Price = price;
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            SaleLine line = (SaleLine)ticket.GetLine(cancellationLine.Number);
            int price = Store.Instance().GetPrice(line.Id, line.Units);
            cancellationLine.Price = price;
        }

        public override void Visit(ReturnLine returnLine)
        {
            int price = Store.Instance().GetPrice(returnLine.Id, returnLine.Units);
            returnLine.Price = -price;
        }
    }
}
