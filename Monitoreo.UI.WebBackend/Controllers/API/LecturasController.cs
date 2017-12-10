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
    public class LecturasController : ApiController
    {
        IGenericRepository<Lectura> repositorio = new GenericRepository<Lectura>("Lecturas");
        // GET: api/Lecturas
        public IEnumerable<Lectura> Get()
        {
            return repositorio.Read;
        }

        // GET: api/Lecturas/5
        public Lectura Get(string id)
        {
            return repositorio.Read.Where(l => l.ID == id).SingleOrDefault();
        }

        // POST: api/Lecturas
        public Lectura Post([FromBody]Lectura value)
        {
            return repositorio.Create(value);
        }

        // PUT: api/Lecturas/5
        public Lectura Put(int id, [FromBody]Lectura value)
        {
            return repositorio.Update(value);
        }

        // DELETE: api/Lecturas/5
        public bool Delete(string id)
        {
            return repositorio.Delete(id);
        }
    }
}
