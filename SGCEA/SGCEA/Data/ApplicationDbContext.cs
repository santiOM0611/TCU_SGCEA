using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SGCEA.Models;

namespace SGCEA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AdultoMayor> AdultosMayores { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<ParticipacionActividad> ParticipacionesActividades { get; set; }
    }
}