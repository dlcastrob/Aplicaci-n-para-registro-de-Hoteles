using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad
{
    public class Funciones
    {
        private const int MaxLoginAttempts = 3;
        private const int MinPasswordLength = 8;
        private const string SpecialCharacters = "¡\"#$%&/=’?¡¿:;,.-_+*{][}";

        public Dictionary<string, string> userPasswords = new Dictionary<string, string>();
        public Dictionary<string, int> loginAttempts = new Dictionary<string, int>();
        public static bool IsPasswordValid(string password)
        {
            // Verificar la longitud mínima de la contraseña
            if (password.Length < MinPasswordLength)
            {
                MessageBox.Show("La contraseña debe tener al menos " + MinPasswordLength + " caracteres.");
                return false;
            }

            // Verificar la inclusión de caracteres especiales
            if (!password.Any(c => SpecialCharacters.Contains(c)))
            {
                MessageBox.Show("La contraseña debe contener al menos un carácter especial: " + SpecialCharacters);
                return false;
            }
            return true;

        }


        public   bool IsValidLogin(string email, string password)
        {
            if (userPasswords.ContainsKey(email))
            {
                if (loginAttempts.ContainsKey(email) && loginAttempts[email] >= MaxLoginAttempts)
                {
                    MessageBox.Show("El usuario está inhabilitado. Contacte a un administrador.");
                    return false;
                }

                string storedPassword = userPasswords[email];

                if (password == storedPassword)
                {
                    // Inicio de sesión exitoso
                    loginAttempts[email] = 0; // Restablecer los intentos de inicio de sesión
                    return true;
                }
                else
                {
                    if (!loginAttempts.ContainsKey(email))
                        loginAttempts[email] = 1;
                    else
                        loginAttempts[email]++;

                    if (loginAttempts[email] >= MaxLoginAttempts)
                    {
                        MessageBox.Show("El usuario ha alcanzado el máximo número de intentos permitidos. Contacte a un administrador.");
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas. Intentos restantes: " + (MaxLoginAttempts - loginAttempts[email]));
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe. Regístrese primero.");
                return false;
            }
        }


        public  bool IsValidChangePassword(string email, string currentPassword, string newPassword)
        {

            if (userPasswords.ContainsKey(email))
            {
                string storedPassword = userPasswords[email];

                if (currentPassword == storedPassword)
                {

                    if (newPassword != currentPassword && IsPasswordValid(newPassword))
                    {
                        // Cambio de contraseña exitoso
                        userPasswords[email] = newPassword;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña no cumple los requisitos o coincide con las últimas dos contraseñas.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña actual es incorrecta.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe. Regístrese primero.");
                return false;
            }

        }

        public bool IsValidEmail(string email)
        {
            // Expresión regular para validar el formato del correo electrónico
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Verificar si el correo electrónico coincide con el patrón
            bool isValid = Regex.IsMatch(email, emailPattern);

            return isValid;
        }

        public bool AreControlsNotEmpty(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
                else if (control is MaskedTextBox maskedTextBox && string.IsNullOrWhiteSpace(maskedTextBox.Text))
                {
                    return false;
                }
                else if (control is ComboBox comboBox && (comboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBox.Text)))
                {
                    return false;
                }
                else if (control is DateTimePicker dateTimePicker && dateTimePicker.Value == dateTimePicker.MinDate)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
