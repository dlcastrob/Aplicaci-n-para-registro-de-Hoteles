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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Mad.Funciones funciones = new Mad.Funciones();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                decimal valor;
                if (decimal.TryParse(textBox2.Text, out valor))
                {
                    textBox2.Text = valor.ToString("N2");
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos, el separador decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite solo un separador decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        
        }
    }
}
