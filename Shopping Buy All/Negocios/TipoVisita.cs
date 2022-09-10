using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class TipoVisita
    {
        public string nombre { get; set; }

        public string MostrarNombre()
        {
            //retorna el nombre del tipo de visita

            return nombre;
        }
    }
}
