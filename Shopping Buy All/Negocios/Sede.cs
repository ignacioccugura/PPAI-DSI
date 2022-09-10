using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class Sede
    {
        public string nombre { get; set; }
        public int cantMaxVisitantes;
        public int cantMaxPorGuia;
        public List<Exposicion> exposiciones = new List<Exposicion>();
        public List<ReservaVisita> reservasVisita = new List<ReservaVisita>();

        public List<Exposicion> BuscarExposiciones(DateTime fecha)
        {
            //recibe como parámetro la fecha de la reserva ingresada por el usuario, crea una lista con las exposiciones que se encuentran vigentes.
            //Se recorre un ciclo por la totalidad de exposiciones que tenga el atributo exposiciones de la clase Sede, se invoca al método getTempVigentes
            //de las exposiciones pasandole el parámetro de la fecha de reserva, si retorna true, se agrega a la lista de exposicionesActivas, la exposición.
            //Al finalizar, retorna la lista exposicionesActivas

            List<Exposicion> exposicionesActivas = new List<Exposicion>();
            for ( int i = 0 ; i < exposiciones.Count ; i++ )
            {
                if ( exposiciones[i].getTempVigentes(fecha) == true)
                {
                    exposicionesActivas.Add(exposiciones[i]);
                }
            }
            return exposicionesActivas;
            
        }

        public int BuscarDuracionExposiciones(List<Exposicion> exposicionesSeleccionadas)
        {
            //recibe como parámetro la lista con las exposiciones que seleccionó el usuario. Recorre todos los elementos de la lista, llamando por cada
            //exposicion el método buscarDurExtObras, para calcular la duración estimada de la visita. Al final, retorna la duración.

            int duracion = 0;
            for (int i = 0; i < exposicionesSeleccionadas.Count; i++)
            {
                duracion += exposicionesSeleccionadas[i].buscarDurExtObras();
            }
            return duracion;
        }

        public string MostrarNombre()
        {
            //devuelve el nombre de la sede

            return nombre;
        }

        public int BuscarReservaParaFechaHora(DateTime fechaHoraReserva, TimeSpan duracionEstimada)
        {
            //revisa las reservas y acumula la cantidad de alumnos para cada una de ellas.

            int cant = 0;
            for (int i = 0; i < reservasVisita.Count; i++)
            {
                    cant += reservasVisita[i].ObtenerAlumnosEnReserva(fechaHoraReserva,duracionEstimada);
            }

            return cant;
        } 

        public bool VerificarCantidadMaxVisitantes(int cantidadEstimada)
        {
            //Verifica si hay cupos disponibles en la sede actual.

            if (cantidadEstimada > this.cantMaxVisitantes)
            {
                MessageBox.Show("No hay cupos disponibles");
                return false;
            }
            else
            {
                return true;
            }
        }

        public int getCantidadMaxPorGuia()
        {
            //retorna el atributo cantMaxPorGuia de la clase Sede

            return cantMaxPorGuia;
        }
    }
}
