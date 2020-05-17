using System;

namespace DobleDespacho.Extensible
{
    public class Camarero : IVisitadorPersona
    {
        public void Servir(Persona persona)
        {
            persona.Aceptar(this);
        }
        public void Visitar(Mujer mujer)
        {
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡ Soy un camarero que invita a un coktail");
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡ Soy un camarero que entrega la comida");
        }

        public void Visitar(Hombre hombre)
        {
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡ Soy un camarero que entrega la comida");
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡ Soy un camarero que invita a un coñac");
        }

        public void Recoger()
        {
            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡ Soy un camarero que recoge la mesa");
        }
    }
}
