using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanosvenyek_GUI.Models;

namespace Tanosvenyek_GUI
{
    class TanosvenyContext : DbContext
    {
        public DbSet<Utvonal> Ut { get; set; }
        public DbSet<Telepules> Telepules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=tanosveny;Uid=root;Pwd=;", ServerVersion.AutoDetect("Server=localhost;Database=tanosveny;Uid=root;Pwd=;"));
        }

    }
}
