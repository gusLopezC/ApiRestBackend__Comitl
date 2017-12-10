using Monitoreo.COMMON.Entidades;
using Monitoreo.COMMON.Interfaces;
using Monitoreo.DAL.NoSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monitoreo.UI.WebBackend.Controllers.API
{
    public class TipoLecturasController : ApiController
    {
        // GET: api/TipoLecturas
        IGenericRepository<TipoLectura> repositorio = new GenericRepository<TipoLectura>("Tipo Lecturas");
        // GET: api/TipoLecturas
        public IEnumerable<TipoLectura> Get()
        {
            return repositorio.Read;
        }

        // GET: api/TipoLecturas/5
        public TipoLectura Get(string id)
        {
            return repositorio.Read.Where(l => l.ID == id).SingleOrDefault();
        }

        // POST: api/TipoLecturas
        public TipoLectura Post([FromBody]TipoLectura value)
        {
            value.ID = Guid.NewGuid().ToString();
            return repositorio.Create(value);

        }

        // PUT: api/TipoLecturas/5
        public TipoLectura Put(int id, [FromBody]TipoLectura value)
        {
            return repositorio.Update(value);
        }

        // DELETE: api/TipoLecturas/5
        public void Delete(int id)
        {
        }
    }
}
