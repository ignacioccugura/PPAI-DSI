using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class Exposicion
    {
        public DateTime fechaFin;
        public TipoExposicion tipoExposicion;
        public PublicoDestino publicoDestino = new PublicoDestino();
        public string nombre;
        public string fechaFinReplanificacion;
        public string fechaInicioReplanificacion;
        public string horaApertura;
        public string horaCierre;
        public List<DetalleExposicion> detallesExp = new List<DetalleExposicion>();
        public bool getTempVigentes(DateTime fecha)
        {
            //recibe como parámetro la fecha de la reserva, verifica que esa fecha de reserva no supere el atributo fechaFin de la clase
            //Exposicion, si no lo supera, pregunta a través del método EsTemporal, si la exposición lo es, si es true retorna true.
            //De otra forma, retorna false

            if (fechaFin > fecha)
            {
                if (this.tipoExposicion.EsTemporal() == true)
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


        public string getHorarioHabilitado()
        {
            //obtiene el horario en el que está disponible la exposición

            string[] horarioHabilitado = new string[2];
            horarioHabilitado[0] = horaApertura;
            horarioHabilitado[1] = horaCierre;
            string horario = horarioHabilitado[0] + "    " + horarioHabilitado[1];
            return horario;
        }

        public int buscarDurExtObras()
        {
            //suma las duraciones extendidas de todas las obras seleccionadas en la exposición y devuelve el resultado

            int duracion = 0;
            for (int i = 0; i < this.detallesExp.Count;i++)
            {
                string[] duracionSeparada = this.detallesExp[i].buscarDurExtObra().Split(':');
                duracion += (int.Parse(duracionSeparada[0]) * 3600 + int.Parse(duracionSeparada[1]) * 60 + int.Parse(duracionSeparada[2]));
            }
            return duracion;
        }


    }
}
