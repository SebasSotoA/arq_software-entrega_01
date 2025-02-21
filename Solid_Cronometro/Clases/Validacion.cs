using System.Reflection.Metadata.Ecma335;
using Solid_Cronometro.Interfaces;

namespace Solid_Cronometro.Clases{
    internal class Validacion : IValidaVehiculo, IValidaConductor, IValidaRuedas, IValidaTiempo, IValidaID
    {
        bool ValidarNombre(string nombre) => !(string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre) || nombre.Length <= RNCronometro.long_min_nom);
        bool ValidarEdad(byte edad) => !(edad > RNConductor.max_edad_conductor || edad < RNConductor.min_edad_conductor);
        bool ValidarCedula(string cedula) => !(string.IsNullOrEmpty(cedula) || string.IsNullOrWhiteSpace(cedula) || cedula.Length > RNConductor.long_top_cedula);
        bool ValidarLicencia(string licencia) => !(string.IsNullOrEmpty(licencia) || string.IsNullOrWhiteSpace(licencia));
        bool ValidarSeguro(bool seguro) => seguro;
        bool ValidarID(int id) => id > 0;
        bool ValidarRuedas(List<float> ruedas) => ruedas.All(r => r >= RNVehiculo.min_presion_rueda && r <= RNVehiculo.max_presion_rueda);
        bool ValidarInicio(long inicio) => inicio >= 0;
        bool ValidarFin(long fin) => fin <= 3600;
        public bool ValidarPlaca(string placa) => 
        !(string.IsNullOrEmpty(placa) || string.IsNullOrWhiteSpace(placa) || placa.Length != 6 || placa.Substring(0, 2).ToCharArray().Any(c => !char.IsLetter(c)));      
        bool ValidarModelo(string modelo) => !(string.IsNullOrWhiteSpace(modelo) && modelo.Length >= RN_Automovil.long_mod_min); //Realmente importa para nuestro dominio de problema?
        bool ValidarMarca(string marca) => !(string.IsNullOrEmpty(marca) || string.IsNullOrWhiteSpace(marca) || marca.Length < RN_Automovil.long_marca_min); // Importa la marca para nuestro dominio de problema?
    }
}