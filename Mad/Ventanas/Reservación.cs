using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad.Ventanas
{
    public partial class Reservación : Form
    {
        private Form1 form1;
        public Reservación()
        {
            InitializeComponent();
           form1 = new Form1();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           /* DateTime fechaSeleccionada = form1.ObtenerFechaSeleccionada;
            

           // DateTime fechaInicio = fecha.Value.Date; // Obtén la fecha seleccionada sin la parte de la hora
            DateTime fechaInicio = fechaSeleccionada.Date; // Obtén la fecha seleccionada sin la parte de la hora
            DateTime fechaActual = DateTime.Today;

            if (fechaInicio < fechaActual)
            {
                MessageBox.Show("La fecha de inicio debe ser igual o posterior al día actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fechaInicioDTP.Value = fechaActual; // Establece la fecha actual como valor por defecto
            }*/
        }
    }
}
