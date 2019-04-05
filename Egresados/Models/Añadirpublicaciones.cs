using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class Añadirpublicaciones
    {
        [Key]
        public int AñadirpublicacionesID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }
    }
}