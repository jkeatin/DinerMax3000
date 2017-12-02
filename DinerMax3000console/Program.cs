using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Taco","All Norwegians eat taco on Fridays.", 10);
            summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr. Jones.";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A classic.", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Makes you hammered.", 15);

            Order hungryGuestOrder = new Order();

            // The two for statements below are both ways of iterating through all items in a list/array

            for (int x = 0; x <= summerMenu.items.Count-1; x++)
            {
                MenuItem curentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(curentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }
        }
    }
}
