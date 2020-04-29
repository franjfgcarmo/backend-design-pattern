﻿using Tickets.v1.Menus;

namespace Tickets.v1.FrenchConfiguration
{
    public class FrenchMenu : Menu
    {
        protected override void SetCommand()
        {
            commands.Add(new SaleLineCommand());
            commands.Add(new RepetitionLineCommand());
            commands.Add(new CancellationLineCommand());
        }
    }
}
