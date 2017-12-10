using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitoreo.COMMON.Interfaces;
using LiteDB;
using Monitoreo.COMMON.Entidades;

namespace Monitoreo.DAL.NoSQL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDTO
    {
        //private string DBName = @"d:\DZHosts\LocalUser\comilt\Protected.MonitoreoComitl.somee.com\Monitoreo.db";
        //private string DBName = @"d:\DZHosts\LocalUser\gusLopezC\Protected.comitliteshu.somee.com\Monitoreo.db";
        private string DBName = "Monitoreo.db";
        private string TableName;

        public GenericRepository(string tableName)
        {
            TableName = tableName;
        }

        public List<T> Read
        {
            get 
            {
                //throw new NotImplementedException();
                List<T> datos;
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<T>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public T Create(T entidad)
        {
            //throw new NotImplementedException();
            entidad.ID = Guid.NewGuid().ToString();
            using (var db = new LiteDatabase(DBName))
            {
                var coleccion = db.GetCollection<T>(TableName);
                coleccion.Insert(entidad);
            }
            return entidad;

        }

        public bool Delete( string id)
        {
            //throw new NotImplementedException();
            int r;
            using (var db = new LiteDatabase(DBName))
            {
                var coleccion = db.GetCollection<T>(TableName);

                r = coleccion.Delete(e => e.ID == id);
            }
            return r > 0;

        }

        public T Update(T entidad)
        {
            //throw new NotImplementedException();
            using (var db = new LiteDatabase(DBName))
            {
                var coleccion = db.GetCollection<T>(TableName);

                coleccion.Update(entidad);
            }
            return entidad;
        }
    }
}
