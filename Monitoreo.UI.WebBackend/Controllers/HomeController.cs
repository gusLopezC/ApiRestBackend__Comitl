using Monitoreo.COMMON.Interfaces;
using Monitoreo.COMMON.Entidades;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Monitoreo.DAL.NoSQL;
using System;

namespace Monitoreo.UI.WebBackend.Controllers
{
   // public Random r = new Random();
    public class HomeController : Controller
    {
        
        IGenericRepository<Usuario> usuariosRepositorio;
        IGenericRepository<Lectura> lecturasRepositorio;
        private Random r = new Random();

        public HomeController()
        {
            usuariosRepositorio = new GenericRepository<Usuario>("Usuarios");
            lecturasRepositorio = new GenericRepository<Lectura>("Lecturas");
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult validaLogin(string txtEmail,string txtPassword)
        {
            Usuario usuario = usuariosRepositorio.Read.Where(u => u.Email == txtEmail && u.Password == txtPassword).SingleOrDefault();
            if (usuario == null)
            {
                ViewBag.mensaje = "Usuario no exisite";
                return View("Login");
            }
            else
            {
                Session["usuario"] = usuario;
                return View("Index");
            }
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Compra()
        {
            float v = r.Next(25,40);
            //usuariosRepositorio.Create(new Usuario()
            //{
            //    Apellidos = "lopez",
            //    Email = "hola@hola.com",
            //    Nombre = "gus",
            //    Password = "1234g"

            //});
            lecturasRepositorio.Create(new Lectura() {

                TipoLectura = "temperatura",
                Valor = v,
                FechaHora = DateTime.Now
            });
            List<Lectura> lectura = lecturasRepositorio.Read;

            return View(lectura);
        }
    }
}