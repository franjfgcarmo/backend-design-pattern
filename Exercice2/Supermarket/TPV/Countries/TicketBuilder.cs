using System;
using TPV.v1.Operations;
using TPV.v1.Tickets;
using TPV.v1.Utils;

namespace TPV.v1.Countries
{
    public abstract class TicketBuilder
	{
		private static TicketBuilder ticketBuilder;

		public static TicketBuilder instance()
		{
			if (ticketBuilder == null)
			{
				// TODO ficher configuración
				string nameTicketBuilder = "desingPatterns.exercises.n2.tickets.v5.spanishConfiguration.SpanishTicketBuilder";
				try
				{

					ticketBuilder = (TicketBuilder)Activator.CreateInstance(Type.GetType(nameTicketBuilder));
				}
				catch (Exception)
				{
					IO.Instance().Write("TicketBuilder desconocido");
				}
			}
			return ticketBuilder;
		}

		protected TicketOperation lineTicketOperation;

		protected TicketOperation globalTicketOperation;

		public abstract Ticket Build();
	}
}