using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace supermarket.sharp.api.Domain.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]        
        public short QuantityInPackage { get; set; }
        [Required]
        public EUnitOfMesurement UnitOfMesurement { get; set; }
        
        public Category Category { get; set; }
        
    }
        
    
}