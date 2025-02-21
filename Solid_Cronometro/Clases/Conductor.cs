namespace Solid_Cronometro.Clases
{
    using Solid_Cronometro.Interfaces;
    internal class Conductor : IObtenerConductor
    {
        private string nombre;
        private byte edad;
        private string cedula;
        private IValidaConductor validador_conductor;
        private string licencia;
        private bool seguro;

        public Conductor(string nombre, byte edad, string cedula, IValidaConductor validador_conductor, string licencia, bool seguro)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
            this.validador_conductor = validador_conductor;
            this.licencia = licencia;
            this.seguro = seguro;
        }

        public string getNombre()
        {
            return nombre;
        }
        public byte getEdad()
        {
            return edad;
        }
        public byte getCedula()
        {
            return 1;
        }
        public string getLicencia()
        {
            return "";
        }
        public bool getSeguro()
        {
            return true;
        }     

    }
}
