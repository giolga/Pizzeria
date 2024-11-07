using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)] //Bind all these properties that will be accessible in the view
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }

            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
