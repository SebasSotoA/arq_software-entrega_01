namespace Solid_Cronometro.Clases
{
    using Solid_Cronometro.Interfaces;
    internal class Conductor : IObtenerConductor
    {
        private string nombre;
        private byte edad;
        private string cedula;
        private readonly IValidaConductor validador_conductor;
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
        
        public string Nombre 
        { get => nombre; set => nombre = validador_conductor.ValidarNombre(value) ? value : throw new Exception("Nombre inválido."); }
        public byte Edad 
        { get => edad; set => edad = validador_conductor.ValidarEdad(value) ? value : throw new Exception("Edad inválida."); }
        public string Cedula 
        { get => cedula; set => cedula = validador_conductor.ValidarCedula(value) ? value : throw new Exception("Cedula inválida."); }
        public string Licencia 
        { get => licencia; set => licencia = validador_conductor.ValidarLicencia(value) ? value : throw new Exception("Licencia inválida."); }
        public bool Seguro
        { get => seguro; set => seguro = validador_conductor.ValidarSeguro(value) ? value : throw new Exception("Conductor no tiene seguro."); }

        public string GetNombre() => Nombre;
        public byte GetEdad() => Edad;
        public string GetCedula() => Cedula;
        public string GetLicencia() => Licencia;
        public bool GetSeguro() => Seguro;

    }
}
