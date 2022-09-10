using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class HorarioEmpleado
    {
        public TimeSpan horaInicio;
        public TimeSpan horaFin;
        public DiaSemana diaSemana;

        public bool dispEnFechaHoraReserva(DateTime fechaHoraReserva)
        {
        //recibe como parámetro la fecha y hora de la reserva, se verifica si el día de la reserva es la misma que el atributo diaSemana
        //de la clase HorarioEmpleado. Si es así, se verifica que los atributos horaInicio y horaFin se encuentren en el intervalo de ocurrencia
        //de la visita, de ser así, retorna true. De otra forma, retorna false.

            if (fechaHoraReserva.DayOfWeek.ToString().Trim() == diaSemana.getNombre().Trim())
            {
                if (fechaHoraReserva.TimeOfDay >= horaInicio && fechaHoraReserva.TimeOfDay <= horaFin)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
