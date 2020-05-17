using System;

namespace DobleDespacho.v1
{
    public class Recepcionista
    {
        public Recepcionista()
        {
        }

        public void Recibir(Persona persona)
        {
            Console.WriteLine("!!!!!!!!!! Soy un recpcionista que se alegra de su visita");
            if (persona is Mujer)
            {
                Console.WriteLine("!!!!!!!!!! Soy un recpcionista que se admira de su belleza");
                ((Mujer)persona).EscucharHalago();
                Console.WriteLine("!!!!!!!!!! Soy un recpcionista que se admira de su existencia");
                ((Mujer)persona).EscucharPiropo();
            } else
            {
                ((Hombre)persona).RecibirPalmada(this);
            }
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