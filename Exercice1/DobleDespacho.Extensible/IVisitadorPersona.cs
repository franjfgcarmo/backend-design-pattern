namespace DobleDespacho.Extensible
{
    public interface IVisitadorPersona
    {
        void Visitar(Mujer mujer);

        void Visitar(Hombre hombre);
    }
}
