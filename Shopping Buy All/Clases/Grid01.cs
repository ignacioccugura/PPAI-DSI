using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE10.Clases
{
    class Grid01: DataGridView
    {
        /// <summary>
        /// Esta funcion permite formatear la grilla, con  el siguien formato
        /// dentro del parametro de entrada como texto
        /// (textoCabecera, ancho ;... textoCabecera,ancho)
        /// </summary>
        /// <param name="formato"></param>
        public void Formatear(string formato)
        {
            // textoCabecera, ancho ; textoCabecera,ancho ;...
            string[] datos_columna = formato.Split(';');
            //int cantidad_columnas = datos_columna.length;

            for (int i = 0; i < datos_columna.Length; i++)
            {
                string[] datos = datos_columna[i].Split(',');
                this.Columns.Add("columna"+ i.ToString(),datos[0].ToString());
                this.Columns[i].Width = int.Parse(datos[1].ToString());
                if (datos.Length == 3)
                {
                    switch (datos[2].Trim())
                    {
                        case "I":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                        case "D":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "C":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        default:
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                    }
                }
            }
             
        }
        public void Cargar(DataTable tabla)
        {
            this.Rows.Clear();
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                this.Rows.Add();
                for (int columna = 0; columna < tabla.Columns.Count; columna++)
                {
                    this.Rows[fila].Cells[columna].Value = tabla.Rows[fila][columna]; 
                }
                

            }
        }

    }
}
