using System.Reflection.Metadata.Ecma335;
using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases{
    internal class Validacion : IValidaVehiculo, IValidaConductor, IValidaRuedas, IValidaTiempo, IValidaID
    {
        //Validación conductor
        public bool ValidarNombre(string nombre) => !(string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre) || nombre.Length <= RNCronometro.long_min_nom);
        public bool ValidarEdad(byte edad) => !(edad > RNConductor.max_edad_conductor || edad < RNConductor.min_edad_conductor);
        public bool ValidarCedula(string cedula) => !(string.IsNullOrEmpty(cedula) || string.IsNullOrWhiteSpace(cedula) || cedula.Length > RNConductor.long_top_cedula);
        public bool ValidarLicencia(string licencia) => !(string.IsNullOrEmpty(licencia) || string.IsNullOrWhiteSpace(licencia));
        public bool ValidarSeguro(bool seguro) => seguro;
        // Validación ID
        public bool ValidarID(int id) => id > 0;
        // Validación Ruedas
        public bool ValidarRuedas(List<float> ruedas) => ruedas.All(r => r >= RNVehiculo.min_presion_rueda && r <= RNVehiculo.max_presion_rueda);
        // Validacion Tiempo
        public bool ValidarInicio(long inicio) => inicio >= 0;
        public bool ValidarFin(long fin) => fin <= 3600;
        // Validacion Vehiculo
        public bool ValidarPlaca(string placa) => !(string.IsNullOrEmpty(placa) || string.IsNullOrWhiteSpace(placa) || placa.Length != RNVehiculo.long_placa || placa.Substring(0, 2).ToCharArray().Any(c => !char.IsLetter(c)));      
        public bool ValidarModelo(string modelo) => !(string.IsNullOrWhiteSpace(modelo) && modelo.Length >= RNVehiculo.long_mod_min);
        public bool ValidarMarca(string marca) => !(string.IsNullOrEmpty(marca) || string.IsNullOrWhiteSpace(marca) || marca.Length < RNVehiculo.long_marca_min);
    }
}
