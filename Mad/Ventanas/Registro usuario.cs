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

    public partial class correoRU : Form
    {
        bool sidebarExpand;
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
                int tipoUs = int.Parse(tipoUsRUCB.SelectedItem.ToString());
                string NombreCompleto = nomRU.Text + " " + matRU.Text + " " + patRU;
                int NumeroNomina = int.Parse(numNomRU.Text);
                string FechaNacimiento = fechaNacRU.Text;
                string Domicilio = calleRU.Text + " " + numExtRU + " " + colRU;
                int TelefonoCasa = int.Parse(telCasaRU.Text);
                int TelefonoCel = int.Parse(telCelRU.Text);

                if (fechaNacimiento >= fechaActual)
                {
                    validar = true;
                    MessageBox.Show("Seleccione su fecha de nacimiento.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                    List<tUser> usuarios = new List<tUser>();

                    tUser usuario = new tUser();
                    
                    var dB = new EnlaceDB();
                  //  bool insertarUser = dB.InsertUsuario(emailAddress, NombreCompleto, NumeroNomina, FechaNacimiento, Domicilio, contra, tipoUs, TelefonoCasa, TelefonoCel);


                    usuarios.Add(usuario);
                    MessageBox.Show("Todos los datos son correctos.");

                    nomRU.Text = string.Empty;
                    patRU.Text = string.Empty;
                    matRU.Text = string.Empty;
                    numNomRU.Text = string.Empty;
                    calleRU.Text = string.Empty;
                    numExtRU.Text = string.Empty;
                    colRU.Text = string.Empty;
                    telCasaRU.Text = string.Empty;
                    telCelRU.Text = string.Empty;
                    correoRU1.Text = string.Empty;
                    contraRU.Text = string.Empty;

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
            string texto3 = contraRU.Text;


            bool contieneMinuscula = texto.Any(char.IsLower);
            bool contieneMayuscula = texto2.Any(char.IsUpper);
            bool numCaracteres = false;
            bool contieneCaracterEspecial = false;

            // Verificar si el texto contiene un carácter especial
            foreach (char caracter in texto)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    contieneCaracterEspecial = true;
                    break;
                }
            }


            if (contieneCaracterEspecial)
            {
                label7.BackColor = Color.Green;
            }
            else
            {
                label7.BackColor = Color.Red;
            }

            if (contraRU.Text.Length >= 8)
            {
         
                numCaracteres= true;
            }

            if (numCaracteres)
            {
                label4.BackColor = Color.Green;
            }
            else
            {
                label4.BackColor = Color.Red;
            }

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
