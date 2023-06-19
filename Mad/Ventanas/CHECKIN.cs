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
namespace Mad.Ventanas
{
    public partial class CHECKIN : Form
    {
        public CHECKIN()
        {
            InitializeComponent();
            var obj = new EnlaceDB();

            var tablita = new DataTable();
            tablita = obj.ObtenerIdReservacion();
            foreach (DataRow row in tablita.Rows)
            {
                string nombre = row["ReservacionID"].ToString();
                comboBox1.Items.Add(nombre);
            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = comboBox1.SelectedItem.ToString();


            var obj = new EnlaceDB();
            var tablita = new DataTable();
            tablita = obj.Mostrarhabitacion(valorSeleccionado);

            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView2.DataSource = tablita;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorSeleccionado = comboBox1.SelectedItem.ToString();
            var obj = new EnlaceDB();
            bool CambiarEstadoReservacion = obj.CambiarEstadoReservacion(valorSeleccionado);

            if (CambiarEstadoReservacion)
            {
                MessageBox.Show("Se ha realizado el check in correctamente");
           

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al realizar el check in.");
            }

        }





        //AQUI TERMINA  EL SIDE MENU
    }
}
