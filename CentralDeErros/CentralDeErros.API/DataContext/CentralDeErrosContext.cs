using CentralDeErros.API.Models;
using CentralDeErros.API.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeErros.API.DataContext
{
    public class CentralDeErrosContext : DbContext
    {
        public DbSet<Occurrence> Occurrences { get; set; }
        public DbSet<Microsservice> Microsservices { get; set; }

        public CentralDeErrosContext(DbContextOptions<CentralDeErrosContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OccurrenceMap());
            modelBuilder.ApplyConfiguration(new MicrosserviceMap());
        }

    }
}
