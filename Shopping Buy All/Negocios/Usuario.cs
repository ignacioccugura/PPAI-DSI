using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Negocios
{
    public class Usuario
    {
        public DateTime caducidad;
        public string contraseña;
        public string nombre;
        public Empleado empleado;
        public enum ResultadoValidacion { existe , no_existe}

        public ResultadoValidacion ValidarUsuario(List<Usuario> lista)
        {
            //Recibe como parametro la lista con los usuarios existentes, valida que los datos ingresados por el usuario en el login sean correspondientes con algun
            // usuario ya registrado. En caso de resultar positivo, retorna el enum ResultadoValidacion.existe, caso contrario retorna ResultadoValidacion.no_existe

            for (int i = 0; i < lista.Count; i++)
            {   
                if (this.contraseña.Trim() == lista[i].contraseña.Trim() && this.nombre.Trim() == lista[i].nombre.Trim())
                {
                    return ResultadoValidacion.existe;
                }
            }
            return ResultadoValidacion.no_existe;
        }

        public Empleado getUsuario()
        {
            //retorna el objeto empleado perteneciente al objeto usuario del cual se llama este metodo

            return this.empleado;
        }
    }
}
