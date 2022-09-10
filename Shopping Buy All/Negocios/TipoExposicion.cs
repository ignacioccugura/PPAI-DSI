using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class TipoExposicion
    {
        public string nombre;
        public bool EsTemporal()
        {
            //verifica si el tipo de exposicion es temporal, en caso positivo retorna true, caso contrario retorna false

            if (nombre.Trim() == "Exposicion temporal")
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
