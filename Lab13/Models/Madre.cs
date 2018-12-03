using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_C.Models
{
    public class Madre
    {
        public int Madre_ID { get; set; }
        public string Madre_Nombre { get; set; }
        public string Madre_Apellido { get; set; }
        public int Madre_Edad { get; set; }
        public string Madre_Sangre { get; set; }
        public string Madre_Factor { get; set; }
        public DateTime Madre_Entrada { get; set; }
        public int Madre_Examen_ID { get; set; }
    }
}