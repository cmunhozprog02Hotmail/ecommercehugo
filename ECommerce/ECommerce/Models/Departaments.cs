using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        [Display(Name = "Departamento ID")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage="O Campo Nome é requerido!")]
        [Index("Departaments_Name_Index", IsUnique = true)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public virtual  ICollection<City> Cities { get; set; }

        public virtual ICollection<Company> Company { get; set; }
    }
}