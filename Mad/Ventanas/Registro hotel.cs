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
        bool sidebarExpand;
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
            Servicios form1 = new Servicios();

            // Establecer el formulario como control hijo del TabPage
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            tabPage4.Controls.Add(form1);

            // Mostrar el formulario
            form1.Show();

        }

        //AQUI EMPIEZA EL SIDE MENU

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



        //AQUI TERMINA  EL SIDE MENU
    }
}
