using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal abstract class Kart : Vehiculo
    {
        protected string numero;
        protected bool turbo;

        public Kart(string placa, string modelo, string marca, string color, IValidaVehiculo validador_vehiculo, SistemaRuedas sistemaRuedas, IValidaRuedas validador_ruedas, string numero, bool turbo)
        :base(placa, modelo, marca, color, validador_vehiculo, sistemaRuedas, validador_ruedas)
        {
            this.numero = numero;
            this.turbo = turbo;
        }

        public string Numero
        {get => numero; set => numero = value;}
        public bool Turbo
        {get => turbo; set => turbo = value;}
        public override Dictionary<string, float> SistemaRuedas
        {get => sistemaRuedas; set => sistemaRuedas = value;} 
        public override Dictionary<string, float> GetSistemaRuedas() => sistemaRuedas;
    }
}