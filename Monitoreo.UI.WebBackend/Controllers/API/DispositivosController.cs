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
    public class DispositivosController : ApiController
    {
        IGenericRepository<Dispositivo> repositorio = new GenericRepository<Dispositivo>("Dispositivos");
        // GET: api/Dispositivos
        public IEnumerable<Dispositivo> Get()
        {
            return repositorio.Read;
        }

        // GET: api/Dispositivos/5
        public Dispositivo Get(string id)
        {
            return repositorio.Read.Where(l => l.ID == id).SingleOrDefault();
        }

        // POST: api/Dispositivos
        public Dispositivo Post([FromBody]Dispositivo value)
        {
            value.ID = Guid.NewGuid().ToString();
            return repositorio.Create(value);
        }

        // PUT: api/Dispositivos/5
        public Dispositivo Put(int id, [FromBody]Dispositivo value)
        {
            return repositorio.Update(value);
        }

        // DELETE: api/Dispositivos/5
        public bool Delete(string id)
        {
            return repositorio.Delete(id);
        }
    }
}
