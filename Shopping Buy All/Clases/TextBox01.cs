using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Shopping_Buy_All.Clases
{
    class TextBox01 : TextBox
    {
        public string Pp_Tabla { set; get; }
        public string Pp_NombreCampo { set; get; }
        public bool Pp_Validable { get; set; }

        public string Pp_MensajeError { get; set; }
    }
}
