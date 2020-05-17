using System;

namespace DobleDespacho.Extensible
{
    public class Hombre : Persona
    {
        public override void Aceptar(IVisitadorPersona visitadorPersona)
        {
            visitadorPersona.Visitar(this);
        }

        public void RecibirPalmada(Recepcionista recepcionista)
        {
            Console.WriteLine("---------- Soy un hombre lleno de vanidad");
            recepcionista.RecibirPropina(3);
        }
    }
}