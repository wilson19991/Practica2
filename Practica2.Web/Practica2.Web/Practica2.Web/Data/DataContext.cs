using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Ciudad> Ciudad { get; set; }

        public DbSet<Curso> Curso { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
