using MoviWed.Models;

namespace MoviWed.Repositories
{
    public interface ICategoryRepositories
    {
        Task<List<CategoryModels>> GetAllCategories();
        Task<CategoryModels> GetCategories(int id);
        Task<CategoryModels> AddCategories(CategoryModels model);
        Task<CategoryModels> UpdateCategories(CategoryModels model, int id);
        Task<CategoryModels> DeleteCategories(CategoryModels model, int id);
    }
}
