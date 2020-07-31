using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories(int count);
        IEnumerable<Category> GetAllCategories();
        void CreateCategory(Category model);
        Category GetCategoryById(int id);
        void UpdateCategory(Category categoryToUpdate, Category model);
        void DeleteCategory(Category category);
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RetHouseDbContext _context;
        public CategoryRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateCategory(Category model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Categories.Add(model);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public IEnumerable<Category> GetCategories(int count)
        {
            return _context.Categories.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void UpdateCategory(Category categoryToUpdate, Category model)
        {
            categoryToUpdate.Status = model.Status;
            categoryToUpdate.Name = model.Name;
            categoryToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }

    }
}
