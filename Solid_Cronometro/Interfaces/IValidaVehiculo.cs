namespace Solid_Cronometro.Interfaces{
    internal interface IValidaVehiculo 
    {
        bool ValidarPlaca(string placa);
        bool ValidarModelo(string modelo);
        bool ValidarMarca(string marca);
    }
}
