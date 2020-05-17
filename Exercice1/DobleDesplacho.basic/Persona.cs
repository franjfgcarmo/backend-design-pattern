using System;

namespace DobleDesplacho.basic
{
    public abstract class Persona
    {
        public void Saludar()
        {
            Console.WriteLine("?????????? Soy una persona que saluda al entrar");
        }

        public abstract void Aceptar(Recepcionista recepcionista);
        public void Despedirse()
        {
            Console.WriteLine("?????????? Soy una persona que se despide al salir");
        }
    }
}