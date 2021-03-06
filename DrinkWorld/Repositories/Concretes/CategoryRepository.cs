using DrinkWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkWorld.Repositories.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get 
            {
                return new List<Category>
                {
                  new Category{CategoryName="Alcoholic",Description="Alcoholic drinks"},
                    new Category{CategoryName="Non-alcoholic",Description="non-alcoholic drinks"}
                };
            } 
           }
    }
}
