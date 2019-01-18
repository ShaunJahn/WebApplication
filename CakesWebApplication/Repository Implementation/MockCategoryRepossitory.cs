using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;

namespace CakesWebApplication.Repository_Implementation
{
    public class MockCategoryRepossitory : ICategoryRepository
    {
        public IEnumerable<CategoryDto> Categories
        {
            get
            {
                return new List<CategoryDto>
                {
                    new CategoryDto{Id=1, CategoryName="Fruit pies", Description="All-fruity pies"},
                    new CategoryDto{Id=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                    new CategoryDto{Id=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
                };
            }
        }
    }
}
