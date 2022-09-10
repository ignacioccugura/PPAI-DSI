using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int codigoValidacion;
        public Int64 cuit;
        public string domicilio;
        public DateTime fechaIngreso;
        public DateTime fechaNacimiento;
        public string mail;
        public string telefono;
        public Cargo cargo;
        public Sede sede;
        public List<HorarioEmpleado> horarioEmpleado = new List<HorarioEmpleado>();
        public AsignacionVisita asignacion;

        public bool getGuiaDisponibleEnHorario(Sede sede, DateTime fechaHoraReserva)
        {
            //Recibe como parametros la sede seleccionada y la fechaHoraReserva en la que se quiere efectuar la nueva reserva, comprueba si el empleado es guia,
            //si es de la sede seleccionada y si no posee una asignacion en ese dia y hora. En caso afirmativo, devuelve true, caso contrario devuelve false.

            if (cargo.esGuia())
            {
                if (esDeSede(sede))
                {
                    for (int i = 0; i < this.horarioEmpleado.Count; i++)
                    {
                        if (this.horarioEmpleado[i].dispEnFechaHoraReserva(fechaHoraReserva))
                        {
                            if (this.asignacion == null)
                            {
                                return true;
                            } 
                            if (this.asignacion.EsAsignacionParaFechaHora(fechaHoraReserva) == false)
                            {
                                return true;
                            }
                            
                        }
                    }
                }
            }
            return false;

        }

        public bool esDeSede(Sede sede)
        {
            //Patron Experto

            //Recibe como parametro la sede seleccionada por el usuario y la compara con la sede del empleado para corroborar si este trabaja ahi

            if (sede.Equals(this.sede))
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
