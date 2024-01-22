
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set;}
        
    }
}