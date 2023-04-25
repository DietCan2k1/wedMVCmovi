using Microsoft.EntityFrameworkCore;
using MoviWed.Database;
using MoviWed.Models;

namespace MoviWed.Repositories
{
    public class CategoryRepositories : ICategoryRepositories
    {
        private readonly DatabaseContext _context;

        public CategoryRepositories(DatabaseContext context) 
        {
            _context = context;
        }
        public async Task<CategoryModels> AddCategories(CategoryModels model)
        {
             _context.Add(model);
            await _context.SaveChangesAsync();
            return model;

        }

        public async Task<CategoryModels> DeleteCategories(CategoryModels model, int id)
        {
            var category = await _context.category.SingleOrDefaultAsync(x => x.Id == id);

            _context.category.Remove(category); 

            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<List<CategoryModels>> GetAllCategories()
        {
            return await _context.category.ToListAsync();
        }

        public async Task<CategoryModels> GetCategories(int id)
        {
            var category = await _context.category.SingleOrDefaultAsync(x => x.Id == id);
       
            return category;
        }

        public async Task<CategoryModels> UpdateCategories(CategoryModels model, int id)
        {
           if(id == model.Id)
            {
                var category = model;
                 _context.category.Update(category);
                await _context.SaveChangesAsync();
            }
           return model;

        }
    }
}
