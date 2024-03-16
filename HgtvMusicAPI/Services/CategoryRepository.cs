using HgtvMusicAPI.Data;
using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyDbContext _context;
        public CategoryRepository(MyDbContext context)
        {
            _context = context;
        }

        public CategoryVM CreateCategory(CategoryModel model)
        {
            var category = new Category
            {
                NameCategory    = model.NameCategory,
                Path_Img        = model.Path_Img
            };
            _context.Add(category);
            _context.SaveChanges();
            return new CategoryVM
            {
                IdCategory      = category.IdCategory,
                NameCategory    = category.NameCategory,
                Path_Img        = category.Path_Img
            };
        }

        public void Delete(int id)
        {
            var category = _context.Categories.SingleOrDefault(ca => ca.IdCategory == id);
            if (category != null)
            {
                _context.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<CategoryVM> GetAll()
        {
            var category = _context.Categories.Select(ca => new CategoryVM
            {
                NameCategory = ca.NameCategory,
                Path_Img = ca.Path_Img
            });
            return category.ToList();
        }

        public CategoryVM GetById(int id)
        {
            var category = _context.Categories.SingleOrDefault(ca => ca.IdCategory == id);
            if (category != null)
            {
                return new CategoryVM
                {
                    IdCategory = category.IdCategory,
                    NameCategory = category.NameCategory,
                    Path_Img = category.Path_Img
                };

            }
            return null;
        }

        public void UpdateCategory(CategoryVM categoryVM)
        {
            var category = _context.Categories.SingleOrDefault(si => si.IdCategory == categoryVM.IdCategory);
            // chu y
            categoryVM.IdCategory = categoryVM.IdCategory;
            categoryVM.NameCategory = categoryVM.NameCategory;
            categoryVM.Path_Img = categoryVM.Path_Img;

            _context.SaveChanges();
        }
    }
}
