using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.v1
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
		public abstract Menu CreateMenu();
        public  abstract Ticket CreateTicket();
    }
}
