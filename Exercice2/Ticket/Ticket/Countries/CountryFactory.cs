using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.v1.SpanishConfiguration;

namespace Tickets.v1.Countries
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
		public abstract Menu GetMenu();
        public  abstract Ticket GetTicket();
    }
}
