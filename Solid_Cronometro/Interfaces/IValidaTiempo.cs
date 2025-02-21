namespace Solid_Cronometro.Interfaces{
    internal interface IValidaTiempo
    {
        bool ValidarInicio(long inicio);
        bool ValidarFin(long fin);
    }
}