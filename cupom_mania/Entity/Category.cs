using System.ComponentModel.DataAnnotations;

namespace cupom_mania.Entity
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Name not null")]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
