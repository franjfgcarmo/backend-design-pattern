using System;

namespace DobleDesplacho.basic
{
    public class Hombre : Persona
    {
        /// <summary>
        /// Dice visitame a mí al recepcionista(voz de hombre)
        /// </summary>
        /// <param name="recepcionista"></param>
        public override void Aceptar(Recepcionista recepcionista)
        {
            recepcionista.Visitar(this);
        }

        public void RecibirPalmada(Recepcionista recepcionista)
        {
            Console.WriteLine("---------- Soy un hombre lleno de vanidad");
            recepcionista.RecibirPropina(3);
        }
    }
}