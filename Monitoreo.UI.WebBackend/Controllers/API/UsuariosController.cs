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
    public class UsuariosController : ApiController
    {
        IGenericRepository<Usuario> repositorio = new GenericRepository<Usuario>("Usuarios");
        // GET: api/Usuarios
        public IEnumerable<Usuario> Get()
        {
            return repositorio.Read.OrderBy(u=>u.Apellidos);
        }

        // GET: api/Usuarios/5
        public Usuario Get(string id)
        {
            return repositorio.Read.Where(l => l.ID == id).SingleOrDefault();
        }

        // POST: api/Usuarios
        public Usuario Post([FromBody]Usuario value)
        {
            value.ID = Guid.NewGuid().ToString();
            return repositorio.Create(value);
        }

        // PUT: api/Usuarios/5
        public Usuario Put(string id, [FromBody]Usuario value)
        {
            return repositorio.Update(value);
        }

        // DELETE: api/Usuarios/5
        public bool Delete(string id)
        {
            return repositorio.Delete(id);
        }
    }
}
