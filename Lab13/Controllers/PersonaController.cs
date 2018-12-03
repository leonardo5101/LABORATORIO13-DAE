using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_C.Models;

namespace Proyecto_C.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
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
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                Persona_ID = 1,
                Persona_Nombre = "Bill",
                Persona_Apellido = "Condori",
                Persona_Email = "bill.johnn@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1999-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "bill.johnn",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            personas.Add(new Persona
            {
                Persona_ID = 2,
                Persona_Nombre = "Alberto",
                Persona_Apellido = "Gutierrez",
                Persona_Email = "jesus.gutierrez.c@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1999-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "alberto.gutierrez",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            personas.Add(new Persona
            {
                Persona_ID = 3,
                Persona_Nombre = "Joshua",
                Persona_Apellido = "Sosa",
                Persona_Email = "joshua.sosa@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1999-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "joshua.sosa",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            personas.Add(new Persona
            {
                Persona_ID = 4,
                Persona_Nombre = "Jesus",
                Persona_Apellido = "Palo",
                Persona_Email = "jesus.palo@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1996-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "jesus.palo",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            return View(personas);
        }
        public ActionResult Editar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                Persona_ID = 1,
                Persona_Nombre = "Bill",
                Persona_Apellido = "Condori",
                Persona_Email = "bill.johnn@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1999-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "bill.johnn",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            personas.Add(new Persona
            {
                Persona_ID = 2,
                Persona_Nombre = "Alberto",
                Persona_Apellido = "Gutierrez",
                Persona_Email = "jesus.gutierrez.c@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1999-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "alberto.gutierrez",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            personas.Add(new Persona
            {
                Persona_ID = 3,
                Persona_Nombre = "Joshua",
                Persona_Apellido = "Sosa",
                Persona_Email = "joshua.sosa@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1999-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "joshua.sosa",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });
            personas.Add(new Persona
            {
                Persona_ID = 4,
                Persona_Nombre = "Jesus",
                Persona_Apellido = "Palo",
                Persona_Email = "jesus.palo@tecsup.edu.pe",
                Persona_FecNac = Convert.ToDateTime("1996-02-28"),
                Persona_Sexo = "M",
                Persona_Celular = "999888666",
                Persona_Username = "jesus.palo",
                Persona_Password = "root",
                Persona_Tipo_ID = 1
            });

            Persona persona = (from p in personas
                               where p.Persona_ID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
    }
}