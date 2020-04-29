using System.Collections.Generic;
using System.Linq;

namespace Tickets.v1.Tickets
{
    public class Ticket
    {
        private readonly Header _header;
        private readonly List<Line> _lineList;
        private readonly Footer _footer;
        private  TicketVisitor _lineTicketOperation;
        private  TicketVisitor _globalTicketOperation;
        public Ticket(Header header, Footer footer)
        {
            _header = header;
            _lineList = new List<Line>();
            _footer = footer;
        }
        public void SetLineTicketOperation(TicketVisitor lineTicketOperation)
        {
            _lineTicketOperation = lineTicketOperation;
        }

        public void SetGlobalTicketOperation(TicketVisitor globalTickeOperation)
        {
            _globalTicketOperation = globalTickeOperation;
        }
        public void Open() => _header.Accept(_lineTicketOperation);

        public void Add(Line line)
        {
            _lineList.Add(line);
           line.Accept(_lineTicketOperation);
        }
        public void Close()
        {
            _footer.Accept(_lineTicketOperation);
            _header.Accept(_globalTicketOperation);
            foreach (var line in _lineList)
            {
                line.Accept(_globalTicketOperation);
            }
            _footer.Accept(_globalTicketOperation);
        }

        public int Lines()=> _lineList.Count();


        public Line GetLine(int number) => _lineList[number];


        public override string ToString() => $"Ticket [\n head={_header}\n, lines={_lineList}\n, footer={_footer}]";

    }
}
