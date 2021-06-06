using System;
using System.Collections.Generic;
using System.Text;
using FormUI.Models;

namespace WindowsFormsApp1.Service.CategoryService
{
    public interface ICategoryService
    {
        public Category AddCategory(Category value);
        public Category RemoveCategory(Category value);
        public List<String> GetAllCategories();

    }
}
