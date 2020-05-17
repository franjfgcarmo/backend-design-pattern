using System;

namespace DobleDespacho.Extensible
{
    public abstract class Persona
    {
        public void Saludar()
        {
            Console.WriteLine("?????????? Soy una persona que saluda al entrar");
        }
        public void Pedir()
        {
            Console.WriteLine("?????????? Soy una persona que pide un menú");
        }
        public abstract void Aceptar(IVisitadorPersona visitadorPersona);
        public void Despedirse()
        {
            Console.WriteLine("?????????? Soy una persona que se despide al salir");
        }
    }
}