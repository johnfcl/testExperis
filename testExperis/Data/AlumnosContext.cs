using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testExperis.Models;

namespace testExperis.Data
{
    public class AlumnosContext : DbContext
    {
        public AlumnosContext(DbContextOptions<AlumnosContext> options)
            : base(options)
        {

        }

        public DbSet<Alumnos> alumnos { get; set; }
        public DbSet<Materias> materias { get; set; }
        public DbSet<Salones> salones { get; set; }
        public DbSet<Notas> notas { get; set; }

    }
}
