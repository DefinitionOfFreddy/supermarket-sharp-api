using System.ComponentModel.DataAnnotations;

namespace supermarket.sharp.api.Resources
{
    public class SaveCategoryRessource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}