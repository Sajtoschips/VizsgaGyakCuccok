using GyakorlasSulibaWPF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakorlasSulibaWPf
{
    public class DataContext :DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=car_dealers;Uid=root;Pwd=;",
                ServerVersion.AutoDetect("Server=localhost;Database=car_dealers;Uid=root;Pwd=;"));
        }
    }
}
