using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_C.Models;

namespace Proyecto_C.Controllers
{
    public class SalidaController : Controller
    {
        // GET: Salida
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Salida> salidas = new List<Salida>();
            salidas.Add(new Salida
            {
                Salida_ID = 1,
                Salida_Nombre = "Juan",
                Salida_Destino = "Tacna",
                Salida_Numero = 76,
                Salida_Tecnico = "Garcia",
                Salida_Hora = Convert.ToDateTime("2018-10-09"),
                Salida_Asistente = "Gomez"
            });
            salidas.Add(new Salida
            {
                Salida_ID = 2,
                Salida_Nombre = "Alberto",
                Salida_Destino = "Tacna",
                Salida_Numero = 77,
                Salida_Tecnico = "Garcia",
                Salida_Hora = Convert.ToDateTime("2018-11-09"),
                Salida_Asistente = "Andia"
            });
            salidas.Add(new Salida
            {
                Salida_ID = 3,
                Salida_Nombre = "Manuel",
                Salida_Destino = "Trujillo",
                Salida_Numero = 85,
                Salida_Tecnico = "Fox",
                Salida_Hora = Convert.ToDateTime("2018-05-09"),
                Salida_Asistente = "Martinez"
            });
            return View(salidas);
        }

        public ActionResult Editar(int id)
        {
            List<Salida> salidas = new List<Salida>();
            salidas.Add(new Salida
            {
                Salida_ID = 1,
                Salida_Nombre = "Juan",
                Salida_Destino = "Tacna",
                Salida_Numero = 76,
                Salida_Tecnico = "Garcia",
                Salida_Hora = Convert.ToDateTime("2018-10-09"),
                Salida_Asistente = "Gomez"
            });
            salidas.Add(new Salida
            {
                Salida_ID = 2,
                Salida_Nombre = "Alberto",
                Salida_Destino = "Tacna",
                Salida_Numero = 77,
                Salida_Tecnico = "Garcia",
                Salida_Hora = Convert.ToDateTime("2018-11-09"),
                Salida_Asistente = "Andia"
            });
            salidas.Add(new Salida
            {
                Salida_ID = 3,
                Salida_Nombre = "Manuel",
                Salida_Destino = "Trujillo",
                Salida_Numero = 85,
                Salida_Tecnico = "Fox",
                Salida_Hora = Convert.ToDateTime("2018-05-09"),
                Salida_Asistente = "Martinez"
            });

            Salida salida = (from p in salidas
                           where p.Salida_ID == id
                           select p).FirstOrDefault();
            return View(salida);
        }
    }
}