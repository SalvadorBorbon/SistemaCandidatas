using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaCandidatas.Modelo
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }
        [Required(ErrorMessage = "El nombre del permiso es requerido")]
        [StringLength(25)]
        public string sNombre { get; set; }
        [Required(ErrorMessage = "La descripcion del permiso es requerido")]
        [StringLength(100)]
        public string sDescripcion { get; set; }

        public ICollection<PermisosNegados> PermisosNegados { get; set; }
    }
}
