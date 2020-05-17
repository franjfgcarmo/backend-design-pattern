using System;

namespace DobleDespacho.v1
{
    public class Hombre : Persona
    {
        public void RecibirPalmada(Recepcionista recepcionista)
        {
            Console.WriteLine("---------- Soy un hombre lleno de vanidad");
            recepcionista.RecibirPropina(3);
        }
    }
}