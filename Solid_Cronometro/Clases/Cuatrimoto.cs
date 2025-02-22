using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class Cuatrimoto : Vehiculo
    {
        protected bool trac_4x4;
        protected bool suspension;

        public Cuatrimoto(string placa, string modelo, string marca, string color, IValidaVehiculo validador_vehiculo, List<float> presionesRuedas, IValidaRuedas validador_ruedas, bool trac_4x4, bool suspension)
        :base(placa, modelo, marca, color, validador_vehiculo, presionesRuedas, validador_ruedas)
        {
            this.trac_4x4 = trac_4x4;
            this.suspension = suspension;
        }

        public bool Trac_4x4
        {get => trac_4x4; set => trac_4x4 = value;}
        public bool Suspension
        {get => suspension; set => suspension = value;}
    }
}