using System;
using System.Configuration;
using TPV.v1.Operations;
using TPV.v1.Tickets;
using TPV.v1.Utils;

namespace TPV.v1.Countries
{
    public abstract class TicketBuilder
	{
		private static TicketBuilder _ticketBuilder;

		public static TicketBuilder instance()
		{
			if (_ticketBuilder == null)
			{
				try
				{

					_ticketBuilder = (TicketBuilder)Activator.CreateInstance(Type.GetType(SingletonConfigure));
				}
				catch (Exception)
				{
					IO.Instance().Write("TicketBuilder desconocido");
				}
			}
			return _ticketBuilder;
		}
		private static string SingletonConfigure
		{
			get
			{
				string line = "";
				try
				{

					line = ConfigurationManager.AppSettings["TicketBuilder"];
				}
				catch (Exception ex)
				{
					Console.WriteLine("IOException al leer: " + ex.Message);
				}

				return line;
			}
		}
		protected TicketOperation lineTicketOperation;

		protected TicketOperation globalTicketOperation;

		public abstract Ticket Build();
	}
}