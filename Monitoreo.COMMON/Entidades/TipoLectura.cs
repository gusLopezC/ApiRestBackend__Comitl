using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoreo.COMMON.Entidades
{
    public class TipoLectura:BaseDTO
    {
        
        public string Nombre { get; set; }
        public string UnidadDeMedida { get; set; }
        public string TipoCerveza { get; set; }
        public string TempNec { get; set; }
        public string PresionNec { get; set; }
        public string TiempoNec { get; set; }
    }
}
