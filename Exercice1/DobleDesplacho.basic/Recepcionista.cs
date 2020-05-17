using System;

namespace DobleDesplacho.basic
{
    public class Recepcionista
    {
        public Recepcionista()
        {
        }

        public void Recibir(Persona persona)
        {
            Console.WriteLine("!!!!!!!!!! Soy un recpcionista que se alegra de su visita");
            persona.Aceptar(this);
        }

        public void Visitar(Mujer mujer)
        {
            Console.WriteLine("!!!!!!!!!! Soy un recpcionista que se admira de su belleza");
            mujer.EscucharHalago();
            Console.WriteLine("!!!!!!!!!! Soy un recpcionista que se admira de su existencia");
            mujer.EscucharPiropo();
        }

        public void Visitar(Hombre hombre)
        {
            hombre.RecibirPalmada(this);
        }

        public void RecibirPropina(int euros)
        {
            Console.WriteLine($"!!!!!!!!!! Soy un recpcionista que gané {euros} euros");
        }

        public void AgradecerVisita()
        {
            Console.WriteLine("!!!!!!!!!! Soy un recpcionista que agradece la visita");
        }
    }
}