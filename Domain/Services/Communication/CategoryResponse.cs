using supermarket.sharp.api.Domain.Models;

namespace supermarket.sharp.api.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse
    {
        
        public Category Category { get; set; }
        
        
        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }


        public CategoryResponse(Category category) : this(true, string.Empty, category)
        {
            
        }

        public CategoryResponse(string message) : this(false, message, null)
        {
            
        }
        
    }
}