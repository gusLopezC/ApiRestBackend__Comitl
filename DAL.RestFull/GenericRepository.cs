using Monitoreo.COMMON.Entidades;
using Monitoreo.COMMON.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RestFull
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDTO
    {
        private HttpClient _cliente;
        private string _uriApi;

        public List<T> Read => ObtenerDatos().Result;

        public GenericRepository(string uriApi)
        {
            _uriApi = uriApi;
            _cliente = new HttpClient();
            _cliente.BaseAddress = new Uri("http://www.comitliteshu.somee.com");
            _cliente.DefaultRequestHeaders.Clear();
            _cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _cliente.MaxResponseContentBufferSize = 256000;
        }


        private async Task<List<T>> ObtenerDatos()
        {
            HttpResponseMessage response = await _cliente.GetAsync(_uriApi).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var items = JsonConvert.DeserializeObject<List<T>>(content);
                return items;
            }
            else
            {
                return null;
            }
        }

        public T Create(T entidad) => Guardar(entidad).Result;

        private async Task<T> Guardar(T entidad)
        {
            var json = JsonConvert.SerializeObject(entidad);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await _cliente.PostAsync(_uriApi, content).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var item = JsonConvert.DeserializeObject<T>(respuesta);
                return item;
            }
            else
            {
                return null;
            }
        }


        public bool Delete(T entidad) => Eliminar(entidad).Result;

        private async Task<bool> Eliminar(T entidad)
        {
            var json = JsonConvert.SerializeObject(entidad);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await _cliente.DeleteAsync(string.Format("{0}{1}", _uriApi, entidad.ID)).ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public T Update(T entidad) => Editar(entidad).Result;
        private async Task<T> Editar(T entidad)
        {
            var json = JsonConvert.SerializeObject(entidad);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await _cliente.PutAsync(_uriApi + entidad.ID, content).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var item = JsonConvert.DeserializeObject<T>(respuesta);
                return item;
            }
            else
            {
                return null;
            }
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}