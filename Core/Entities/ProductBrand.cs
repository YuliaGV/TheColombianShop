

using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ProductBrand
    {
        [Key]
        public int Id { get; set; }
         public string Name { get; set;}
    }
}