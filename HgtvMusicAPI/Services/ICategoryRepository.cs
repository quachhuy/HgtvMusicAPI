using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public interface ICategoryRepository
    {
        List<CategoryVM> GetAll();
        CategoryVM GetById(int id);

        CategoryVM CreateCategory(CategoryModel model);

        void UpdateCategory(CategoryVM categoryVM);
        void Delete(int id);
    }
}
