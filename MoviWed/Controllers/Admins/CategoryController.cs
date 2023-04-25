using Microsoft.AspNetCore.Mvc;
using MoviWed.Models;
using MoviWed.Repositories;

namespace MoviWed.Controllers.Admins
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepositories _categoryRepos;

        public CategoryController(ICategoryRepositories categoryRepositories)
        {
            _categoryRepos = categoryRepositories;
        }

        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                await _categoryRepos.GetAllCategories();
            } catch (Exception ex)
            {
                return NotFound();
            }

            return View();
        }

        public async Task<IActionResult> GetCategories(int id)
        {
            try
            {
                await _categoryRepos.GetCategories(id);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AddCategories(CategoryModels mode)
        {

            try
            {
                await _categoryRepos.AddCategories(mode);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCategories(CategoryModels mode, int id)
        {
            try
            {
                await _categoryRepos.UpdateCategories(mode, id);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategories(CategoryModels mode, int id)
        { 
            try
            {
                await _categoryRepos.DeleteCategories(mode, id);
            }
             catch (Exception ex)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
    }
}
