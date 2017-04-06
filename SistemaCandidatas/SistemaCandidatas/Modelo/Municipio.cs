using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCandidatas.Modelo
{
    [Table("Municipios")]
    public class Municipio
    {
        [Key]
        public int pkMunicipio { get; set; }
        [Required(ErrorMessage = "Se requiere el nombre del municipio")]
        [StringLength(30)]

        public string sNombre { get; set; }
        [Required(ErrorMessage = "Se requiere la descripcion")]
        [StringLength(100)]
        public string sDescripcion { get; set; }
        public string sLogo { get; set; }
        public Boolean bStatus { get; set; }

        public Municipio()
        {
            this.bStatus = true;
        }
        public ICollection<Candidata> Candidatas { get; set; }
    }
}
