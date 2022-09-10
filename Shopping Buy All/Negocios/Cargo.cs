using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class Cargo
    {
        public string nombre;
        public string descripcion;

        public bool esGuia()
        {
            //Comprueba que el cargo asignado al empleado es de tipo guia, en caso de serlo retorna true sino retorna false

            if (nombre == "Guia".Trim())
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
