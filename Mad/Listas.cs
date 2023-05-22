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
            
            public string idUs { get; set; }

            public string tipoUs { get; set; }
            public string correoElectronico { get; set; }
            public string contrasena { get; set; }
            public string nombreCompleto { get; set; }
            public string numeroNomina { get; set; }
            public string fechaNacimiento { get; set; }
            public string domicilio { get; set; }
            public string telefonoCasa { get; set; }
            public string telefonoCelular { get; set; }
            public string estado { get; set; }
        }

        public class Cliente
        {
            public int idCliente { get; set; }
            public string nombreCompleto { get; set; }
            public string domicilioCompleto { get; set; }
            public string rfc { get; set; }
            public string correoElectronico { get; set; }
            public string telefonoCasa { get; set; }
            public string telefonoCelular { get; set; }
            public string referenciaHotel { get; set; }
            public string fechaNacimiento { get; set; }
            public string estadoCivil { get; set; }
            public DateTime fecha { get; set; }
            public TimeSpan hora { get; set; }
            public string usuarioOperativo { get; set; }
            public string estado { get; set; }
        }

    }
}
