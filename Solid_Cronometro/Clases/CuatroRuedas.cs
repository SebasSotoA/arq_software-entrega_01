using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class cuatroRuedas : IValidaRuedas
    {
        public bool ValidarRuedas(List<float> ruedas){
            return ruedas.Count == RNVehiculo.nro_ruedas_4;
        }
    }
}
