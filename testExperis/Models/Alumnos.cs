using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testExperis.Models
{
    public class Alumnos
    {
        public int id { get; set; }
        [Required]
        public string documento { get; set; }
        [Required]
        public string nombres { get; set; }
        [Required]
        public string apellidos { get; set; }
        [Required]
        public DateTime fechaIngreso { get; set; }
        [Required]
        public int semestre { get; set; }
        [Required]
        public int edad { get; set; }
        public double telefonoMovil { get; set; }
        public int estado { get; set; }
        public List<Materias> Materias { get; set; }
        public List<Salones> Salones { get; set; }
        public List<Notas> Nota { get; set; }
    }
}
