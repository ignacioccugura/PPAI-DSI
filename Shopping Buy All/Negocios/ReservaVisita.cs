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
    public class ReservaVisita
    {
        public int cantidadAlumnos;
        public int cantidadAlumnosConfirmada;
        public DateTime fechaHoraReserva;
        public TimeSpan duracionEstimada;
        public DateTime fechaHoraCreacion;
        public TimeSpan horaFinReal;
        public int numeroReserva;
        public Sede sede;
        public Escuela escuela;
        public TipoVisita tipoVisita;
        public Empleado empleado;
        public List<AsignacionVisita> asignacionVisita = new List<AsignacionVisita>();
        public List<CambioDeEstado> cambioDeEstado = new List<CambioDeEstado>();
        public List<Exposicion> exposiciones = new List<Exposicion>();

        public int ObtenerAlumnosEnReserva(DateTime fechaHoraReserva, TimeSpan duracionEstimadaVisita)
        {
            // recibe como parámetro las fecha y hora de la reserva y la duración estimada de la visita.  Se calcula la HoraFin, sumando el atributo
            // fechaHoraReserva con la duracionEstimada. Se calcula la HoraFinNueva sumando la fechaHoraReserva con el valor del parámetro de
            // duracionEstimadaVisita. Luego, verifica si el día de la reserva es el mismo que el ingresado por el usuario. Si es así, verifica que el
            // horario sea el mismo, si se cumple, retorna la el atributo cantidadAlumnos. De otra forma, retorna cero.

            string[] fechaHoraFin = this.fechaHoraReserva.ToString().Split(' ');
            string[] fechaHoraFinNueva = fechaHoraReserva.ToString().Split(' ');

            TimeSpan HoraFin = this.fechaHoraReserva.TimeOfDay + duracionEstimada;
            TimeSpan HoraFinNueva = fechaHoraReserva.TimeOfDay + duracionEstimadaVisita;

            DateTime fechaHoraFinEstimada = DateTime.Parse(fechaHoraFin[0] + " " + HoraFin);
            DateTime fechaHoraFinEstimadaNueva = DateTime.Parse(fechaHoraFinNueva[0] + " " + HoraFinNueva);

            if (this.fechaHoraReserva.Date == fechaHoraReserva.Date)
            {
                for (int i = 0; i < this.asignacionVisita.Count; i++)
                {
                    if (this.fechaHoraReserva <= fechaHoraReserva && fechaHoraFinEstimada >= fechaHoraFinEstimadaNueva)
                    {
                        return cantidadAlumnos;
                    }
                }
            }
            return 0;
        }

        public int getNroReserva()
        {
            //retorna el atributo numeroReserva de la clase Reserva

            return numeroReserva;
        }

        public void CrearCambioEstado(Estado estadoNuevo)
        {
            //crea un objeto cambio de estado para la clase reserva

            CambioDeEstado cambioEstado = new CambioDeEstado();
            this.cambioDeEstado.Add(cambioEstado.CrearCambioDeEstado(estadoNuevo));
        }

        public void CrearAsignacionVisita(List<Empleado> guiasSeleccionados,DateTime fechaHoraReserva,TimeSpan dur)
        {
            //crea un objeto asignacion visita para la clase reserva

            AsignacionVisita asignacion = new AsignacionVisita();
            for (int i = 0; i < guiasSeleccionados.Count; i++)
            {
                this.asignacionVisita.Add(asignacion.CrearAsignacionVisita(guiasSeleccionados[i],fechaHoraReserva,dur));
            }
            
        }

        public void CrearReserva(Estado estado,Empleado user, int numeroR, List<Empleado> guiasSeleccionados, DateTime fechaHoraReserva, int duracionEstimada,int cantidadVisitantes,Escuela escuela, List<Exposicion> exposicionesSeleccionadas,Sede sede, TipoVisita tipoVisita)
        {
            //Patron Creador
            
            //recibe los datos proveídos por el gestor para generar un objeto ReservaVisita y cargar los datos correspondientes en la base de datos

            int hora = duracionEstimada / 3600;
            TimeSpan dur = TimeSpan.Parse(hora.ToString() + ":00:00");
            this.duracionEstimada = dur;
            this.fechaHoraReserva = fechaHoraReserva;
            this.cantidadAlumnos = cantidadVisitantes;
            this.cantidadAlumnosConfirmada = 0;
            this.empleado = user; 
            this.escuela = escuela;
            this.exposiciones = exposicionesSeleccionadas;
            this.fechaHoraCreacion = DateTime.Now;
            this.horaFinReal = TimeSpan.Parse("00:00:00.00000");
            this.numeroReserva = numeroR;
            this.sede = sede;
            this.tipoVisita = tipoVisita;
            this.CrearCambioEstado(estado);
            this.CrearAsignacionVisita(guiasSeleccionados,fechaHoraReserva,dur);

            BE_Acceso_Datos _BD = new BE_Acceso_Datos();

            DataTable empleado1 = new DataTable();
            string sqlEmpleado1 = "SELECT e.idEmpleado FROM EMPLEADOS e WHERE e.nombre='" + this.empleado.nombre.ToString().Trim() + "'";
            empleado1 = _BD.Ejecutar_Select(sqlEmpleado1);

            DataTable tablaGuia = new DataTable();

            DataTable sede1 = new DataTable();
            string sqlSede1 = "SELECT s.idSede FROM SEDES s WHERE s.nombre='" + this.sede.nombre.ToString().Trim() + "'";
            sede1 = _BD.Ejecutar_Select(sqlSede1);

            DataTable escuela1 = new DataTable();
            string sqlescu = "SELECT e.idEscuela FROM ESCUELAS e WHERE e.nombre='" + this.escuela.nombre.ToString().Trim() + "'";
            escuela1 = _BD.Ejecutar_Select(sqlescu);

            DataTable cantAsignacion = new DataTable();
            string sqlAsignaciones = "SELECT COUNT(*) FROM ASIGNACIONES_VISITAS";
            cantAsignacion = _BD.Ejecutar_Select(sqlAsignaciones);
            string[] fechaHorafin = fechaHoraReserva.Date.ToString().Split(' ');

            for (int i = 0; i < this.asignacionVisita.Count; i++)
            {
                string sqlGuia = "SELECT e.idEmpleado FROM EMPLEADOS e WHERE e.nombre='" + this.asignacionVisita[i].empleado.nombre +"'";
                tablaGuia = _BD.Ejecutar_Select(sqlGuia);
                string sqlAsig2 = "INSERT INTO ASIGNACIONES_VISITAS VALUES(" + (int.Parse(cantAsignacion.Rows[0][0].ToString()) + 1 + i) +
                    "," + "(convert(DateTime,'" + this.fechaHoraReserva + "',105))" + "," + "(convert(DateTime,'" + fechaHorafin[0] + " " + (this.fechaHoraReserva.TimeOfDay + this.duracionEstimada) + "', 105))" +
                    "," + tablaGuia.Rows[0][0].ToString().Trim() + ")";

                _BD.Insertar(sqlAsig2);

            }

            string sql = "INSERT INTO RESERVAS_VISITAS(idReserva,cantidadAlumnos, cantidadAlumnosConfirmada, duracionEstimada, fechaHoraCreacion," +
            " fechaHoraReservada, horaFinReal, idAsignacionVisita, idEmpleado, idSede," +
            " idTipoVisita, idEscuela) VALUES(" + this.numeroReserva + "," + this.cantidadAlumnos + ", 0, '" + this.duracionEstimada + "',  GETDATE(),(convert(datetime,'" + this.fechaHoraReserva + "',105)), '00:00:00',"
            + (int.Parse(cantAsignacion.Rows[0][0].ToString()) + 1) + "," + empleado1.Rows[0][0].ToString().Trim() + "," + sede1.Rows[0][0].ToString().Trim() + "," + 2 + "," + escuela1.Rows[0][0].ToString().Trim() + ")";


            _BD.Insertar(sql);



        }

    }
}
