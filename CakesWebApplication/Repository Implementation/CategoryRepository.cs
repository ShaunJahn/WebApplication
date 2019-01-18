using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.DbContexts;
using CakesWebApplication.Models;

namespace CakesWebApplication.Repository_Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private PiesDbContext _content;

        public CategoryRepository(PiesDbContext piesDbContext)
        {
            _content = piesDbContext;
        }

        public IEnumerable<CategoryDto> Categories => _content.Categories.OrderBy(c =>c.CategoryName);
    }
}
