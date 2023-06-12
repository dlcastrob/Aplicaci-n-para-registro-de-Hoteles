/*
Autor: Alejandro Villarreal

LMAD

PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, 
EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config
Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.

LOS MÉTODOS QUE SE DEFINEN EN ESTA CLASE SON EJEMPLOS, PARA QUE SE BASEN Y USTEDES HAGAN LOS SUYOS PROPIOS
Y DEFINAN Y PROGRAMEN TODOS LOS MÉTODOS QUE SEAN NECESARIOS PARA SU PROYECTO.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


/*
Se tiene que cambiar el namespace para el que usen en su proyecto
*/
namespace WindowsFormsApplication1
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			
			tal como lo vimos en clase.
			*/
            string cnn = ConfigurationManager.ConnectionStrings["Grupo03"].ToString();
            // Cambiar Grupo01 por el que ustedes hayan definido en el App.Confif
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public bool Autentificar(string us, string ps)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "SP_ValidaUser";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@u", SqlDbType.Char, 20);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@p", SqlDbType.Char, 20);
                parametro2.Value = ps;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        public DataTable BuscarClientes(string busqueda, int opcionBusqueda)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spBuscarCliente";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Busqueda", SqlDbType.VarChar, 255);
                parametro1.Value = busqueda;

                var parametro2 = _comandosql.Parameters.Add("@OpcionBusqueda", SqlDbType.Int);
                parametro2.Value = opcionBusqueda;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }


            catch (SqlException e)
            {
                string msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }


        public DataTable BuscarCiudadHotel()
        {
            DataTable dataTable = new DataTable();
            try
            {
                conectar();
                string qry = "spMostrarCiudadesConHoteles";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Crear un adaptador de datos y un DataTable para almacenar los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(_comandosql);

                adapter.Fill(dataTable);


            }


            catch (SqlException e)
            {
                string msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return dataTable;
        }

        public DataTable BuscarHotelesenCiudad(string Ciudad)
        {

            DataTable dataTable = new DataTable();
            try
            {
                conectar();
                string qry = "sp_BuscarHotelesPorCiudad";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Ciudad", SqlDbType.VarChar, 255);
                parametro1.Value = Ciudad;
                // Crear un adaptador de datos y un DataTable para almacenar los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(_comandosql);

                adapter.Fill(dataTable);


            }


            catch (SqlException e)
            {
                string msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return dataTable;
        }

        public DataTable BuscarhabReserv(DateTime fechaentrada, DateTime fechaSalida)
        {

            DataTable dataTable = new DataTable();
            try
            {
                conectar();
                string qry = "spReservacion";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                SqlParameter parametroFecha = new SqlParameter("@FechaEntrada", SqlDbType.Date);
                parametroFecha.Value = fechaentrada.Date; // Obtener la fecha sin la parte de la hora
                _comandosql.Parameters.AddWithValue("@FechaEntrada", parametroFecha);


                SqlParameter parametroFecha2 = new SqlParameter("@FechaSalida", SqlDbType.Date);
                parametroFecha2.Value = fechaSalida.Date; // Obtener la fecha sin la parte de la hora
                _comandosql.Parameters.AddWithValue("@FechaSalida", parametroFecha2);


                // Crear un adaptador de datos y un DataTable para almacenar los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(_comandosql);

                adapter.Fill(dataTable);


            }


            catch (SqlException e)
            {
                string msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return dataTable;

        }


        public bool InsertUsuario(string emailAddress, string NombreCompleto, int NumeroNomina, string FechaNacimiento, string Domicilio, string contra, int tipoUs, int TelefonoCasa, int TelefonoCel)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var paramOpcion = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                paramOpcion.Value = "I";
                var paramCorreo = _comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30);
                paramCorreo.Value = emailAddress;
                var paramNombre = _comandosql.Parameters.Add("@NombreCompleto", SqlDbType.VarChar, 50);
                paramNombre.Value = NombreCompleto;
                var numNomina = _comandosql.Parameters.Add("@#Nomina", SqlDbType.Int);
                numNomina.Value = NumeroNomina;
                var paramFechaNac = _comandosql.Parameters.Add("@FechaNacUser", SqlDbType.Date);
                paramFechaNac.Value = FechaNacimiento;
                var paramDomicilio = _comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 50);
                paramDomicilio.Value = Domicilio;
                var paramPassword = _comandosql.Parameters.Add("@PasswordActual", SqlDbType.VarChar, 30);
                paramPassword.Value = contra;
                var paramTipoUsuario = _comandosql.Parameters.Add("@TUsuario", SqlDbType.Int);
                paramTipoUsuario.Value = tipoUs;
                var paramTelefono = _comandosql.Parameters.Add("@Telefono", SqlDbType.Int);
                paramTelefono.Value = TelefonoCasa;
                var paramUsuarioRegistro = _comandosql.Parameters.Add("@ID_UsuarioRegistro", SqlDbType.Int);
                paramUsuarioRegistro.Value = TelefonoCel;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "ERROR" + e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }


        public bool InsertarCliente(string NombreCompleto, string DomicilioC, string RFC, string Correo, string EstadoCivil, string Referencia, string FechaNacCliente, string Historial, int Telefono, int RegistroUsuairo)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionClientes";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var paramOpcion = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                paramOpcion.Value = "I";
                var paramNombre = _comandosql.Parameters.Add("@NombreCompleto", SqlDbType.VarChar, 50);
                paramNombre.Value = NombreCompleto;
                var paramDomicilio = _comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 50);
                paramDomicilio.Value = DomicilioC;
                var paramRFC = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 20);
                paramRFC.Value = RFC;
                var paramCorreo = _comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30);
                paramCorreo.Value = Correo;
                var paramEstadoCivil = _comandosql.Parameters.Add("@EstadoCivil", SqlDbType.VarChar, 30);
                paramEstadoCivil.Value = EstadoCivil;
                var paramReferencia = _comandosql.Parameters.Add("@Referencia", SqlDbType.VarChar, 50);
                paramReferencia.Value = Referencia;
                var paramFechaNacCliente = _comandosql.Parameters.Add("@FechaNacCliente", SqlDbType.Date);
                paramFechaNacCliente.Value = FechaNacCliente;
                var paramHistorial = _comandosql.Parameters.Add("@Historial", SqlDbType.VarChar, 60);
                paramHistorial.Value = Historial;
                var paramTelefono = _comandosql.Parameters.Add("@Telefono", SqlDbType.Int);
                paramTelefono.Value = Telefono;
                var paramUsuarioRegistro = _comandosql.Parameters.Add("@ID_UsuarioRegistro", SqlDbType.Int);
                paramUsuarioRegistro.Value = RegistroUsuairo;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }


    }

}

