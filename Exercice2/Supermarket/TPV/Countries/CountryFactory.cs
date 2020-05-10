using System;
using System.Configuration;
using TPV.v1.Menus;
using TPV.v1.Tickets;

namespace TPV.v1.Countries
{
    public abstract class CountryFactory
	{
		private static CountryFactory _countryFactory;
		public static CountryFactory Instance()
		{
			if (_countryFactory == null)
			{
				var country = SingletonConfigure;
				try
				{
					_countryFactory = (CountryFactory)(Activator.CreateInstance(Type.GetType($"TPV.v1.{country}")));
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
					Console.Write(e.StackTrace);
				}				
			}
			return _countryFactory;
		}
		private static string SingletonConfigure
		{
			get
			{
				string line = "";
				try
				{

					line = ConfigurationManager.AppSettings["factoryMethod"];
				}
				catch (Exception ex)
				{
					Console.WriteLine("IOException al leer: " + ex.Message);
				}

				return line;
			}
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
