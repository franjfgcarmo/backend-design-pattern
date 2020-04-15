using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.v1
{
    public class FrenchFactory : CountryFactory
    {
        public override Menu CreateMenu()
        {
            throw new NotImplementedException();
        }

        public override Ticket CreateTicket()
        {
            throw new NotImplementedException();
        }
    }
}
