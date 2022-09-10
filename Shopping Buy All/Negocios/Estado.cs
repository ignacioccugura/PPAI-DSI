using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class Estado
    {
        public string nombre;
        public string ambito;

        public bool EsAmbitoReserva()
        {
            //compara si el ambito del estado es "Reserva"

            if (ambito.Trim() == "Reserva")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EsPendienteDeConfirmacion()
        {
            //compara si el estado está pendiente de confirmación.

            if (nombre.Trim() == "Pendiente de confirmacion")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
