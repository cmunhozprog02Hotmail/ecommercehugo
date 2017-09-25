using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O Campo Nome é requerido!")]
        [MaxLength(200, ErrorMessage = "Nome até 200 catacteres")]
        [Index("Company_Name_Index", IsUnique = true)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Campo Endereço é requerido!")]
        [MaxLength(200, ErrorMessage = "Endereço até 200 catacteres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "O Campo Telefone é requerido!")]
        [MaxLength(20, ErrorMessage = "Telefone até 20 catacteres")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Logo")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        public virtual Departaments Departaments { get; set; }

        public virtual City Cities { get; set; }
    }
}