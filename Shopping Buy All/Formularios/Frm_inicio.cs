using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPAI_CU92_G2.Formularios
{
    public partial class Frm_inicio : Form
    {
        public Frm_inicio()
        {
            InitializeComponent();
        }

        private void btn_RegistrarReserva_Click(object sender, EventArgs e)
        {
            Frm_SeleccionEscuela registrar = new Frm_SeleccionEscuela();
            registrar.Show();
        }
    }
}
