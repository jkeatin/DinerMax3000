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
        }
    }
}
