using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testExperis.Models
{
    public class Notas
    {
        public int id { get; set; }
        [Required]
        public int nota { get; set; }
        public double documento { get; set; }
        public int estado { get; set; }
        public Alumnos Alumnos { get; set; }
    }
}
