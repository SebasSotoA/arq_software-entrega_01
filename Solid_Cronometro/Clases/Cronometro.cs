using Solid_Cronometro.Interfaces;
using Solid_Cronometro.Enums;

namespace Solid_Cronometro.Clases
{
    internal class Cronometro
    {
        private int id;
        private readonly IObtenerConductor conductor;
        private CategoriaTipo categoria;
        private readonly IObtenerVehiculo vehiculo;
        private readonly ICarrera carrera;
        private readonly IVuelta vuelta;
        private readonly ITiempoParcial parcial;

        public Cronometro(int id, IObtenerConductor conductor, CategoriaTipo categoria, IObtenerVehiculo vehiculo, ICarrera carrera, IVuelta vuelta, ITiempoParcial tiempoParcial) 
        {
            this.id = id;
            this.conductor = conductor;
            this.categoria = categoria;
            this.vehiculo = vehiculo;
            this.carrera = carrera;
            this.vuelta = vuelta;
            this.parcial = parcial;
        }

        public string GetNombre() => conductor.GetNombre();
        public byte GetEdad() => conductor.GetEdad();
        public string GetCedula() => conductor.GetCedula();
        public string GetLicencia() => conductor.GetLicencia();
        public bool GetSeguro() => conductor.GetSeguro();

        public string GetPlaca() => vehiculo.GetPlaca();
        public string GetModelo() => vehiculo.GetModelo();
        public string GetMarca() => vehiculo.GetMarca();
        public string GetColor() => vehiculo.GetColor();
        public SistemaRuedas GetSistemaRuedas() => vehiculo.GetSistemaRuedas();

    }
}
