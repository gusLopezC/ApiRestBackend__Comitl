using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoreo.COMMON.Entidades
{
    public abstract class BaseDTO : IDisposable // Clase AbstractA es aquella que no se puede instanciar. los : significa herencia
    {
        public string ID { get; set; }
        private bool isDisposable;
        public void Dispose()
        {
            if(!isDisposable)
            {
                isDisposable = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}
