using Solid_Cronometro.Interfaces;
using System.Diagnostics;

internal class Vuelta : IVuelta
{
    private int id;
    private Stopwatch tiempo;
    private List<ITiempoParcial> l_tiempo_parcial;
    private readonly IValidaID validador_id;
    private TimeSpan tiempoFinal;

    public Vuelta(int id, List<ITiempoParcial> l_tiempo_parcial, IValidaID validador_id)
    {
        this.id = id;
        this.tiempo = new Stopwatch();
        this.l_tiempo_parcial = l_tiempo_parcial;
        this.validador_id = validador_id;
    }

    public int Id
    {
        get => id;
        set => id = validador_id.ValidarID(value) ? value : throw new Exception("Id inválido.");
    }

    internal List<ITiempoParcial> L_tiempo_parcial
    {
        get => l_tiempo_parcial;
        set => l_tiempo_parcial = (value == null || value.Count == 0)
            ? throw new ArgumentException("La lista de tiempos parciales no puede ser nula ni estar vacía", nameof(value))
            : value;
    }

    public void IniciarVuelta()
    {
        if (!tiempo.IsRunning)
            tiempo.Start();
        else
            throw new InvalidOperationException("La vuelta ya está iniciada.");
    }

    public void FinalizarVuelta()
    {
        if (!tiempo.IsRunning)
            throw new InvalidOperationException("La vuelta no ha iniciado.");

        tiempo.Stop();
        tiempoFinal = tiempo.Elapsed;
    }

    public string GetTiempoFinalFormateado() => tiempoFinal.ToString(@"hh\:mm\:ss");

    public void AddTiempoParcial(ITiempoParcial tp)
    {
        if (!tiempo.IsRunning)
            throw new InvalidOperationException("No se puede agregar un tiempo parcial si la vuelta no está en curso.");

        l_tiempo_parcial.Add(tp);
    }

    public List<ITiempoParcial> GetTiemposParciales() => l_tiempo_parcial;
}
