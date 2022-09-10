using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shopping_Buy_All.Clases;
using Shopping_Buy_All.Negocios;


namespace PPAI_CU92_G2.Formularios
{
    public partial class Frm_SeleccionEscuela : Form
    {
        GestorReservaVisita gestor = new GestorReservaVisita();
        public Frm_SeleccionEscuela()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            gestor.tomarEscuela(dataGridView1.CurrentRow.Index.ToString());
            Frm_FormularioDeReserva deReserva = new Frm_FormularioDeReserva();
            deReserva.TomarSeleccionEscuela(dataGridView1.CurrentRow.Index.ToString());
            deReserva.Show();
        }

        

        private void MostrarEscuelas(List<Escuela> lista)
        {
            //Carga en la grilla las escuelas existentes
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(lista[i].MostrarNombre());
            }
        }

        private void Frm_SeleccionEscuela_Load(object sender, EventArgs e)
        {
            gestor.CargarDatos();
            MostrarEscuelas(gestor.buscarEscuelas());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
