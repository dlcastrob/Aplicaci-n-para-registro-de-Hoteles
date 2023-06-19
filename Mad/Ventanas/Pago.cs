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
using static Mad.Funciones;
using static Mad.Listas;

namespace Mad.Ventanas
{
    public partial class Pago : Form
    {
        private Reservación ventanaReservación;
        public string IdCliente { get; set; }
        public decimal Anticipo { get; set; }

        public Pago(Reservación reservación, string idCliente)


        {

            InitializeComponent();
            ventanaReservación = reservación;
            string idreserv = ventanaReservación.textBox4.Text;
            textBox2.Text = idreserv;
            IdCliente = idCliente; // Corregir esta línea para asignar el valor al campo IdCliente
            textBox3.Text = IdCliente;
            textBox4.Text = ventanaReservación.Anticipo.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            string reservacionID = textBox2.Text;
            string idCliente = textBox3.Text;
            int idCliente_ = int.Parse(idCliente);
            string tipoPago = comboBox1.Text;
            string monto = textBox4.Text;
            decimal monto_ = decimal.Parse(monto);
            string numTarjeta = textBox1.Text;
            var dB = new EnlaceDB();

            bool InsertarPago = dB.InsertarPago( reservacionID,  idCliente_, tipoPago, "Anticipo",  monto_,  numTarjeta);


            if (InsertarPago)
            {
                MessageBox.Show("Se realizo el pago correctamente.");
              

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al crear el tipo de habitación.");
            }

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla especial de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número ni una tecla de control
            }

            // Obtener el texto sin espacios en blanco
            string textWithoutSpaces = textBox1.Text.Replace(" ", "");

            // Verificar si ya se han ingresado 16 dígitos
            if (textWithoutSpaces.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada si ya se alcanzó el límite de 16 dígitos
            }

            // Agregar un espacio cada 4 dígitos (si no es una tecla de control)
            if (char.IsDigit(e.KeyChar) && textWithoutSpaces.Length < 16)
            {
                if (textWithoutSpaces.Length % 4 == 3 && textBox1.Text.Length < 16)
                {
                    textBox1.Text += " ";
                    textBox1.SelectionStart = textBox1.Text.Length; // Colocar el cursor al final del TextBox
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
