using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCandidatas.Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }
        [Required(ErrorMessage = "El campo usuario es requerido")]
        [StringLength(50)]
        public string sUsuario { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(50)]
        public string sNombre { get; set; }
        [Required(ErrorMessage = "El campo contraseña es requerido")]
        [StringLength(40)]
        public string sPassword { get; set; }

        public Boolean bStatus { get; set; }

        public virtual Rol rol { get; set; }
        public ICollection<Candidata> candidata { get; set; }


        public Usuario()
        {
            this.bStatus = true;
        }

    }
}
