using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Shopping_Buy_All.Clases
{
    class BE_Acceso_Datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void conectar()
        {
            conexion.ConnectionString = "Data Source=DESKTOP-ESMAF15\\SQLEXPRESS;Initial Catalog=Museo;Integrated Security=True";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable Ejecutar_Select (string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void Insertar ( string sqlInsertar)
        {
            InsModBorr(sqlInsertar);
        }
        public void Modificar(string sqlModificar)
        {
            InsModBorr(sqlModificar);

        }
        public void Borrar(string sqlDelete)
        {
            InsModBorr(sqlDelete);
        }

        private void InsModBorr(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }

    }
}
