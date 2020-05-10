using System;
using TPV.v1.Countries;

namespace TPV.v1.FrenchConfiguration
{
    public class FrenchFactory : CountryFactory
    {
        public FrenchFactory()
        {
            Menu = new FrenchMenu();
            ticketBuilder = new FrenchTicketBuilder();
        }
    }
}
