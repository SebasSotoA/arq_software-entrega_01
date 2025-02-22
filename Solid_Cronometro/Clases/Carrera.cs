using Solid_Cronometro.Interfaces;
using System.Diagnostics;

namespace Solid_Cronometro.Clases
{
    internal class Carrera:ICarrera
    {
        private int id;
        private string nombre;
        private Stopwatch tiempo;
        private List<IVuelta> l_vueltas;
        private readonly IValidaID validador_id;
        private TimeSpan tiempoFinal;

        public Carrera(int id, string nombre, List<IVuelta> l_vueltas, IValidaID validador_id)
        {
            this.id = id;
            this.nombre = nombre;
            tiempo = new Stopwatch();
            this.l_vueltas = l_vueltas;         
            this.validador_id = validador_id;
        }
        public int Id
        { get => id; set => id = validador_id.ValidarID(value) ? value : throw new Exception("Id inválido."); }

        public string Nombre
        {
            get => nombre;
            set => nombre = string.IsNullOrEmpty(value)
                ? throw new ArgumentException("El nombre no puede ser nulo ni vacío.")
                : value;
        }

        internal List<IVuelta> L_vueltas
        {
            get => l_vueltas;
            set => l_vueltas = (value == null || value.Count == 0)
                ? throw new ArgumentException("La lista de tiempos parciales no puede ser nula ni estar vacía", nameof(value))
                : value;
        }

        public void IniciarCarrera()
        {
            if (!tiempo.IsRunning)
                tiempo.Start();
            else
                throw new InvalidOperationException("La carrera ya está iniciada.");
        }

        public void FinalizarCarrera()
        {
            if (!tiempo.IsRunning)
                throw new InvalidOperationException("La carrera no ha iniciado.");

            tiempo.Stop();
            tiempoFinal = tiempo.Elapsed; // Se guarda el resultado
        }
        public string GetTiempoFinalFormateado() => tiempoFinal.ToString(@"hh\:mm\:ss");    

        public void AddVuelta(IVuelta vuelta)
        {
            if (!tiempo.IsRunning)
            {
                throw new InvalidOperationException("No se puede agregar una vuelta si la carrera no está en curso.");
            }
            l_vueltas.Add(vuelta);
        }
        public List<IVuelta> GetVueltas() => l_vueltas;
    }
}
