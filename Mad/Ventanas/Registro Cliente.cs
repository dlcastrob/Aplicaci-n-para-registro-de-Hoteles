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
    public partial class Cliente : Form
    {
        Mad.Funciones funciones = new Mad.Funciones();

        public Cliente()
        {
            InitializeComponent();
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

        private void patRC_TextChanged(object sender, EventArgs e)
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

        private void matRC_TextChanged(object sender, EventArgs e)
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

        private void calleRC_TextChanged(object sender, EventArgs e)
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

        private void correoRC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funciones.AreControlsNotEmpty(this))
            {
                bool validar = false;
                DateTime fechaNacimiento = fechaNacRc.Value;
                DateTime fechaActual = DateTime.Today;
                string emailAddress = correoRC.Text;



                if (fechaNacimiento > fechaActual)
                {
                    validar = true;
                    MessageBox.Show("La fecha de nacimiento no puede ser posterior a la fecha actual.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                bool isValidEmail = funciones.IsValidEmail(emailAddress);


                if (isValidEmail == false)
                {
                    validar = true;
                    MessageBox.Show("El correo electrónico no  es válido.");

                }


             

                if (validar == false)
                {

                    MessageBox.Show("Todos los datos son correctos.");

                }

            }
            else
            {

                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void colRC_TextChanged(object sender, EventArgs e)
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
