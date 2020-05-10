using TPV.v1.SpanishConfiguration;
using TPV.v1.Tickets;

namespace TPV.v1.Countries
{
    public abstract class CountryFactory
	{
		private static CountryFactory countryFactory;
		public static CountryFactory Instance()
		{
			if (countryFactory == null)
			{
				countryFactory = new SpanishFactory();
			}
			return countryFactory;
		}
		protected CountryFactory()
		{

		}
		public Menu Menu { protected set; get; }
		protected TicketBuilder ticketBuilder;

		public Ticket GetTicket()
		{
			return ticketBuilder.Build();
		}
	}
}
