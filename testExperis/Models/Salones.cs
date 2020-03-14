using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testExperis.Models
{
    public class Salones
    {
        public int id { get; set; }
        public string sede { get; set; }
        public string letra { get; set; }
        public int numero { get; set; }
        public int estado { get; set; }
        public Alumnos Alumnos { get; set; }
        
    }
}
