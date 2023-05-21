using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Mad;
using System.Text.RegularExpressions;
namespace Mad
{
    public partial class Form1 : Form
    {
        private Funciones funciones = new Funciones();


        private Dictionary<string, string> userPasswords = new Dictionary<string, string>();
        private Dictionary<string, int> loginAttempts = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = usTB.Text;
            string password = contraTB.Text;

            if (funciones.IsValidLogin(email, password))
            {
                // Acceso exitoso, mostrar la aplicación principal
                MessageBox.Show("Inicio de sesión exitoso");
                // ...
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }

 

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string email = usTB.Text;
            string currentPassword = contraTB.Text;
            string newPassword = contraTB.Text;

            if (funciones.IsValidChangePassword(email, currentPassword, newPassword))
            {
                // Cambio de contraseña exitoso
                MessageBox.Show("Cambio de contraseña exitoso");
                // ...
            }
            else
            {
                MessageBox.Show("No se pudo cambiar la contraseña");
            }
        }

 

       
      
        private void button2_Click(object sender, EventArgs e)
        {
            Ventanas.nuevoUs nuevoUsuario = new Ventanas.nuevoUs();

            nuevoUsuario.ShowDialog();
        }
        /*
        private void PromptChangePassword(string email)
        {
            // Mostrar un cuadro de diálogo para ingresar la nueva contraseña
            string newPassword = PromptForNewPassword();

            if (!string.IsNullOrEmpty(newPassword))
            {
                // Actualizar la contraseña en el diccionario
                userPasswords[email] = newPassword;
                MessageBox.Show("Contraseña actualizada con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo establecer la nueva contraseña");
            }
        }
        
        private string PromptForNewPassword()
        {
            // Aquí puedes implementar tu propio cuadro de diálogo o formulario para que el usuario ingrese la nueva contraseña
            // Por simplicidad, aquí simplemente mostramos un cuadro de diálogo de entrada de texto
           // string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva contraseña", "Cambiar contraseña");
            Ventanas.Form2 form2= new Ventanas.Form2();

            form2.ShowDialog();
            
            // Validar la nueva contraseña antes de retornarla
            if (IsPasswordValid(newPassword))
            {
                return newPassword;
            }
            else
            {
                MessageBox.Show("La nueva contraseña no cumple los requisitos");
                return null;
            }
        }*/

    }
}