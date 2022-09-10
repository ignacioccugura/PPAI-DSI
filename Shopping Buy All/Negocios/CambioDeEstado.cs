using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class CambioDeEstado
    {
        public DateTime fechaHoraInicio;
        public DateTime fechaHoraFin;
        public Estado estado;

        public CambioDeEstado CrearCambioDeEstado(Estado estadoNuevo)
        {
            //crea un objeto cambio de estado, al que le asigna un objeto estado y la fecha en la que es creado

            this.estado = estadoNuevo;
            this.fechaHoraInicio = DateTime.Now;
            return this;
        }
    }
}
