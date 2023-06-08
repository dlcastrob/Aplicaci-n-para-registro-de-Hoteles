using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Mad.Ventanas
{
    public partial class Form1 : Form
    {
        public object fechaInicioDTP { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void tabControl1_Click(object sender, EventArgs e)
        {
            TiposHabitacion form1 = new TiposHabitacion();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(form1);
            form1.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            Caracteristicas form1 = new Caracteristicas();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(form1);
            form1.Show();

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            Amenidades form1 = new Amenidades();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(form1);
            form1.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       

        private void tabControl1_Selecting_1(object sender, TabControlCancelEventArgs e)
        {

        }

    

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario que deseas mostrar
            TiposHabitacion form1 = new TiposHabitacion();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(form1);

            // Mostrar el formulario
            form1.Show();
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario que deseas mostrar
            Caracteristicas form1 = new Caracteristicas();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage2.Controls.Add(form1);

            // Mostrar el formulario
            form1.Show();

        }
        private void tabPage3_Click_1(object sender, EventArgs e)
        {
            Amenidades form1 = new Amenidades();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage3.Controls.Add(form1);

            // Mostrar el formulario
            form1.Show();
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            Servicios_adicionales form1 = new Servicios_adicionales();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage4.Controls.Add(form1);

            // Mostrar el formulario
            form1.Show();

        }
    }
}
