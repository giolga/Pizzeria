using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel() {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 4
            },
             new PizzasModel() {
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 3,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 5
            },
            new PizzasModel() {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },
            new PizzasModel() {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },
            new PizzasModel() {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },
            new PizzasModel() {
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },
            new PizzasModel() {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },
            new PizzasModel() {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },
            new PizzasModel() {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 4,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 6
            },

        };
        public void OnGet()
        {
        }
    }
}
