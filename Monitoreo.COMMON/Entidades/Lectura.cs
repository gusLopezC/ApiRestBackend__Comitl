using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoreo.COMMON.Entidades
{
    public class Lectura:BaseDTO
    {
        
        //public string IDDispositivo { get; set; }
        // public string IDUsuario { get; set; }
        public string IDTipoLectura { get; set; }
        public string TipoLectura { get; set; }
        public float Valor { get; set; }
        public DateTime FechaHora { get; set; }
       

    }
}
