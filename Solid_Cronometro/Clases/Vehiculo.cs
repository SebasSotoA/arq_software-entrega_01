using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal abstract class Vehiculo : IObtenerVehiculo
    {
        protected string placa;
        protected string modelo;
        protected string marca;
        protected string color;
        protected IValidaVehiculo validador_vehiculo;
        protected SistemaRuedas sistemaRuedas;
        protected IValidaRuedas validadorRuedas;

        public Vehiculo(string placa, string modelo, string marca, string color, IValidaVehiculo validador_vehiculo, SistemaRuedas sistemaRuedas, IValidaRuedas validador_ruedas)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
            this.validador_vehiculo = validador_vehiculo;
            this.sistemaRuedas = sistemaRuedas;
            this.validadorRuedas = validador_ruedas;
        }

        public string Placa
        { get => placa; set => placa = validador_vehiculo.ValidarPlaca(value) ? value : throw new Exception("Placa inválida."); }
        public string Modelo
        { get => modelo; set => modelo = validador_vehiculo.ValidarModelo(value) ? value : throw new Exception("Modelo inválido."); }
        public string Marca
        { get => marca; set => marca = validador_vehiculo.ValidarMarca(value) ? value : throw new Exception("Marca inválida."); }
        public string Color
        { get => color; set => color = value; }

        public virtual Dictionary<string, float> SistemaRuedas
        {get => sistemaRuedas; set => sistemaRuedas = value;}   

        public string GetPlaca() => placa;
        public string GetModelo() => modelo;
        public string GetMarca() => marca;
        public string GetColor() => color;
        public virtual Dictionary<string, float> GetSistemaRuedas() => sistemaRuedas;

    }
}
