using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class Escuela
    {
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string mail { get; set; }
        public string telefCelular { get; set; }
        public string telefFijo { get; set; }

        public string MostrarNombre()
        {
            //devuelve el nombre de la escuela seleccionada

            return nombre;
        }
    }
}
