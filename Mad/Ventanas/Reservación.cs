using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

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
            var obj = new EnlaceDB();
            var tablita = new DataTable();
            tablita = obj.BuscarCiudadHotel();
            foreach (DataRow row in tablita.Rows)
            {
                string ciudad = row["Ciudad"].ToString();
                comboBox1.Items.Add(ciudad);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            /*
            DateTime fechaSeleccionada = form1.ObtenerFechaSeleccionada();
            

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
/*

            string reservacionID = textBox4.Text;
            int servicioID = 1;
            int clienteID = 1;
            int hotelID = 1;
            int habitacionID = 1;
            DateTime fechaEntrada = DateTime.Now;
            DateTime fechaSalida = DateTime.Now.AddDays(3);
            decimal anticipo = 100.50m;
            int usuarioOperativo = 123;
            int cantidadHabitaciones = 1;
            int cantidadPersonasHabitacion = 2;
            string estado = "Activa";

            var dB = new EnlaceDB();
            bool insertarReservacion = dB.InsertarReservacion()

            if (insertarReservacion)
            {
                MessageBox.Show("Reservación creada exitosamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al crear la reservación.");
            }

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
*/
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

        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = textBox1.Text;
            int opcionBusqueda = 0;

            // Verificar el RadioButton seleccionado y asignar la opción correspondiente
            if (radioButton1.Checked)
            {
                opcionBusqueda = 1;
            }
            else if (radioButton2.Checked)
            {
                opcionBusqueda = 2;
            }
            else if (radioButton3.Checked)
            {
                opcionBusqueda = 3;
            }


            // Llamar al procedimiento almacenado para buscar clientes
            var obj = new EnlaceDB();
            var tablita = new DataTable();
             tablita = obj.BuscarClientes(busqueda, opcionBusqueda);

            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView1.DataSource = tablita;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = comboBox1.SelectedItem.ToString();

            var obj = new EnlaceDB();
            var tablita = new DataTable();
            tablita = obj.BuscarHotelesenCiudad(textoSeleccionado);

            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView3.DataSource = tablita;
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            string fechaEntrada = dateTimePicker2.Text;
            string fechaSalida = dateTimePicker1.Text;


            var obj = new EnlaceDB();
            var tablita = new DataTable();
            tablita = obj.BuscarhabReserv(fechaEntrada, fechaSalida);

            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView3.DataSource = tablita;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        //AQUI TERMINA  EL SIDE MENU
    }
}
