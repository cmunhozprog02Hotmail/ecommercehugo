using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O Campo Nome é requerido!")]
        public string Name { get; set; }

        public int DepartamentsId { get; set; }
    }
}