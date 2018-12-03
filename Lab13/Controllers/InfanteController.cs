using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_C.Models;

namespace Proyecto_C.Controllers
{
    public class InfanteController : Controller
    {
        // GET: Infante
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Listar()
        {
            List<Infante> infantes = new List<Infante>();
            infantes.Add(new Infante
            {
                Infante_ID = 1,
                Infante_Nombre = "Jorge",
                Infante_Apellido = "Gonzáles",
                Infante_Lugar = "Arequipa",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 2,
                Infante_Nombre = "Freddy",
                Infante_Apellido = "Mercury",
                Infante_Lugar = "Lima",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 3,
                Infante_Nombre = "Enrique",
                Infante_Apellido = "Bumbury",
                Infante_Lugar = "Huancayo",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 4,
                Infante_Nombre = "Jhonn",
                Infante_Apellido = "Lennon",
                Infante_Lugar = "Iquitos",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 5,
                Infante_Nombre = "Bob",
                Infante_Apellido = "Marley",
                Infante_Lugar = "El callao",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 3,
                Infante_Examen_Fis = 5
            });
            infantes.Add(new Infante
            {
                Infante_ID = 6,
                Infante_Nombre = "Albert",
                Infante_Apellido = "Einstein",
                Infante_Lugar = "Pucallpa",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 2,
                Infante_Examen_Fis = 4
            });
            infantes.Add(new Infante
            {
                Infante_ID = 7,
                Infante_Nombre = "Nicola",
                Infante_Apellido = "Tesla",
                Infante_Lugar = "San Juan de Lurigancho",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            return View(infantes);
        }
        public ActionResult Editar(int id)
        {
            List<Infante> infantes = new List<Infante>();

            infantes.Add(new Infante
            {
                Infante_ID = 1,
                Infante_Nombre = "Jorge",
                Infante_Apellido = "Gonzáles",
                Infante_Lugar = "Arequipa",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 2,
                Infante_Nombre = "Freddy",
                Infante_Apellido = "Mercury",
                Infante_Lugar = "Lima",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 3,
                Infante_Nombre = "Enrique",
                Infante_Apellido = "Bumbury",
                Infante_Lugar = "Huancayo",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 2
            });
            infantes.Add(new Infante
            {
                Infante_ID = 4,
                Infante_Nombre = "Jhonn",
                Infante_Apellido = "Lennon",
                Infante_Lugar = "Iquitos",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 3,
                Infante_Examen_Fis = 1
            });
            infantes.Add(new Infante
            {
                Infante_ID = 5,
                Infante_Nombre = "Bob",
                Infante_Apellido = "Marley",
                Infante_Lugar = "El callao",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 3,
                Infante_Examen_Fis = 5
            });
            infantes.Add(new Infante
            {
                Infante_ID = 6,
                Infante_Nombre = "Albert",
                Infante_Apellido = "Einstein",
                Infante_Lugar = "Pucallpa",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 2,
                Infante_Examen_Fis = 4
            });
            infantes.Add(new Infante
            {
                Infante_ID = 7,
                Infante_Nombre = "Nicola",
                Infante_Apellido = "Tesla",
                Infante_Lugar = "San Juan de Lurigancho",
                Infante_Hora = DateTime.Now,
                Infante_Sexo = "M",
                Infante_Examen_Gen = 1,
                Infante_Examen_Fis = 1
            });

            Infante persona = (from p in infantes
                               where p.Infante_ID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
    }
}