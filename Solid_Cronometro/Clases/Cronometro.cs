using Solid_Cronometro.Enums;
using Solid_Cronometro.Interfaces;
using System.Collections.Generic;

namespace Solid_Cronometro.Clases
{
    internal class Cronometro
    {
        private int id;
        private readonly IObtenerConductor conductor;
        private CategoriaTipo categoria;
        private readonly IObtenerVehiculo vehiculo;
        private readonly ICarrera carrera;
        private readonly IVuelta vuelta;
        private readonly ITiempoParcial parcial;

        public Cronometro(
            int id,
            IObtenerConductor conductor,
            CategoriaTipo categoria,
            IObtenerVehiculo vehiculo,
            ICarrera carrera,
            IVuelta vuelta,
            ITiempoParcial parcial
        )
        {
            this.id = id;
            this.conductor = conductor;
            this.categoria = categoria;
            this.vehiculo = vehiculo;
            this.carrera = carrera;
            this.vuelta = vuelta;
            this.parcial = parcial;
        }

        #region Métodos para Carrera
        public void IniciarCarrera()
        {
            carrera.IniciarCarrera();
        }

        public void FinalizarCarrera()
        {
            carrera.FinalizarCarrera();
        }

        public void AgregarVuelta(IVuelta nuevaVuelta)
        {
            carrera.AddVuelta(nuevaVuelta);
        }

        public List<IVuelta> GetVueltasCarrera()
        {
            return carrera.GetVueltas();
        }

        public string GetTiempoFinalCarrera()
        {
            return carrera.GetTiempoFinalFormateado();
        }
        #endregion

        #region Métodos para Vuelta
        public void IniciarVuelta()
        {
            vuelta.IniciarVuelta();
        }

        public void FinalizarVuelta()
        {
            vuelta.FinalizarVuelta();
        }

        public void AgregarParcial(ITiempoParcial nuevoParcial)
        {
            vuelta.AddTiempoParcial(nuevoParcial);
        }

        public List<ITiempoParcial> GetTiemposParcialesVuelta()
        {
            return vuelta.GetTiemposParciales();
        }

        public string GetTiempoFinalVuelta()
        {
            return vuelta.GetTiempoFinalFormateado();
        }
        

        // Métodos para TiempoParcial
        public void IniciarParcial()
        {
            parcial.IniciarParcial();
        }

        public void FinalizarParcial()
        {
            parcial.FinalizarParcial();
        }

        public string GetDuracionParcial()
        {
           
            return parcial.GetDuracion();
        }
        

        // Métodos para Conductor
        // Consultar datos del conductor
        public string GetNombreConductor() => conductor.GetNombre();
        public byte GetEdadConductor() => conductor.GetEdad();
        public string GetCedulaConductor() => conductor.GetCedula();
        public string GetLicenciaConductor() => conductor.GetLicencia();
        public bool IsSeguroValido() => conductor.GetSeguro();
        

        // Métodos para Vehículo
        // Consultar datos del vehículo
        public string GetPlacaVehiculo() => vehiculo.GetPlaca();
        public string GetModeloVehiculo() => vehiculo.GetModelo();
        public string GetMarcaVehiculo() => vehiculo.GetMarca();
        public string GetColorVehiculo() => vehiculo.GetColor();
        public SistemaRuedas GetSistemaRuedasVehiculo() => vehiculo.GetSistemaRuedas();
        
        // Métodos/Propiedades Adicionales
        public int GetId() => id;
        public CategoriaTipo GetCategoria() => categoria;
     
    }
}
