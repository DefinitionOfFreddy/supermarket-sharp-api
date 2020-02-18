using supermarket.sharp.api.Domain.Models;

namespace supermarket.sharp.api.Domain.Services.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        
        public Category Category { get; set; }
        
        
        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }


        public SaveCategoryResponse(Category category) : this(true, string.Empty, category)
        {
            
        }

        public SaveCategoryResponse(string message) : this(false, message, null)
        {
            
        }
        
    }
}