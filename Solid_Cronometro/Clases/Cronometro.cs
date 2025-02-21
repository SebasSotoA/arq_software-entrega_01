using Solid_Cronometro.Interfaces;
using Solid_Cronometro.Enums;

namespace Solid_Cronometro.Clases
{
    internal class Cronometro
    {
        private int id;
        private IObtenerConductor conductor;
        private CategoriaTipo categoria;
        private IObtenerVehiculo vehiculo;
        private ICarrera carrera;
        private IVuelta vuelta;
        private ITiempoParcial parcial;

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

    }
}
