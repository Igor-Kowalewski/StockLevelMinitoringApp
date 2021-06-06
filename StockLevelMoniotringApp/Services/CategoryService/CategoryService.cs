using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Service.CategoryService
{
    class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _genericRepository;
        private readonly SimpleWarehousContext _simpleWarehousContext;

        public CategoryService(IGenericRepository<Category> genericRepository, SimpleWarehousContext simpleWarehousContext)
        {
            _genericRepository = genericRepository;
            _simpleWarehousContext = simpleWarehousContext;
        }

        public Category AddCategory(Category value)
        {
            var newCategory = new Category() { Name = value.Name };
            _genericRepository.AddEntity(newCategory);
            //Trzeba pobrać nowo dodany item do bayz aby zwracalo z ID
            return newCategory;
        }

        public List<String> GetAllCategories()
        {
            var query = _simpleWarehousContext.Categories.ToList();

            var result = new List<String>();
            if (query != null)
            {
                foreach (var category in query)
                {
                    result.Add( category.Name.ToString() ) ;
                }
            }     
            return result;
        }

        public Category RemoveCategory(Category value)
        {
            var tempCategory = new Category() { Name = value.Name };
            _genericRepository.RemoveEntity(tempCategory);
            return tempCategory;
        }
    }
}
