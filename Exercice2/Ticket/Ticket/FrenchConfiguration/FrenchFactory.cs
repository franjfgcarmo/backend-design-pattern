using System;
using Tickets.v1.Countries;

namespace Tickets.v1.FrenchConfiguration
{
    public class FrenchFactory : CountryFactory
    {
        public override Menu GetMenu()
        {
            throw new NotImplementedException();
        }

        public override Ticket GetTicket()
        {
            throw new NotImplementedException();
        }
    }
}
