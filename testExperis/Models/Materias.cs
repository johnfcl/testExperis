using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testExperis.Models
{
    public class Materias
    {
        public int id { get; set; }
        public string nombreMateria { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public Alumnos Alumnos { get; set; }

    }
}
