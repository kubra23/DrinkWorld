using DrinkWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkWorld.Repositories.Concretes
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Drink> Drinks {
            get
            {
                return new List<Drink>
                {
                    new Drink
                    {
                        Name="Beer",
                        Price=7.95M,
                        ShortDescription="The most widely consumed alcohol",

                    }
                }
            }; 
            set => throw new NotImplementedException(); }
        public IEnumerable<Drink> PreferredDrinks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
