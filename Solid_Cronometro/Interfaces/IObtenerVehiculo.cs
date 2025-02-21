using Solid_Cronometro.Clases;

namespace Solid_Cronometro.Interfaces
{
    internal interface IObtenerVehiculo
    {
        string GetPlaca();
        string GetModelo();
        string GetMarca();
        string GetColor();
        SistemaRuedas GetSistemaRuedas();
    }
}
