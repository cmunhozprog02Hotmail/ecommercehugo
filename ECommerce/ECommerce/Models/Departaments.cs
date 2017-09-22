using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        [Display(Name = "Departamento ID")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage="O Campo Nome é requerido!")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public virtual  ICollection<City> Cities { get; set; }
    }
}