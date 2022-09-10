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
    public partial class Frm_FormularioDeReserva : Form
    {
        GestorReservaVisita gestor = new GestorReservaVisita();
        DataGridViewRow seleccionExposicion = new DataGridViewRow();
        DataGridViewRow seleccionGuia = new DataGridViewRow();
        public string escuelaSeleccionada;

        public Frm_FormularioDeReserva()
        {
            InitializeComponent();
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_CantidadVisitantes.Text =="")
            {
                MessageBox.Show("Debe ingresar una cantidad de visitantes");
                return;
            }
            else
            {
                gestor.tomarCantidadVisitantes(txt_CantidadVisitantes.Text);
            }
            if(cmb_sede.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe seleccionar una sede");
                return;
            }
            else
            {
                gestor.tomarSede(cmb_sede.SelectedIndex.ToString());
            }
            if (cmb_tipoVisita.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de visita");
                return;
            }
            else
            {
                gestor.tomarTipoVisita(cmb_tipoVisita.SelectedIndex.ToString());
            }
            gestor.tomarFechaHoraActual();
            gestor.buscarExpTempVigentes();
            MostrarDatosTempVigentes();
        }

        private void Frm_FormularioDeReserva_Load(object sender, EventArgs e)
        {
            gestor.CargarDatos();
            gestor.tomarEscuela(this.escuelaSeleccionada);
            cmb_sede.MostrarSedes(gestor.buscarSedes());
            gestor.buscarTipoVisita();
            cmb_tipoVisita.MostrarTipoVisita(gestor.buscarTipoVisita());
            btn_agregar2.Enabled = false;
            btn_borrar2.Enabled = false;
            txt_hora.Enabled = false;
            txt_fecha.Enabled = false;
        }

        private void MostrarDatosTempVigentes()
        {
            //Carga en la grilla los datos de las exposiiones temporales vigentes
            dataGridView1.Rows.Clear();
            for (int i = 0; i < gestor.ExposicionesTempVigentes.Count ; i++)
            {
                dataGridView1.Rows.Add(gestor.ExposicionesTempVigentes[i].nombre, gestor.ExposicionesTempVigentes[i].getHorarioHabilitado(),gestor.ExposicionesTempVigentes[i].publicoDestino.getPublicoDestino(),i.ToString());
            }
            if (gestor.ExposicionesTempVigentes.Count == 0)
            {
                MessageBox.Show("No hay exposiciones disponibles");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (dataGridView2.Rows.Count > 0)
            {
                
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[3].Value.ToString() == dataGridView1.CurrentRow.Cells[3].Value.ToString())
                    {
                        MessageBox.Show("Ya ha agregado esta exposicion!", "[ADVERTENCIA]");
                        flag = true;
                    }
                }
            }
            else
            {
                dataGridView2.Rows.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString());
                return;
            }
            if (flag == false)
            {
                dataGridView2.Rows.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString());
            }
            dataGridView2.ClearSelection();
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0 && dataGridView2.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una exposicion a borrar!!");
            }
            else
            {
                dataGridView2.Rows.Remove(seleccionExposicion);
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionExposicion = dataGridView2.CurrentRow;
        }

        private void btn_confirmarSeleccion_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                btn_agregar2.Enabled = true;
                btn_borrar2.Enabled = true;
                txt_hora.Enabled = true;
                txt_fecha.Enabled = true;
                txt_CantidadVisitantes.Enabled = false;
                btn_agregar.Enabled = false;
                btn_borrar.Enabled = false;
                cmb_sede.Enabled = false;
                cmb_tipoVisita.Enabled = false;
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = false;
                string[] indices = new string[dataGridView2.Rows.Count];
                for (int i = 0; i < indices.Length; i++)
                {
                    indices[i] = dataGridView2.Rows[0].Cells[3].Value.ToString();
                }

                gestor.tomarExposiciones(indices);                

            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una exposicion antes de continuar");
            }
            
        }
        private void btn_confirmar_Fecha_Click(object sender, EventArgs e)
        {
            if (txt_hora.Text != "")
            {
                txt_hora.Enabled = false;
                txt_fecha.Enabled = false;
                DateTime fechahora = DateTime.Parse(txt_fecha.Text +" "+ txt_hora.Text+":00");
                gestor.tomarFechaHoraReserva(fechahora);
                mostrarGuiasDisponibles();
                mostrarCantGuiasNecesarios();
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha y hora para la visita");
                return;
            }
        }
        private void mostrarGuiasDisponibles()
        {
            //Carga en la grilla los guias disponibles para el horario y sede seleccionados por el usuario
            dataGridView3.Rows.Clear();
            for (int i = 0; i < gestor.guiasDisponibles.Count; i++ )
            {
                dataGridView3.Rows.Add(gestor.guiasDisponibles[i].nombre, gestor.guiasDisponibles[i].apellido,i);
            }
            if (gestor.guiasDisponibles.Count == 0)
            {
                MessageBox.Show("No hay guias disponibles para el horario y/o dia seleccionado");
                txt_fecha.Enabled = true;
                txt_hora.Enabled = true;
            }
        }
        private void mostrarCantGuiasNecesarios()
        {
            //Carga en un textbox, la cantidad de guias necesarios
            txt_guiasNecesarios.Text = gestor.guiasNecesarios.ToString();
        }

        private void btn_agregar2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (dataGridView4.Rows.Count > 0)
            {

                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    if (dataGridView4.Rows[i].Cells[1].Value.ToString() == dataGridView3.CurrentRow.Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Ya ha agregado este guia!", "[ADVERTENCIA]");
                        flag = true;
                    }
                }
            }
            else
            {
                dataGridView4.Rows.Add(dataGridView3.CurrentRow.Cells[0].Value.ToString(), dataGridView3.CurrentRow.Cells[1].Value.ToString(), dataGridView3.CurrentRow.Cells[2].Value.ToString());
                return;
            }
            if (flag == false)
            {
                dataGridView4.Rows.Add(dataGridView3.CurrentRow.Cells[0].Value.ToString(), dataGridView3.CurrentRow.Cells[1].Value.ToString(), dataGridView3.CurrentRow.Cells[2].Value.ToString());
            }
            dataGridView4.ClearSelection();
        }

        private void cmb_sede_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void btn_confirmarReserva_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea finalizar la reserva?", "[ ATENCION ]", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView4.Rows.Count >= int.Parse(txt_guiasNecesarios.Text))
                {
                    string[] indice = new string[dataGridView4.Rows.Count];
                    for (int i = 0; i < dataGridView4.Rows.Count; i++)
                    {
                        indice[i] = dataGridView4.Rows[i].Cells[2].Value.ToString();
                    }
                    gestor.tomarGuias(indice);
                    gestor.tomarConfirmacion(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La cantidad de guias elegidos no cumple con la cantidad necesaria!", "[ ATENCION ]");
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
                gestor.tomarConfirmacion(false);
            }
        }

        private void btn_borrar2_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0 && dataGridView4.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un guia a borrar!!");
            }
            else
            {
                dataGridView4.Rows.Remove(seleccionGuia);
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGuia = dataGridView4.CurrentRow;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TomarSeleccionEscuela(string index)
        {
            //Recibe el indice de la escuela seleccionada y lo asigna en el atributo escuelaSeleccionada
            escuelaSeleccionada = index;
        }
    }
}
