using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad
{
    class FechaActual
    {
        public static DateTime Fecha { get; set; }

        public static void ObtenerFechaActual()
        {
            Fecha = DateTime.Now;
        }
    }
}
