using Friends_Console;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FriendsWPF
{
    public class DataContext : DbContext
    {
        public DbSet<Episode> episodes { get; set; }
        public DbSet<Season> seasons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=friends;Uid=root;Pwd=;",
                ServerVersion.AutoDetect("Server=localhost;Database=friends;Uid=root;Pwd=;"));
        }
    }
}
