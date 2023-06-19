using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1;



namespace Mad.Ventanas
{
    public partial class RepOcupacionHoteñ : Form
    {
        bool sidebarExpand;
        public RepOcupacionHoteñ()
        {
            InitializeComponent();
            var obj = new EnlaceDB();

            var tablita = new DataTable();
            tablita = obj.VistaHoteles();
            foreach (DataRow row in tablita.Rows)
            {
                string nombre = row["NombreHotel"].ToString();
                comboBox2.Items.Add(nombre);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void RepOcupacionHoteñ_Load(object sender, EventArgs e)
        {

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tablita = new DataTable();
            var tablita2 = new DataTable();

            tablita = obj.spReporteOcupacion(null, comboBox1.Text, null);
            tablita2 = obj.spReporteOcupacionSimple(null,comboBox1.Text, null);


            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView1.DataSource = tablita;
            dataGridView2.DataSource = tablita2;


        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tablita = new DataTable();
            var tablita2 = new DataTable();

            tablita = obj.spReporteOcupacion(null, null, comboBox4.Text);
            tablita2 = obj.spReporteOcupacionSimple(null,null, comboBox4.Text);


            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView1.DataSource = tablita;
            dataGridView2.DataSource = tablita2;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tablita = new DataTable();
            var tablita2 = new DataTable();

            tablita = obj.spReporteOcupacion(comboBox2.Text.ToString(), null, null);
            tablita2 = obj.spReporteOcupacionSimple(comboBox2.Text.ToString(), null, null);


            // Mostrar los resultados en un DataGridView u otro control adecuado
            dataGridView1.DataSource = tablita;
            dataGridView2.DataSource = tablita2;
        
    }



        //AQUI TERMINA  EL SIDE MENU
    }
}
