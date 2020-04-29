﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV.v1.Countries;
using TPV.v1.Tickets;

namespace TPV.v1
{
    public class Supermarket
    {
        private const double CLOSING_TIME = 20.0;
        private Menu menu;

        public Supermarket()
        {
            menu = CountryFactory.Instance().Menu;
        }
        public void Sell()
        {
            Clock clock = new Clock();
            bool close = false;
            do
            {
                Ticket ticket = CountryFactory.Instance().GetTicket();
                //Abstract Factory
                ticket.Close();
                menu.Execute(ticket);

            } while (!clock.IsNowOrLater(CLOSING_TIME));
        }
    }
}
