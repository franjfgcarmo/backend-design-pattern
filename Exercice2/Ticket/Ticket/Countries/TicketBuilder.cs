using System;
using Tickets.v1.Operations;
using Tickets.v1.Tickets;
using Tickets.v1.Utils;

namespace Tickets.v1.Countries
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