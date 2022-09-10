
namespace PPAI_CU92_G2.Formularios
{
    partial class Frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inicio));
            this.btn_RegistrarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RegistrarReserva
            // 
            this.btn_RegistrarReserva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RegistrarReserva.BackgroundImage")));
            this.btn_RegistrarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RegistrarReserva.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RegistrarReserva.Location = new System.Drawing.Point(22, 12);
            this.btn_RegistrarReserva.Name = "btn_RegistrarReserva";
            this.btn_RegistrarReserva.Size = new System.Drawing.Size(450, 405);
            this.btn_RegistrarReserva.TabIndex = 0;
            this.btn_RegistrarReserva.Text = "Registrar Reserva de Visita Guiada";
            this.btn_RegistrarReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RegistrarReserva.UseVisualStyleBackColor = true;
            this.btn_RegistrarReserva.Click += new System.EventHandler(this.btn_RegistrarReserva_Click);
            // 
            // Frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 439);
            this.Controls.Add(this.btn_RegistrarReserva);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RegistrarReserva;
    }
}