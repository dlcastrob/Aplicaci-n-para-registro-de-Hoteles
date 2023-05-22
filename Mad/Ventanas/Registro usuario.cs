using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mad.Funciones;

namespace Mad.Ventanas
{
    public partial class correoRU : Form
    {

        Mad.Funciones funciones = new Mad.Funciones();
        public correoRU()
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
                string emailAddress = correoRU1.Text;
                string contra = contraRU.Text; 


                if (fechaNacimiento > fechaActual)
                {
                    validar = true;
                    MessageBox.Show("La fecha de nacimiento no puede ser posterior a la fecha actual.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                bool isValidEmail = funciones.IsValidEmail(emailAddress);


                if (isValidEmail== false)
                {
                    validar = true;
                    MessageBox.Show("El correo electrónico no  es válido.");

                }


                bool isValidContra = IsPasswordValid(contra);
                if (!isValidContra)
                {
                    validar = true;
                    MessageBox.Show("El correo electrónico no  es válido.");

                }

                if (validar == false) {
                    MessageBox.Show("Todos los datos son correctos.");

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

        private void correoRU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNacRU_ValueChanged(object sender, EventArgs e)
        {
            fechaNacRU.MaxDate = DateTime.Today;

           // fechaNacRU.Value = DateTime.Now;

        }

        private void contraRU_TextChanged(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Green;
            label4.ForeColor = Color.Red;

            string texto = contraRU.Text;
            string texto2 = contraRU.Text;

            bool contieneMinuscula = texto.Any(char.IsLower);
            bool contieneMayuscula = texto2.Any(char.IsUpper);
            if (contieneMayuscula)
            {
                label5.BackColor = Color.Green;
            }
            else
            {
                label5.BackColor = Color.Red;
            }
            if (contieneMinuscula)
            {
                label6.BackColor = Color.Green;
            }
            else
            {
                label6.BackColor = Color.Red;
            }

         
        }

        private void colRU_TextChanged(object sender, EventArgs e)
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

        private void calleRU_TextChanged(object sender, EventArgs e)
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
