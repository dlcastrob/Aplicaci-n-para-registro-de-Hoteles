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
    public partial class nuevoUs : Form
    {

        Mad.Funciones funciones = new Mad.Funciones();
        public nuevoUs()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Nueva_Cuenta_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numNomRU_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void telCelRU_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funciones.AreControlsNotEmpty(this))
            {
                bool validar = false;
                DateTime fechaNacimiento = fechaNacRU.Value;
                DateTime fechaActual = DateTime.Today;
                string emailAddress = correoRU.Text;



                if (fechaNacimiento > fechaActual)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser posterior a la fecha actual.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bool isValidEmail = funciones.IsValidEmail(emailAddress);
                    if (!isValidEmail)
                    {
                        Console.WriteLine("El correo electrónico no  es válido.");

                    }

                }




            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void patRU_TextChanged(object sender, EventArgs e)
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

        private void matRU_TextChanged(object sender, EventArgs e)
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
    }
}
