using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Shopping_Buy_All.Negocios;


namespace Shopping_Buy_All.Clases

{
    class ComboBox_Filtro : ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla { get; set; }
        public bool Pp_Conseleccion { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_Select(sql);
            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }
        public void MostrarSedes(List <Sede> sedes)
        {
            
            for (int i = 0; i < sedes.Count; i++)
            {

                this.Items.Add(sedes[i].MostrarNombre());
                
            }
        }
        public void MostrarTipoVisita(List<TipoVisita> tipoVisita)
        {

            for (int i = 0; i < tipoVisita.Count; i++)
            {

                this.Items.Add(tipoVisita[i].MostrarNombre());

            }
        }
    }
}
