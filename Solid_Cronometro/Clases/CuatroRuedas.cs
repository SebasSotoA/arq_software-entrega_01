using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class cuatroRuedas : IValidaRuedas
    {
        public bool validarRuedas(List<float> ruedas){
            return ruedas == RNVehiculo.nro_ruedas_4;
        }
    }
}
