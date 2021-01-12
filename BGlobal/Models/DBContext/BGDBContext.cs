using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace BGlobal.Models.DBContext
{
    public class BGDBContext : DbContext
    {
        /// <summary>
        ///  Conection DBContext
        /// </summary>
        public BGDBContext(DbContextOptions<BGDBContext> options)
            : base(options)
        {

        }
        /// Add tables BBDD
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
