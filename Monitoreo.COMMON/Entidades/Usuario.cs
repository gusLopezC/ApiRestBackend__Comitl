using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoreo.COMMON.Entidades
{
    public class Usuario:BaseDTO
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string direccion { get; set; }
        public string poblacion { get; set; }
        public string telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}
