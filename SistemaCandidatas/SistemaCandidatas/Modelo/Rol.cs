using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCandidatas.Modelo
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int pkRoles { get; set; }
        [Required(ErrorMessage = "El nombre del rol es requerido")]
        [StringLength(20)]
        public string sNombre { get; set; }
        [Required(ErrorMessage = "La descripcion del rol es requerida")]
        [StringLength(100)]
        public string sDescripcion { get; set; }
        public Boolean bStatus { get; set; }

        public Rol()
        {
            this.bStatus = true;
        }

        public ICollection<Usuario> Usuarios {get;set;}
    }
}
