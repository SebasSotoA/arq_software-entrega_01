namespace Solid_Cronometro.Interfaces{
    internal interface IObtenerConductor
    {
        string GetNombre();
        byte GetEdad();
        byte GetCedula();
        string GetLicencia();
        bool GetSeguro();
    }
}