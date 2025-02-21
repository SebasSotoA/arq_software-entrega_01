namespace Solid_Cronometro.Interfaces{
    internal interface IValidaConductor
    {
        bool ValidarNombre(string nombre);
        bool ValidarEdad(byte edad);
        bool ValidarCedula(int cedula);
        bool ValidarLicencia(string licencia);
        bool ValidarSeguro(bool seguro);
    }
}