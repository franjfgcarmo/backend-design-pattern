using System;
using System.Configuration;
using TPV.v1.Menus;
using TPV.v1.Tickets;

namespace TPV.v1.Countries
{
    public abstract class CountryFactory
	{
		private static CountryFactory _countryFactory;
		/// <summary>
		/// Un singleton, se hace cuando se quiere que sea global y único. En este caso se ha hecho para que sea unico.
		/// Según la teoría de abstract factory, se debería haber creado un CreateMenu y un CreateTicket, pero no se ha 
		/// hecho porque lo patrones hay que retorcelos y adaptarlos a las necesidades.
		/// Se han creado dos atributo: Menu y ticket, se han rellenado en la clase derivada .
		/// El objetivo del abstract factory es que cada vez que le pidan un menú, es devolver uno menú, otro menú, otro menú, etc. En nuestro caso
		/// en nuestro caso tenemos un menú que lo pedimos una vez.
		/// </summary>
		/// <returns></returns>
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
