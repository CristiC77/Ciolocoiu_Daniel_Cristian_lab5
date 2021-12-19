using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciolocoiu_Daniel_Cristian_lab5.Models;

namespace Ciolocoiu_Daniel_Cristian_lab5.Data
{
    public class Ciolocoiu_Daniel_Cristian_lab5Context : DbContext
    {
        public Ciolocoiu_Daniel_Cristian_lab5Context (DbContextOptions<Ciolocoiu_Daniel_Cristian_lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Ciolocoiu_Daniel_Cristian_lab5.Models.Book> Book { get; set; }

        public DbSet<Ciolocoiu_Daniel_Cristian_lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Ciolocoiu_Daniel_Cristian_lab5.Models.Category> Category { get; set; }
    }
}
