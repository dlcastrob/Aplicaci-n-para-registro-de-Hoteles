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
    }
}
