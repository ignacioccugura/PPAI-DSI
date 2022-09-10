using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class Obra
    {
        public string nombre;
        public string duracionExtendida;
        public string duracionReducida;

        public string getDuracionExtendida()
        {
            //retorna el atributo duracionExtendida de la clase Obra
            return duracionExtendida;
        }
    }
}
