using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WindowsFormsApplication1;

namespace Mad.Ventanas
{
    public partial class Form1 : Form
    {
        public object fechaInicioDTP { get; internal set; }
        bool sidebarExpand;
        Mad.Funciones funciones = new Mad.Funciones();
        private string nombreHotel = string.Empty; // Declarar la variable a nivel de clase

        public Form1()

        {
            InitializeComponent();
            var obj = new EnlaceDB();

            var tablita = new DataTable();
            tablita = obj.ObtenerNombresHoteles();
            foreach (DataRow row in tablita.Rows)
            {
                string nombre = row["NombreHotel"].ToString();
                comboBox4.Items.Add(nombre);
            }

            var tablita2 = new DataTable();
            tablita2 = obj.ObtenerNombresHoteles();
            foreach (DataRow row in tablita2.Rows)
            {
                string nombre = row["NombreHotel"].ToString();
                comboBox2.Items.Add(nombre);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       

        private void tabControl1_Selecting_1(object sender, TabControlCancelEventArgs e)
        {

        }

    

     
      

        //AQUI EMPIEZA EL SIDE MENU

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

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (funciones.AreControlsNotEmpty(this))
                {
                    bool validar = false;

                    // Validaciones y obtención de valores
                    string nombreHotel = textBox1.Text;
                    string ciudad = textBox2.Text;
                    string estado = textBox3.Text;
                    string pais = textBox4.Text;
                    string domicilio = textBox7.Text + maskedTextBox2.Text + textBox8.Text;
                    int numeroPisos= int.Parse(textBox9.Text);
                string fechaop_ = dateTimePicker1.Text;


                if (validar == false)
                    {
                        // Llamada al método para insertar el hotel
                        var dB = new EnlaceDB();
                        bool insertarHotel = dB.InsertarHotel(nombreHotel, ciudad, estado, pais, domicilio, numeroPisos,fechaop_);
                        if (insertarHotel)
                        {
                            MessageBox.Show("Hotel registrado correctamente.");

                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        textBox4.Text = string.Empty;
                        textBox7.Text = string.Empty;
                        textBox8.Text = string.Empty;
                        textBox9.Text = string.Empty;

                        

                    }
                    else
                        {
                            MessageBox.Show("Ha ocurrido un error al registrar el hotel.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string firstLetter = textBox.Text.Substring(0, 1).ToUpper();
                string remainingText = textBox.Text.Substring(1).ToLower();
                textBox.Text = firstLetter + remainingText;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string firstLetter = textBox.Text.Substring(0, 1).ToUpper();
                string remainingText = textBox.Text.Substring(1).ToLower();
                textBox.Text = firstLetter + remainingText;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string firstLetter = textBox.Text.Substring(0, 1).ToUpper();
                string remainingText = textBox.Text.Substring(1).ToLower();
                textBox.Text = firstLetter + remainingText;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string firstLetter = textBox.Text.Substring(0, 1).ToUpper();
                string remainingText = textBox.Text.Substring(1).ToLower();
                textBox.Text = firstLetter + remainingText;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string firstLetter = textBox.Text.Substring(0, 1).ToUpper();
                string remainingText = textBox.Text.Substring(1).ToLower();
                textBox.Text = firstLetter + remainingText;
                textBox.SelectionStart = textBox.Text.Length;
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string firstLetter = textBox.Text.Substring(0, 1).ToUpper();
                string remainingText = textBox.Text.Substring(1).ToLower();
                textBox.Text = firstLetter + remainingText;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        public void button5_Click(object sender, EventArgs e)
        {
            

                    // Llamada al método para insertar el hotel
                    var dB = new EnlaceDB();

            string textoSeleccionado = comboBox4.SelectedItem.ToString();

            string BuscarIDhotel = dB.BuscarIDhotel(textoSeleccionado);
                    int idhotel = int.Parse(BuscarIDhotel);

                          string nombreServicio = textBox14.Text; // Obtener el nombre del servicio adicional desde el formulario
                          decimal precioServicio = decimal.Parse(textBox13.Text); // Obtener el precio del servicio adicional desde el formulario
                        bool insertarServicioAdicional = dB.InsertarServicioAdicional(idhotel, nombreServicio, precioServicio);
                          if (insertarServicioAdicional)
                          {
                              MessageBox.Show("Servicio adicional registrado correctamente.");

                                comboBox4.SelectedItem = default;
                                 textBox14.Text = string.Empty;
                                 textBox13.Text = string.Empty;

            }
                          else
                          {
                              MessageBox.Show("Ha ocurrido un error al registrar el servicio adicional.");
                          }
                     
            
        }

        public void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dB = new EnlaceDB();

            string tipoHabitacionID = textBox6.Text;

            string textoSeleccionado = comboBox2.SelectedItem.ToString();

            string BuscarIDhotel = dB.BuscarIDhotel(textoSeleccionado);
            int idhotel = int.Parse(BuscarIDhotel);
            int hotelID = idhotel;
            string precio = textBox5.Text;
            decimal precioNochePersona = decimal.Parse(precio);
            int capacidadMaxima = int.Parse(numericUpDown1.Text);
            int numeroCamas = int.Parse(numericUpDown3.Text);
            string tiposCama = comboBox1.SelectedItem.ToString();
            int nivelHabitacion = int.Parse(numericUpDown2.Text);
            int usuarioOperativo = 1;
            int cantidadHabitaciones = int.Parse(numericUpDown1.Text);

            bool insertarTipoHabitacion = dB.InsertarTipoHabitacion(tipoHabitacionID, hotelID, precioNochePersona, capacidadMaxima, numeroCamas, tiposCama, nivelHabitacion,cantidadHabitaciones);

            if (insertarTipoHabitacion)
            {
                MessageBox.Show("Tipo de habitación creado exitosamente.");
                comboBox2.SelectedItem = default;
                comboBox1.SelectedItem = default;
                textBox5.Text = string.Empty; 
                textBox6.Text = string.Empty;
                textBox11.Text = string.Empty;
                textBox12.Text = string.Empty;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al crear el tipo de habitación.");
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //AQUI TERMINA  EL SIDE MENU
    }
}
