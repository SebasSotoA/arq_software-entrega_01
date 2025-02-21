using System.Diagnostics;
using System.Runtime.CompilerServices;
using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class SistemaRuedas : IObtenerPresionRuedas
    {
        protected List<float> presionRuedas;
        protected IValidaRuedas validador_ruedas;

        public SistemaRuedas(IValidaRuedas validador_ruedas)
        {
            this.validador_ruedas = validador_ruedas;
            this.presionRuedas = [0, 0, 0, 0];
        }

        public List<float> PresionRuedas
        {
            get => new(presionRuedas); set => presionRuedas = validador_ruedas.ValidarRuedas(value) ? value : throw new Exception("Presión de ruedas inválida."); 
        }

        public List<float> ObtenerPresionRuedas()
        {
            return new List<float>(presionRuedas);
        }

    }
}