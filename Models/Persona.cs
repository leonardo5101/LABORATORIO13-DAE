using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_C.Models
{
    public class Persona
    {
        public int Persona_ID { get; set; }
        public string Persona_Nombre { get; set; }
        public string Persona_Apellido { get; set; }
        public string Persona_Email { get; set; }
        public DateTime Persona_FecNac { get; set; }
        public string Persona_Sexo { get; set; }
        public string Persona_Celular { get; set; }
        public string Persona_Username { get; set; }
        public string Persona_Password { get; set; }
        public int Persona_Tipo_ID { get; set; }
    }
}