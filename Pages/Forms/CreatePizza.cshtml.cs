using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaOrder.Models;

namespace PizzaOrder.Pages.Forms
{
    public class CreatePizzaModel : PageModel
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
            if (Pizza.TomatoSauce)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Cheese)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Pepperoni)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Mushroom)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Sausage)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Ham)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Beef)
            {
                PizzaPrice += 1;
            }

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
