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

namespace Mad.Ventanas
{
    public partial class RepOcupacionHoteñ : Form
    {
        bool sidebarExpand;
        public RepOcupacionHoteñ()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros seleccionados
            string pais = textBox4.Text;
            int año = Convert.ToInt32(textBox3.Text);
            string ciudad = textBox1.Text;
            string nombreHotel = textBox2.Text;

            // Establecer la cadena de conexión a tu base de datos
            string cadenaConexion = ConfigurationManager.ConnectionStrings["Grupo03"].ToString();

            // Crear una DataTable para almacenar los resultados de la consulta
            DataTable dtResultados = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["Grupo03"].ToString();
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) { }

                    connectionString.Open();

                // Crear un SqlCommand para ejecutar el stored procedure
                using (SqlCommand comando = new SqlCommand("ObtenerReporteOcupacion", cadenaConexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Asignar los valores de los parámetros en el stored procedure
                    comando.Parameters.AddWithValue("@Pais", pais);
                    comando.Parameters.AddWithValue("@Año", año);
                    comando.Parameters.AddWithValue("@Ciudad", ciudad);
                    comando.Parameters.AddWithValue("@NombreHotel", nombreHotel);

                    // Crear un SqlDataAdapter para llenar el DataTable con los resultados de la consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        // Llenar el DataTable con los resultados de la consulta
                        adapter.Fill(dtResultados);
                    }
                }
            }

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = dtResultados;
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



        //AQUI TERMINA  EL SIDE MENU
    }
}
