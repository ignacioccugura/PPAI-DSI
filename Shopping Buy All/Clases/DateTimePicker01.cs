using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Clases
{
    class DateTimePicker01:DateTimePicker
    {
        public string Pp_NombreCampo { get; set; }

        public bool Pp_Validable { get; set; }

        public string Pp_MensajeError { get; set; }

        public bool Pp_ConSeleccion{ get; set; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DateTimePicker01
            // 
            this.ValueChanged += new System.EventHandler(this.DateTimePicker01_ValueChanged);
            this.ResumeLayout(false);

        }

        private void DateTimePicker01_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
