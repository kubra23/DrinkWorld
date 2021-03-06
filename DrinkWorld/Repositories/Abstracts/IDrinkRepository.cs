using DrinkWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkWorld.Repositories
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink>Drinks { get; set; }
        IEnumerable<Drink> PreferredDrinks { get; set; }
        Drink GetDrinkById(int drinkId);

    }
}
