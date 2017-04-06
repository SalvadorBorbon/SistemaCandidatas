using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SistemaCandidatas.Modelo
{
    class DataModel : DbContext
    {
        public DataModel() : base("DataModel") { }

        public DbSet<Candidata> Candidatas { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<PermisosNegados> PermisosNegados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
