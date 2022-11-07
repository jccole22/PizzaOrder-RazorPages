using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaOrder.Models;

namespace PizzaOrder.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>
        {

            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                Ham=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margherita",
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Sausage=true,
                Ham=true,
                Beef=true,
                FinalPrice=8},
            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                TomatoSauce=true,
                Cheese=true,
                Sausage=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                Pineapple=true,
                FinalPrice=6},
        };
        public void OnGet()
        {
        }
    }
}
