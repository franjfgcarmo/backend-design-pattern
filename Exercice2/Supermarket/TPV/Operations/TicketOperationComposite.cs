using System.Collections.Generic;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    /// <summary>
    /// En esta clase se implemente el composite. No se implementa el método remove del patrón porque no se necesita.
    /// </summary>
    public class TicketOperationComposite : TicketOperation
    {
        private List<TicketOperation> ticketOperationList;

        public TicketOperationComposite()
        {
            ticketOperationList = new List<TicketOperation>();
        }
        /// <summary>
        /// Agrega el listado de operaciones.
        /// </summary>
        /// <param name="ticketOperation"></param>
        public void Add(TicketOperation ticketOperation)
        {
            ticketOperationList.Add(ticketOperation);
        }
        /// <summary>
        /// Asocio las lineas al ticket
        /// </summary>
        /// <param name="ticket"></param>
        public override void Set(Ticket ticket)
        {
            base.Set(ticket);
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Set(ticket);
            }
        }
        #region [Composite]
        /*
        * Aqui si me visita una linea de cabecera, le dijo a todas mis operaciones que visiten la cabecera,
        * si me visita una linea de venta, le digo a todas mis operaciones que visiten la linea de venta.....
        * ......
        */
        /// <param name="head"></param>
        public override void Visit(Header head)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(head);
            }
        }

        public override void Visit(SaleLine saleLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(saleLine);
            }
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(repetitionLine);
            }
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(cancellationLine);
            }
        }

        public override void Visit(ReturnLine returnLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(returnLine);
            }
        }

        public override void Visit(Footer footer)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(footer);
            }
        }
        #endregion

    }
}
