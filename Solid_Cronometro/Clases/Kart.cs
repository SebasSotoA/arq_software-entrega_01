using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class Kart : Vehiculo
    {
        protected string numero;
        protected bool turbo;

        public Kart(string placa, string modelo, string marca, string color, IValidaVehiculo validador_vehiculo, List<float> presionesRuedas, IValidaRuedas validador_ruedas, string numero, bool turbo)
        :base(placa, modelo, marca, color, validador_vehiculo, presionesRuedas, validador_ruedas)
        {
            this.numero = numero;
            this.turbo = turbo;
        }

        public string Numero
        {get => numero; set => numero = value;}
        public bool Turbo
        {get => turbo; set => turbo = value;}
 
    }
}