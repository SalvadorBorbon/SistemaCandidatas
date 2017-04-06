using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCandidatas.Modelo
{
    [Table("Candidatas")]
    public class Candidata
    {
        [Key]
        public int pkCandidata { get; set; }
        [Required(ErrorMessage = "El campo año de convocatoria es requerido")]
        public int sAnioConvocatoria { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(50)]
        public string sNombre { get; set; }
        [Required(ErrorMessage = "El campo fecha de nacimiento es requerido")]
        public DateTime fNacimiento { get; set; }
        [Required(ErrorMessage = "El campo descripcion es requerido")]
        [StringLength(100)]
        public string sDescripcion { get; set; }
        [Required(ErrorMessage = "El campo Email es requerido")]
        [StringLength(50)]
        public string sEmail { get; set; }
        [Required(ErrorMessage = "El campo CURP es requerido")]
        [StringLength(18)]
        public string sCurp { get; set; }
        [Required(ErrorMessage = "El campo estudios es requerido")]
        [StringLength(20)]
        public string sEstudios { get; set; }
        public string sFoto { get; set; }
        public bool bStatus { get; set; }
        public int iLike { get; set; }
        public virtual Municipio fkMunicipio { get; set; }


        public Candidata()
        {
            this.bStatus = true;
        }
    }
}
