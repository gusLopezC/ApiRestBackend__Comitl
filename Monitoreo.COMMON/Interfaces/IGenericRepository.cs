using Monitoreo.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoreo.COMMON.Interfaces
{
    public interface IGenericRepository<T> where T : BaseDTO //T hereda una clase
    {
        T Create(T entidad);

        List<T> Read { get; }

        T Update(T entidad);

        bool Delete(string id);

    }
}
