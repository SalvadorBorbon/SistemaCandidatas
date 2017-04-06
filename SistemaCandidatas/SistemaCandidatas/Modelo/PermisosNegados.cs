using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCandidatas.Modelo
{
    [Table("PermisosNegados")]
    public class PermisosNegados
    {
        [Key]
        public int pkPermisoNegado { get; set; }
        public virtual Rol rol { get; set; }
        public virtual Permiso permiso { get; set; }
    }
}
