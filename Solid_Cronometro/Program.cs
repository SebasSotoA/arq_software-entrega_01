using Solid_Cronometro.Clases;
using Solid_Cronometro.Enums;
using Solid_Cronometro.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Solid_Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Validadores:
            IValidaConductor validadorConductor = new Validacion();
            IValidaVehiculo validadorVehiculo = new Validacion();
            IValidaRuedas validadorRuedas = new Validacion();
            IValidaID validadorID = new Validacion();

            // 2. Crear Conductor
            IObtenerConductor conductor = new Conductor(
                nombre: "Juan Pérez",
                edad: 30,
                cedula: "123456789",
                validador_conductor: validadorConductor,
                licencia: "LIC-ABC",
                seguro: true
            );

            // 3. Crear un Vehículo (ejemplo: Kart) puede ser Cuatrimoto
             Kart Kart = new Kart(
                placa: "ABC-123",
                modelo: "KartModel",
                marca: "KartBrand",
                color: "Rojo",
                validador_vehiculo: validadorVehiculo,
                presionesRuedas: new List<float> { 32f, 32f, 30f, 30f },
                validador_ruedas: validadorRuedas,
                numero: "Kart#7",
                turbo: true
            );

            // 4. Crear Carrera
            ICarrera carrera = new Carrera(
                id: 1,
                nombre: "Gran Premio",
                l_vueltas: new List<IVuelta>(),
                validador_id: validadorID
            );

            // 5. Crear Vuelta
            IVuelta vuelta = new Vuelta(
                id: 101,
                l_tiempo_parcial: new List<ITiempoParcial>(),
                validador_id: validadorID
            );

            // 6. Crear TiempoParcial
            ITiempoParcial parcial = new TiempoParcial(
                id: 201,
                validador_id: validadorID
            );

            // 7. Crear el Cronometro (Orquestador)
            var cronometro = new Cronometro(
                id: 999,
                conductor: conductor,
                categoria: CategoriaTipo.Profesional,
                vehiculo: Kart,
                carrera: carrera,
                vuelta: vuelta,
                parcial: parcial
            );

            // 8. Usar el cronometro
            cronometro.IniciarCarrera();
            Console.WriteLine("Carrera iniciada...");
            Thread.Sleep(1000);

            cronometro.IniciarVuelta();
            Console.WriteLine("Vuelta iniciada...");
            Thread.Sleep(1000);

            cronometro.IniciarParcial();
            Console.WriteLine("Parcial iniciado...");
            Thread.Sleep(1000);

            cronometro.FinalizarParcial();
            Console.WriteLine($"Parcial finalizado. Duración: {cronometro.GetDuracionParcial()}");

            cronometro.FinalizarVuelta();
            Console.WriteLine($"Vuelta finalizada. Duración vuelta: {cronometro.GetTiempoFinalVuelta()}");

            cronometro.AgregarVuelta(vuelta);
            Console.WriteLine("Vuelta agregada a la carrera.");

            Thread.Sleep(1200);

            cronometro.FinalizarCarrera();
            Console.WriteLine($"Carrera finalizada. Duración carrera: {cronometro.GetTiempoFinalCarrera()}");

            Console.WriteLine($"Conductor: {cronometro.GetNombreConductor()} (Licencia: {cronometro.GetLicenciaConductor()})");

            Console.WriteLine($"Vehículo: {cronometro.GetMarcaVehiculo()} {cronometro.GetModeloVehiculo()}, Placa: {cronometro.GetPlacaVehiculo()}");
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
