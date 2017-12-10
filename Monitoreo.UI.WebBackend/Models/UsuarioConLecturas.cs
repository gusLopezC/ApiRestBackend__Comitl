using Monitoreo.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monitoreo.UI.WebBackend.Models
{
    public class UsuarioConLecturas
    {
        private Usuario Usuario { get; set; }
        private List <Lectura> Lectura { get; set; }
        public TipoLectura Tipo { get; set; }



    }
}