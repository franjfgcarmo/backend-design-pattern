using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.v1
{
    public class Supermarket
    {
        public void Sell() {
            bool close = false;
            do
            {
                Ticket ticket = CountryFactory.Instance().CreateTicket();
                //Abstract Factory
                Menu menu = CountryFactory.Instance().CreateMenu();
                menu.Execute(ticket);

            } while (!close);
        }
    }
}
