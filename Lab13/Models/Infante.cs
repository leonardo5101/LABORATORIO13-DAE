using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_C.Models
{
    public class Infante
    {
        public int Infante_ID { get; set; }
        public string Infante_Nombre { get; set; }
        public string Infante_Apellido { get; set; }
        public string Infante_Lugar { get; set; }
        public DateTime Infante_Hora { get; set; }
        public string Infante_Sexo { get; set; }
        public int Infante_Examen_Gen { get; set; }
        public int Infante_Examen_Fis { get; set; }
    }
}