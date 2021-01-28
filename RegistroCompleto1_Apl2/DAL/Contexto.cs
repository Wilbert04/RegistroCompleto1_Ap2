using Microsoft.EntityFrameworkCore;
using RegistroCompleto1_Apl2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCompleto1_Apl2.DAL
{
    public class Contexto : DbContext
    {


        public DbSet<Estudiantes> Estudiantes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        
        }

  
    }
}
