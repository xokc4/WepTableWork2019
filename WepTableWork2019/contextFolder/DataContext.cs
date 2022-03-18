using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepTableWork2019.contextFolder
{
    public class DataContext: DbContext
    {
        public DbSet<Peoples.People> people { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("server=DESKTOP-G4B9IB0;DataBase=PeoplesWebBasa;Trusted_Connection = True;");
        }
    }
}
