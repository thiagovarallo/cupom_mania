using System.ComponentModel.DataAnnotations;

namespace cupom_mania.Entity
{
    public class Product : BaseEntity
    {
        [Required (ErrorMessage = "Name not null")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description not null")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price not null")]
        public double Price { get; set; }
        public int Stock { get; set; }
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }

    }
}
