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

        string idcliente;
        public decimal Anticipo { get; set; }

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
            var dB = new EnlaceDB();

            button3.Enabled = false;

            DialogResult result = MessageBox.Show("¿Desea Pagar", "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                //    DataGridViewRow selectedRow3 = dataGridView1.SelectedRows[0];

                DataGridViewCell cell = selectedRow.Cells["nombre"];
                string nombre = cell.Value.ToString();

                DataGridViewCell cell4 = selectedRow.Cells["apellidos"];
                string apellidos = cell4.Value.ToString();

                DataTable resultado1 = dB.ObtenerIDCliente(apellidos, nombre);

                idcliente = resultado1.Rows[0]["IDCLIENTE"].ToString();

                //reserv.Show();

                Ventanas.Pago reserv = new Ventanas.Pago(this, idcliente);
             //   reserv.IdCliente = idcliente;

                reserv.ShowDialog();
                button3.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                // El usuario seleccionó "No"
                // Realiza las acciones correspondientes
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var dB = new EnlaceDB();

            //obtener id rerse
            string reservacionID = textBox4.Text;

            //int clienteID =
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
        //    DataGridViewRow selectedRow3 = dataGridView1.SelectedRows[0];

            DataGridViewCell cell = selectedRow.Cells["nombre"]; 
            string nombre = cell.Value.ToString();

            DataGridViewCell cell4 = selectedRow.Cells["apellidos"]; 
            string apellidos = cell4.Value.ToString();

            DataTable resultado1 = dB.ObtenerIDCliente(apellidos,nombre);

             idcliente = resultado1.Rows[0]["IDCLIENTE"].ToString();


            //int hotelID =
            DataGridViewRow selectedRow2 = dataGridView3.SelectedRows[0];

            DataGridViewCell cell3 = selectedRow2.Cells["NombreHotel"]; 
            string nombrehotel = cell3.Value.ToString();

            DataTable resultado = dB.ObtenerIDHotel(nombrehotel);

            string idHotel = resultado.Rows[0]["HotelID"].ToString();


            //habitacion id

            DataGridViewCell cell2 = dataGridView2.Rows[0].Cells[0];
            string idhab = cell2.Value.ToString();

            //fecha de entrada

            string fechaentrada = dateTimePicker2.Text;


            //fecha de salida
             string fechasalida = dateTimePicker2.Text;


            //anticipo decimal 

            decimal anticipo = decimal.Parse(textBox5.Text);
            //cantidad de habitaciones

            //cantidad de personas 
            decimal numPersonas = numericUpDown1.Value;
            int numPersonas_ =(int)numPersonas;



            //var dB = new EnlaceDB();
             bool InsertarReservacion = dB.InsertarReservacion(reservacionID,  idcliente,  idHotel, idhab, fechaentrada, fechasalida,  anticipo, 1, numPersonas_, "Nueva");
            //public bool dB.InsertarReservacion(reservacionID, int clienteID, idHotel, int habitacionID,  fechaEntrada,  fechaSalida, decimal anticipo, 1, numPersonas, "Nueva")


            
            //var dB = new EnlaceDB();
           // bool InsertarReservacion = dB.InsertarReservacion(apellidos, nombre, domicilioCompleto, rfc, emailAddress, estadoCivil, referenciaHotel, fechaNacimiento_, telefonoCasa, telefonoCelular);
            if (InsertarReservacion == true)
            {

                MessageBox.Show("Se registro Correctamente");
                DialogResult result = MessageBox.Show("¿Desea Agregar servicios adicionales", "Agregar Servicios adicionales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            else
            {
                MessageBox.Show("El registro salio mal");


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
            button3.Enabled = false;
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

        private void button2_Click(object sender, EventArgs e) {
            // Declarar la variable 'valido' en un alcance más amplio, fuera del evento

          bool  valido = true; // Inicializar la variable en 'false' al inicio del evento
            if (
              dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Faltan campos por seleccionar.");
                valido = false;
            }

            if (
                dateTimePicker2.Value == DateTimePicker.MinimumDateTime )
            {
                MessageBox.Show("Faltan campos por seleccionar.");
                valido = false;
            }


           
            if (
               numericUpDown1.Value == numericUpDown1.Minimum)
            {
                MessageBox.Show("Faltan campos por seleccionar.");
                valido = false;

            }
            if (
               comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan campos por seleccionar.");
                valido = false;

            }


            if (valido)
            {
                string textoSeleccionado = comboBox1.SelectedItem.ToString();

                var obj = new EnlaceDB();
                var tablita = new DataTable();
                tablita = obj.BuscarHotelesenCiudad(textoSeleccionado);

                // Mostrar los resultados en un DataGridView u otro control adecuado
                dataGridView3.DataSource = tablita;
            }


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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnlaceDB dB = new EnlaceDB();
            DataTable tabla = new DataTable();
            string textoSeleccionado = dataGridView3.Rows[0].Cells[0].Value.ToString();

            string BuscarIDhotel = dB.BuscarIDhotel(textoSeleccionado);
            int idhotel = int.Parse(BuscarIDhotel);
            DateTime fechaActual = FechaActual.Fecha;
            string fecha_ = fechaActual.ToString();
            tabla = dB.BuscarHabitaciones(idhotel,fecha_);

            dataGridView4.DataSource = tabla;


        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnlaceDB dB = new EnlaceDB();
            DataTable tabla = new DataTable();
            string textoSeleccionado = dataGridView3.Rows[0].Cells[0].Value.ToString();

            string BuscarIDhotel = dB.BuscarIDhotel(textoSeleccionado);
            int idhotel = int.Parse(BuscarIDhotel);
            DateTime fechaActual = FechaActual.Fecha;
            string fecha_ = fechaActual.ToString();
            tabla = dB.BuscarHabitaciones(idhotel, fecha_);

            dataGridView4.DataSource = tabla;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
                // Obtener la fila seleccionada del DataGridView1
                DataGridViewRow selectedRow = dataGridView4.SelectedRows[0];

                // Verificar si las columnas ya han sido agregadas a DataGridView2
                if (dataGridView2.Columns.Count == 0)
                {
                    // Clonar las columnas del DataGridView1 en DataGridView2
                    foreach (DataGridViewColumn column in dataGridView4.Columns)
                    {
                        dataGridView2.Columns.Add(column.Clone() as DataGridViewColumn);
                    }
                }

                // Crear una nueva fila en el DataGridView2
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();

                // Copiar los valores de las celdas de la fila seleccionada a la nueva fila
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = selectedRow.Cells[i].Value;
                }

                // Agregar la nueva fila al DataGridView2
                dataGridView2.Rows.Add(newRow);

            DataGridViewCell cell = dataGridView4.Rows[0].Cells[2];
            string preciohab = cell.Value.ToString();
            // Obtener el valor de la columna 3 (índice 2) de la fila seleccionada
            //  string preciohab = selectedRow.Cells[2].Value.ToString();
            decimal numPersonas = numericUpDown1.Value;
            float numper_ = Convert.ToSingle(numPersonas);  // Convertir decimal a float

          
            float preciohab_ = float.Parse(preciohab);

            float total = preciohab_ * numper_;

            float anticipo = (float)(total * 0.15);
            Anticipo = (decimal)anticipo;
            textBox2.Text = total.ToString();
            textBox5.Text = anticipo.ToString();

        }

        private void IN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.CHECKIN f_checkin = new Ventanas.CHECKIN();
            f_checkin.Show();
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanas.CHECKOUT f_checkout = new Ventanas.CHECKOUT();
            f_checkout.Show();
        }





        //AQUI TERMINA  EL SIDE MENU
    }
}
