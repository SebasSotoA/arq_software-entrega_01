using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases
{
    internal class TiempoParcial:ITiempoParcial
    {
        private int id;
        private long inicio;
        private long fin;

        public TiempoParcial(int id, long inicio, long fin)
        {
            this.id = id;
            this.inicio = inicio;
            this.fin = fin;
        }
    }
}
