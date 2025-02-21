using Solid_Cronometro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Cronometro.Clases
{
    internal class Carrera:ICarrera
    {
        private int id;
        private string name;
        private long inicio;
        private long fin;
        private List<IVuelta> l_vueltas;
        private IValidaTiempo validador_tiempo;
        private IValidaID validador_id;

        public Carrera(int id, string name, long inicio, long fin, List<IVuelta> l_vueltas, IValidaTiempo validador_tiempo, IValidaID validador_id)
        {
            this.id = id;
            this.name = name;
            this.inicio = inicio;
            this.fin = fin;
            this.l_vueltas = l_vueltas;
            this.validador_tiempo = validador_tiempo;
            this.validador_id = validador_id;
        }

        public void IniciarCarrera()
        {

        }

        public void FinalizarCarrera()
        {

        }
        public void AddVuelta(IVuelta vuelta)
        {

        }
        public List<IVuelta> GetVueltas()
        {
            return l_vueltas;
        }
    }
}
