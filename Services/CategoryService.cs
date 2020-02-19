using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Repositories;
using supermarket.sharp.api.Domain.Services;
using supermarket.sharp.api.Domain.Services.Communication;

namespace supermarket.sharp.api.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IEnumerable<Category>> ListAsync()
        {
            IEnumerable<Category> categories = await _categoryRepository.ListAsync();
            return categories;
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);
            }
            catch (Exception e)
            {
                return new SaveCategoryResponse("Error when saving the category : {e.Message}");
            }
        }

        public async Task<SaveCategoryResponse> UpdateAsync(int id, Category category)
        {
            
            Category existingCategory = await _categoryRepository.FindByIdAsync(id);
                
            if (existingCategory == null)
                return new SaveCategoryResponse("Category Not Found");


            existingCategory.Name = category.Name;
            
            try
            {
                _categoryRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();
                
                return new SaveCategoryResponse(existingCategory);

            }
            catch (Exception e)
            {
                return new SaveCategoryResponse("Error when updating the category : {e.Message}");
            }
        }
    }
}