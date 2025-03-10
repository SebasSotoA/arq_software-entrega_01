﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Cronometro.Interfaces
{
    internal interface ICarrera 
    {
        void IniciarCarrera();
        void FinalizarCarrera();
        void AddVuelta(IVuelta vuelta);
        List<IVuelta> GetVueltas();
        string GetTiempoFinalFormateado();
    }
}
