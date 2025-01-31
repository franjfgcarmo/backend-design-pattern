﻿using TPV.v1.Menus;

namespace TPV.v1.SpanishConfiguration
{
    public class SpanishMenu : Menu
    {
        //Se agrega los comandos que necesita cada pais.
        protected override void SetCommand()
        {
            commands.Add(new SaleLineCommand());
            commands.Add(new RepetitionLineCommand());
            commands.Add(new ReturnLineCommand());
            commands.Add(new CancellationLineCommand());
        }
    }
}
