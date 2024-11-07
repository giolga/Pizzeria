using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSouce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 2;
            if (Pizza.Peperoni) PizzaPrice += 6;
            if (Pizza.Mushroom) PizzaPrice += 6;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Pineapple) PizzaPrice += 2;
            if (Pizza.Ham) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 4;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
