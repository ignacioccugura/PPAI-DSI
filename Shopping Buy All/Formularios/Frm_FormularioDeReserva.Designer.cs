
namespace PPAI_CU92_G2.Formularios
{
    partial class Frm_FormularioDeReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_confirmarReserva = new System.Windows.Forms.Button();
            this.txt_guiasNecesarios = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_confirmar_Fecha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_agregar2 = new System.Windows.Forms.Button();
            this.btn_borrar2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indice4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indice5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_fecha = new Shopping_Buy_All.Clases.DateTimePicker01();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tipoVisita = new Shopping_Buy_All.Clases.ComboBox_Filtro();
            this.cmb_sede = new Shopping_Buy_All.Clases.ComboBox_Filtro();
            this.txt_CantidadVisitantes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirmarSeleccion = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreExp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicoDestino2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_confirmarReserva);
            this.groupBox1.Controls.Add(this.txt_guiasNecesarios);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_confirmar_Fecha);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_hora);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_tipoVisita);
            this.groupBox1.Controls.Add(this.cmb_sede);
            this.groupBox1.Controls.Add(this.txt_CantidadVisitantes);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(481, 727);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Reserva";
            // 
            // btn_confirmarReserva
            // 
            this.btn_confirmarReserva.Location = new System.Drawing.Point(280, 697);
            this.btn_confirmarReserva.Name = "btn_confirmarReserva";
            this.btn_confirmarReserva.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmarReserva.TabIndex = 21;
            this.btn_confirmarReserva.Text = "Confirmar Reserva";
            this.btn_confirmarReserva.UseVisualStyleBackColor = true;
            this.btn_confirmarReserva.Click += new System.EventHandler(this.btn_confirmarReserva_Click);
            // 
            // txt_guiasNecesarios
            // 
            this.txt_guiasNecesarios.Location = new System.Drawing.Point(126, 700);
            this.txt_guiasNecesarios.Name = "txt_guiasNecesarios";
            this.txt_guiasNecesarios.ReadOnly = true;
            this.txt_guiasNecesarios.Size = new System.Drawing.Size(100, 20);
            this.txt_guiasNecesarios.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 703);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Guias Necesarios:";
            // 
            // btn_confirmar_Fecha
            // 
            this.btn_confirmar_Fecha.Location = new System.Drawing.Point(350, 416);
            this.btn_confirmar_Fecha.Name = "btn_confirmar_Fecha";
            this.btn_confirmar_Fecha.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar_Fecha.TabIndex = 18;
            this.btn_confirmar_Fecha.Text = "Confirmar Fecha";
            this.btn_confirmar_Fecha.UseVisualStyleBackColor = true;
            this.btn_confirmar_Fecha.Click += new System.EventHandler(this.btn_confirmar_Fecha_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 424);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hora:";
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(280, 420);
            this.txt_hora.Mask = "00:00";
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(33, 20);
            this.txt_hora.TabIndex = 16;
            this.txt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(384, 703);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(67, 22);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(265, 71);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(61, 27);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar ";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_agregar2);
            this.groupBox3.Controls.Add(this.btn_borrar2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(20, 446);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(431, 245);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Guías:";
            // 
            // btn_agregar2
            // 
            this.btn_agregar2.Location = new System.Drawing.Point(339, 97);
            this.btn_agregar2.Margin = new System.Windows.Forms.Padding(1);
            this.btn_agregar2.Name = "btn_agregar2";
            this.btn_agregar2.Size = new System.Drawing.Size(67, 30);
            this.btn_agregar2.TabIndex = 5;
            this.btn_agregar2.Text = "Agregar";
            this.btn_agregar2.UseVisualStyleBackColor = true;
            this.btn_agregar2.Click += new System.EventHandler(this.btn_agregar2_Click);
            // 
            // btn_borrar2
            // 
            this.btn_borrar2.Location = new System.Drawing.Point(337, 213);
            this.btn_borrar2.Margin = new System.Windows.Forms.Padding(1);
            this.btn_borrar2.Name = "btn_borrar2";
            this.btn_borrar2.Size = new System.Drawing.Size(67, 29);
            this.btn_borrar2.TabIndex = 5;
            this.btn_borrar2.Text = "Borrar";
            this.btn_borrar2.UseVisualStyleBackColor = true;
            this.btn_borrar2.Click += new System.EventHandler(this.btn_borrar2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Guías Seleccionados:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre2,
            this.apellido2,
            this.indice4});
            this.dataGridView4.Location = new System.Drawing.Point(7, 130);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(397, 80);
            this.dataGridView4.TabIndex = 1;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // nombre2
            // 
            this.nombre2.HeaderText = "nombre";
            this.nombre2.MinimumWidth = 6;
            this.nombre2.Name = "nombre2";
            this.nombre2.ReadOnly = true;
            this.nombre2.Width = 125;
            // 
            // apellido2
            // 
            this.apellido2.HeaderText = "apellido";
            this.apellido2.MinimumWidth = 6;
            this.apellido2.Name = "apellido2";
            this.apellido2.ReadOnly = true;
            this.apellido2.Width = 125;
            // 
            // indice4
            // 
            this.indice4.HeaderText = "indice";
            this.indice4.MinimumWidth = 6;
            this.indice4.Name = "indice4";
            this.indice4.ReadOnly = true;
            this.indice4.Visible = false;
            this.indice4.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.indice5});
            this.dataGridView3.Location = new System.Drawing.Point(7, 16);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(397, 80);
            this.dataGridView3.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // indice5
            // 
            this.indice5.HeaderText = "indice";
            this.indice5.MinimumWidth = 6;
            this.indice5.Name = "indice5";
            this.indice5.ReadOnly = true;
            this.indice5.Visible = false;
            this.indice5.Width = 125;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(69, 420);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Pp_ConSeleccion = false;
            this.txt_fecha.Pp_MensajeError = null;
            this.txt_fecha.Pp_NombreCampo = null;
            this.txt_fecha.Pp_Validable = false;
            this.txt_fecha.Size = new System.Drawing.Size(135, 20);
            this.txt_fecha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 424);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha:";
            // 
            // cmb_tipoVisita
            // 
            this.cmb_tipoVisita.FormattingEnabled = true;
            this.cmb_tipoVisita.Location = new System.Drawing.Point(149, 75);
            this.cmb_tipoVisita.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_tipoVisita.Name = "cmb_tipoVisita";
            this.cmb_tipoVisita.Pp_Conseleccion = false;
            this.cmb_tipoVisita.Pp_descripcion = null;
            this.cmb_tipoVisita.Pp_Pk = null;
            this.cmb_tipoVisita.Pp_tabla = null;
            this.cmb_tipoVisita.Size = new System.Drawing.Size(92, 21);
            this.cmb_tipoVisita.TabIndex = 7;
            // 
            // cmb_sede
            // 
            this.cmb_sede.FormattingEnabled = true;
            this.cmb_sede.Location = new System.Drawing.Point(149, 53);
            this.cmb_sede.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_sede.Name = "cmb_sede";
            this.cmb_sede.Pp_Conseleccion = false;
            this.cmb_sede.Pp_descripcion = null;
            this.cmb_sede.Pp_Pk = null;
            this.cmb_sede.Pp_tabla = null;
            this.cmb_sede.Size = new System.Drawing.Size(92, 21);
            this.cmb_sede.TabIndex = 6;
            this.cmb_sede.SelectedIndexChanged += new System.EventHandler(this.cmb_sede_SelectedIndexChanged);
            // 
            // txt_CantidadVisitantes
            // 
            this.txt_CantidadVisitantes.Location = new System.Drawing.Point(149, 27);
            this.txt_CantidadVisitantes.Margin = new System.Windows.Forms.Padding(1);
            this.txt_CantidadVisitantes.Name = "txt_CantidadVisitantes";
            this.txt_CantidadVisitantes.Size = new System.Drawing.Size(92, 20);
            this.txt_CantidadVisitantes.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_confirmarSeleccion);
            this.groupBox2.Controls.Add(this.btn_borrar);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(434, 285);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Exposiciones:";
            // 
            // btn_confirmarSeleccion
            // 
            this.btn_confirmarSeleccion.Location = new System.Drawing.Point(184, 247);
            this.btn_confirmarSeleccion.Name = "btn_confirmarSeleccion";
            this.btn_confirmarSeleccion.Size = new System.Drawing.Size(118, 23);
            this.btn_confirmarSeleccion.TabIndex = 5;
            this.btn_confirmarSeleccion.Text = "Confirmar Seleccion";
            this.btn_confirmarSeleccion.UseVisualStyleBackColor = true;
            this.btn_confirmarSeleccion.Click += new System.EventHandler(this.btn_confirmarSeleccion_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(339, 248);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(67, 22);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(339, 116);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(67, 22);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exposiciones Seleccionadas:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreExp2,
            this.horario2,
            this.publicoDestino2,
            this.indice2});
            this.dataGridView2.Location = new System.Drawing.Point(9, 140);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(397, 106);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreExp,
            this.horario,
            this.publicoDestino,
            this.indice});
            this.dataGridView1.Location = new System.Drawing.Point(9, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(397, 100);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Visita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sede:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Visitantes:";
            // 
            // nombreExp
            // 
            this.nombreExp.HeaderText = "nombreExp";
            this.nombreExp.MinimumWidth = 6;
            this.nombreExp.Name = "nombreExp";
            this.nombreExp.ReadOnly = true;
            this.nombreExp.Width = 125;
            // 
            // horario
            // 
            this.horario.HeaderText = "horario";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // publicoDestino
            // 
            this.publicoDestino.HeaderText = "publico destino";
            this.publicoDestino.Name = "publicoDestino";
            this.publicoDestino.ReadOnly = true;
            // 
            // indice
            // 
            this.indice.HeaderText = "indice";
            this.indice.MinimumWidth = 6;
            this.indice.Name = "indice";
            this.indice.ReadOnly = true;
            this.indice.Visible = false;
            this.indice.Width = 125;
            // 
            // nombreExp2
            // 
            this.nombreExp2.HeaderText = "nombreExp";
            this.nombreExp2.MinimumWidth = 6;
            this.nombreExp2.Name = "nombreExp2";
            this.nombreExp2.ReadOnly = true;
            this.nombreExp2.Width = 125;
            // 
            // horario2
            // 
            this.horario2.HeaderText = "horario";
            this.horario2.Name = "horario2";
            this.horario2.ReadOnly = true;
            // 
            // publicoDestino2
            // 
            this.publicoDestino2.HeaderText = "publico destino";
            this.publicoDestino2.Name = "publicoDestino2";
            this.publicoDestino2.ReadOnly = true;
            // 
            // indice2
            // 
            this.indice2.HeaderText = "indice";
            this.indice2.MinimumWidth = 6;
            this.indice2.Name = "indice2";
            this.indice2.ReadOnly = true;
            this.indice2.Visible = false;
            this.indice2.Width = 125;
            // 
            // Frm_FormularioDeReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(525, 609);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 484);
            this.Name = "Frm_FormularioDeReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FormularioDeReserva";
            this.Load += new System.EventHandler(this.Frm_FormularioDeReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CantidadVisitantes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Shopping_Buy_All.Clases.ComboBox_Filtro cmb_tipoVisita;
        private Shopping_Buy_All.Clases.ComboBox_Filtro cmb_sede;
        private Shopping_Buy_All.Clases.DateTimePicker01 txt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_agregar2;
        private System.Windows.Forms.Button btn_borrar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_hora;
        private System.Windows.Forms.Button btn_confirmarSeleccion;
        private System.Windows.Forms.Button btn_confirmar_Fecha;
        private System.Windows.Forms.TextBox txt_guiasNecesarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice4;
        private System.Windows.Forms.Button btn_confirmarReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicoDestino2;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
    }
}