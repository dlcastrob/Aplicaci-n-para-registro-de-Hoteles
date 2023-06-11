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
        bool sidebarExpand;
        private Guid miGuid;


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {       //MINIMIZA
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SideBarTimer.Stop();
                }

            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.correoRU f_registro = new Ventanas.correoRU();
            f_registro.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.Cliente f_cliente = new Ventanas.Cliente();
            f_cliente.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.Form1 f_hotel = new Ventanas.Form1();
            f_hotel.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.Estatus_habitacion f_estatus = new Ventanas.Estatus_habitacion();
            f_estatus.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.HistorialCliente f_historial = new Ventanas.HistorialCliente();
            f_historial.Show();
        }
        //PORQUE NO FUNCIONA EL LOGIN AAAAAAAAAAAAAAAAAAAAAAAAAAA
        private void button15_Click(object sender, EventArgs e)
        {

            //Ventanas.login f_login = new Ventanas.login();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.RepOcupacionHoteñ f_repHotel = new Ventanas.RepOcupacionHoteñ();
            f_repHotel.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.Cancelacion f_cancel = new Ventanas.Cancelacion();
            f_cancel.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.Reservación f_reserv = new Ventanas.Reservación();
            f_reserv.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.RepVentas f_ventas = new Ventanas.RepVentas();
            f_ventas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Pagar", "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //reserv.Show();
                Ventanas.Pago reserv = new Ventanas.Pago();

                reserv.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                // El usuario seleccionó "No"
                // Realiza las acciones correspondientes
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea agregar servicios adicionales?", "Servicios adicionales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //reserv.Show();
                Ventanas.Servicios_adicionales reserv = new Ventanas.Servicios_adicionales();

                reserv.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                // El usuario seleccionó "No"
                // Realiza las acciones correspondientes
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reservación_Load(object sender, EventArgs e)
        {
            miGuid = Guid.NewGuid();
            textBox4.Text = miGuid.ToString();

        }



        //AQUI TERMINA  EL SIDE MENU
    }
}
