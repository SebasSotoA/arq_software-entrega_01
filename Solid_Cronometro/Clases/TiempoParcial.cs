using Solid_Cronometro.Interfaces;
using System.Diagnostics;

namespace Solid_Cronometro.Clases
{
    internal class TiempoParcial : ITiempoParcial
    {
        private int id;
        private Stopwatch tiempo;
        private TimeSpan duracion;
        private readonly IValidaID validador_id;

        public TiempoParcial(int id, IValidaID validador_id)
        {
            this.id = id;
            this.tiempo = new Stopwatch();
            this.validador_id = validador_id;
        }

        public int Id
        {
            get => id;
            set => id = validador_id.ValidarID(value)
                ? value
                : throw new Exception("Id inválido.");
        }

        public void IniciarParcial()
        {
            if (!tiempo.IsRunning)
                tiempo.Start();
            else
                throw new InvalidOperationException("El parcial ya está iniciado.");
        }

        public void FinalizarParcial()
        {
            if (!tiempo.IsRunning)
                throw new InvalidOperationException("El parcial no ha iniciado.");

            tiempo.Stop();
            duracion = tiempo.Elapsed; 
        }
        string ITiempoParcial.GetDuracion() => duracion.ToString(@"hh\:mm\:ss");

    }
}
