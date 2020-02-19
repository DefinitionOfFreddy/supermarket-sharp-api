using System.ComponentModel.DataAnnotations;

namespace supermarket.sharp.api.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}