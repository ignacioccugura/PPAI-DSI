using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Shopping_Buy_All.Clases;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class AsignacionVisita
    {
        public DateTime fechaHoraInicio;
        public DateTime fechaHoraFin;
        public Empleado empleado;

        public bool EsAsignacionParaFechaHora(DateTime fechaHoraReserva)
        {
            //recibe como parámetro la fecha y hora de la reserva por hacer, luego verifica si esa fecha y hora están en el intervalo
            //entre los atributos fechaHoraInicio y la fechaHoraFin de la AsignacionVisita, retornando true en el caso de que se encuentre
            //en el intervalo y retornando false en el caso de que no.

            if (fechaHoraReserva >= fechaHoraInicio && fechaHoraReserva <= fechaHoraFin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AsignacionVisita CrearAsignacionVisita(Empleado empleado, DateTime fechaHoraReserva, TimeSpan dur)
        {
            //recibe como parámetros un objeto empleado de la clase Empleado, la fechaHoraReserva y la duración dur de la visita.
            //Le asigna al atributo empleado de la AsignacionVisita el objeto empleado recibido, al igual que se asigna al atributo fechaHoraInicio ,
            //la fechaHoraReserva. Luego, se calcula la fechaHoraFinal_S, sumando a la hora de la reserva, la duración de las exposiciones. Al final,
            //se asigna al atributo fechaHoraFin, lo calculado en el paso anterior y se retorna el objeto de la clase AsignacionVisita, creado.

            this.empleado = empleado;
            this.fechaHoraInicio = fechaHoraReserva;
            TimeSpan fechaHoraFinal_S = fechaHoraReserva.TimeOfDay + dur;
            string[] union = fechaHoraReserva.Date.ToString().Split(' ');
            this.fechaHoraFin = DateTime.Parse(union[0].ToString() + "   " + fechaHoraFinal_S.ToString());
            return this;
        }


        
    }
}
