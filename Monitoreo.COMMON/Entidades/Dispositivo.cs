using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoreo.COMMON.Entidades
{
    public class Dispositivo:BaseDTO
    {
        
        public string IDUsuario { get; set; }
        public string lote { get; set; }
        public string LugarCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaVenCad { get; set; }

    }
}
