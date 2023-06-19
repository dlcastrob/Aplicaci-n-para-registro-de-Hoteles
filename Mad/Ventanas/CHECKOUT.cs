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
    public partial class CHECKOUT : Form
    {
        public CHECKOUT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CHECKOUT_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
