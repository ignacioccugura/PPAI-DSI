using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Negocios
{
    public class DetalleExposicion
    {
        public Obra obra;

        public string buscarDurExtObra()
        {
            //Retorna el resultado obtenido por el metodo getDuracionExtendida()
            return this.obra.getDuracionExtendida();
        }
    }
}
