using System.Data.Entity;

namespace ECommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {


        }
    }
}