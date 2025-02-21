using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class Vehiculo
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
        {}
        public string Modelo
        {}
        public string Marca
        {}
        public string Color
        {}

        public Dictionary<string, float> SistemaRuedas
        {}   
    }
}
