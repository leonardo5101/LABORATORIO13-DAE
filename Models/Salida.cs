using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_C.Models
{
    public class Salida
    {
        public int Salida_ID { get; set; }
        public string Salida_Nombre { get; set; }
        public string Salida_Destino { get; set; }
        public int Salida_Numero { get; set; }
        public string Salida_Tecnico { get; set; }
        public DateTime Salida_Hora { get; set; }
        public string Salida_Asistente { get; set; }
    }
}