using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad
{
    class Listas
    {

        public class tUser
        {
            public int UsuarioID { get; set; }
            public string tipoUs { get; set; }
            public string CorreoElectronico { get; set; }
            public string Contrasena { get; set; }
            public string NombreCompleto { get; set; }
            public int NumeroNomina { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Domicilio { get; set; }
            public string TelefonoCasa { get; set; }
            public string TelefonoCelular { get; set; }
            public string Estado { get; set; }
        }

        public class Hotel
        {
            public int HotelID { get; set; }
            public string NombreHotel { get; set; }
            public string Ciudad { get; set; }
            public string Estado { get; set; }
            public string Pais { get; set; }
            public string Domicilio { get; set; }
            public int NumeroPisos { get; set; }
            public int CantidadHabitaciones { get; set; }
            public int UsuarioOperativo { get; set; }
            public DateTime FechaRegistroHotel { get; set; }
            public DateTime FechaInicioOperaciones { get; set; }
            public TimeSpan HoraRegistroHotel { get; set; }
        }

        public class DetallesHotel
        {
            public string Tipo { get; set; }
            public int CaracteristicaID { get; set; }
            public string NombreCaracteristica { get; set; }
            public string Estado { get; set; }
            public int HotelID { get; set; }
        }

        public class TiposHabitacion
        {
            public string TipoHabitacionID { get; set; }
            public decimal PrecioNochePersona { get; set; }
            public int CapacidadMaxima { get; set; }
            public int NumeroCamas { get; set; }
            public string TiposCama { get; set; }
            public int NivelHabitacion { get; set; }
            public int UsuarioOperativo { get; set; }
            public DateTime Fecha { get; set; }
            public TimeSpan Hora { get; set; }
            public string Estado { get; set; }
            public int CantidadHabitaciones { get; set; }
        }

        public class DetallesHabitacion
        {
            public string Tipo { get; set; }
            public int CaracteristicaID { get; set; }
            public string NombreCaracteristica { get; set; }
            public string Estado { get; set; }
            public string TipoHabitacionID { get; set; }
        }

        public class Habitacion
        {
            public int NumeroHabitacion { get; set; }
            public string TipoHabitacionID { get; set; }
            public string Estado { get; set; }
            public int HotelID { get; set; }
        }

        public class Reservacion
        {
            public int ReservacionID { get; set; }
            public int ClienteID { get; set; }
            public int HotelID { get; set; }
            public int HabitacionID { get; set; }
            public DateTime FechaEntrada { get; set; }
            public DateTime FechaSalida { get; set; }
            public decimal Anticipo { get; set; }
            public int UsuarioOperativo { get; set; }
            public DateTime Fecha { get; set; }
            public TimeSpan Hora { get; set; }
            public int CantidadHabitaciones { get; set; }
            public int CantidadPersonasHabitacion { get; set; }
            public string Estado { get; set; }
            public DateTime FechaReservacion { get; set; }
            public TimeSpan HoraReservacion { get; set; }
            public DateTime DuracionExtendida { get; set; }
            public bool CheckIn { get; set; }
            public bool CheckOut { get; set; }
        }

        public class ServiciosAdicionales
        {
            public int ServicioID { get; set; }
            public int ReservacionID { get; set; }
            public string NombreServicio { get; set; }
            public decimal PrecioServicio { get; set; }
        }

        public class Cancelaciones
        {
            public int CancelacionID { get; set; }
            public int ReservacionID { get; set; }
            public DateTime FechaCancelacion { get; set; }
            public TimeSpan HoraCancelacion { get; set; }
            public int UsuarioOperativo { get; set; }
        }

        public class Transacciones
        {
            public int PagoID { get; set; }
            public int ReservacionID { get; set; }
            public decimal MontoTotal { get; set; }
            public DateTime FechaPago { get; set; }
            public string MetodoPago { get; set; }
            public bool? EsReembolso { get; set; }
        }


    }
}
