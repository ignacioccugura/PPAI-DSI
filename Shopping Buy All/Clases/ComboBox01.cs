using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Shopping_Buy_All.Clases;

namespace Shopping_Buy_All.Clases
{
    class ComboBox01 : ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla { get; set; }
        public string Pp_NombreCampo { get; set; }

        public bool Pp_ConSeleccion { get; set; }

        public bool Pp_Validable { get; set; }

        public string Pp_MensajeError { get; set; }
        
        public bool Pp_Cargado { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + "," + Pp_descripcion + " FROM  " + Pp_tabla;

            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_Select(sql);
            if (Pp_ConSeleccion==true )
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
            this.Pp_Cargado = true;
            
        }
        public void CargarCombo2()
        {
            string sql = "SELECT " + Pp_Pk + "," + Pp_descripcion + " FROM  " + Pp_tabla;

            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_Select(sql);
            this.Pp_Cargado = true;
            this.SelectedIndex = -1;

        }

        public void CargarCombo(int idMarca)
        {
            string sql = "SELECT " + Pp_Pk + "," + Pp_descripcion + " FROM  " + Pp_tabla + " WHERE idMarca= "+idMarca;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_Select(sql);
            if (Pp_ConSeleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }

        }
        public void CargarCombo1(string doc)
        {
            string sql = "SELECT " + Pp_Pk + " FROM  " + Pp_tabla + " WHERE nroDocTitular= " + doc;
            
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_Select(sql);
            if (this.Pp_ConSeleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }
    }
}
