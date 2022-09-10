using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class Sesion
    {
        public DateTime fechaInicio;
        public DateTime fechaFin;
        public TimeSpan horaInicio;
        public TimeSpan horaFin;
        public Usuario usuarioLog = new Usuario();


        public Empleado getEmpleadoLogueado()
        {
            //retorna el resultado obtenido de invocar al método getUsuario del objeto usuarioLog que es atributo de la clase Sesion

            return this.usuarioLog.getUsuario();
        }
    }
}
