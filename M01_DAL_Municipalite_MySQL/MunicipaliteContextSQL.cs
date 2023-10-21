using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_DAL_Municipalite_MySQL
{
    public class MunicipaliteContextSQL : DbContext
    {
        public DbSet<Municipalite>? MUNICIPALITES {get; set;}

        public MunicipaliteContextSQL(DbContextOptions<MunicipaliteContextSQL> options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=.;database=municipalites;user id=sa;password=Bonjour01.+")
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
