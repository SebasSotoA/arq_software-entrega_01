namespace Solid_Cronometro.Interfaces
{
    internal interface IObtenerConductor
    {
        string GetNombre();
        byte GetEdad();
        string GetCedula();
        string GetLicencia();
        bool GetSeguro();
    }
}