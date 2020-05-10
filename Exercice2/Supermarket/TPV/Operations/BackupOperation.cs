using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public class BackupOperation : TicketOperation
    {
        public override void Visit(Header head)
        {
        }

        public override void Visit(SaleLine line)
        {
        }

        public override void Visit(RepetitionLine line)
        {
        }

        public override void Visit(CancellationLine line)
        {
        }

        public override void Visit(ReturnLine line)
        {
        }

        public override void Visit(Footer footer)
        {
        }
    }
}
