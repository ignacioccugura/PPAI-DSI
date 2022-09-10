using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Buy_All.Clases;
using Shopping_Buy_All.Negocios;
using PPAI_CU92_G2.Formularios;

namespace Shopping_Buy_All.Formularios
{
    public partial class Frm_Login : Form
    {
        public string Pp_usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
        }
        public string Pp_pasword
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }
        public GestorReservaVisita gestor = new GestorReservaVisita();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            this.validarUsuario();

        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.validarUsuario();
            }
        }
        private void validarUsuario()
        {
            //valida que el usuario exista o no
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("El usuario esta vacio");
                txt_usuario.Focus();
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("El password esta vacio");
                txt_password.Focus();
                return;
            }

            Usuario user = new Usuario();
            user.nombre = txt_usuario.Text;
            user.contraseña = txt_password.Text;
            if (user.ValidarUsuario(gestor.usuarios) == Usuario.ResultadoValidacion.existe)
            {
                gestor.RegistrarSesion(user);
                Frm_inicio desk = new Frm_inicio();
                this.Hide();
                desk.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("El usuario y password no existen");
                return;
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            gestor.CargarDatos();
        }
    }
}
