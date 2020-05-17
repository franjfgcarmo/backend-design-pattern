using System.Collections.Generic;
using System.Linq;

namespace TPV.v1.Tickets
{
    public class Ticket
    {
        private readonly Header _header;
        private readonly List<Line> _lineList;
        private readonly Footer _footer;
        private ITicketVisitor _lineTicketOperation;
        private ITicketVisitor _globalTicketOperation;
        public Ticket(Header header, Footer footer)
        {
            _header = header;
            _lineList = new List<Line>();
            _footer = footer;
        }
        public void SetLineTicketOperation(ITicketVisitor lineTicketOperation)
        {
            _lineTicketOperation = lineTicketOperation;
        }

        public void SetGlobalTicketOperation(ITicketVisitor globalTickeOperation)
        {
            _globalTicketOperation = globalTickeOperation;
        }
        #region [Visitor]
        /*
         * Cuando se creaa la cabecera, el pie y cada linea, se llama al pratrón visitor.
         * Acepta la visitor
         */
        public void Open() => _header.Accept(_lineTicketOperation);

        public void Add(Line line)
        {
            _lineList.Add(line);
            line.Accept(_lineTicketOperation);
        }
        public void Close()
        {
            //Acept the global operations.
            _footer.Accept(_lineTicketOperation);
            _header.Accept(_globalTicketOperation);
            foreach (var line in _lineList)
            {
                line.Accept(_globalTicketOperation);
            }
            _footer.Accept(_globalTicketOperation);
        }
        #endregion


        public int Lines() => _lineList.Count();


        public Line GetLine(int number) => _lineList[number];


        public override string ToString() => $"Ticket [\n head={_header}\n, lines={_lineList}\n, footer={_footer}]";

    }
}
