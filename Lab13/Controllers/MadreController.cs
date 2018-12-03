using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_C.Models;

namespace Proyecto_C.Controllers
{
    public class MadreController : Controller
    {
        // GET: Madre
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Madre> madres = new List<Madre>();
            madres.Add(new Madre
            {
                Madre_ID = 1,
                Madre_Nombre = "Roxana",
                Madre_Apellido = "Condori",
                Madre_Edad = 35,
                Madre_Sangre = "A",
                Madre_Factor = "No",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 1
            });
            madres.Add(new Madre
            {
                Madre_ID = 2,
                Madre_Nombre = "Tammy",
                Madre_Apellido = "Gutierrez",
                Madre_Edad = 41,
                Madre_Sangre = "AB",
                Madre_Factor = "No",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 2
            });
            madres.Add(new Madre
            {
                Madre_ID = 3,
                Madre_Nombre = "Diana",
                Madre_Apellido = "Sosa",
                Madre_Edad = 39,
                Madre_Sangre = "O+",
                Madre_Factor = "Si",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 3
            });
            madres.Add(new Madre
            {
                Madre_ID = 4,
                Madre_Nombre = "Roshan",
                Madre_Apellido = "Palo",
                Madre_Edad = 38,
                Madre_Sangre = "O-",
                Madre_Factor = "No",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 4
            });
            return View(madres);
        }
        public ActionResult Editar(int id)
        {
            List<Madre> madres = new List<Madre>();
            madres.Add(new Madre
            {
                Madre_ID = 1,
                Madre_Nombre = "Roxana",
                Madre_Apellido = "Condori",
                Madre_Edad = 35,
                Madre_Sangre = "A",
                Madre_Factor = "No",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 1
            });
            madres.Add(new Madre
            {
                Madre_ID = 2,
                Madre_Nombre = "Tammy",
                Madre_Apellido = "Gutierrez",
                Madre_Edad = 41,
                Madre_Sangre = "AB",
                Madre_Factor = "No",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 2
            });
            madres.Add(new Madre
            {
                Madre_ID = 3,
                Madre_Nombre = "Diana",
                Madre_Apellido = "Sosa",
                Madre_Edad = 39,
                Madre_Sangre = "O+",
                Madre_Factor = "Si",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 3
            });
            madres.Add(new Madre
            {
                Madre_ID = 4,
                Madre_Nombre = "Roshan",
                Madre_Apellido = "Palo",
                Madre_Edad = 38,
                Madre_Sangre = "O-",
                Madre_Factor = "No",
                Madre_Entrada = Convert.ToDateTime("2018-11-09"),
                Madre_Examen_ID = 4
            });

            Madre madre = (from p in madres
                               where p.Madre_ID == id
                               select p).FirstOrDefault();
            return View(madre);
        }
    }
}