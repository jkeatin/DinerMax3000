using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.DSDinerMax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();
        }

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();

            var dtMenu = taMenu.GetData();

            List<Menu> result = new List<Menu>();

            var databaseMenus = dtMenu.Rows;

            foreach (DSDinerMax3000.MenuRow databaseMenu in databaseMenus)
            {
                Menu newMenuObject = new Menu();
                newMenuObject.Name = databaseMenu.Name;

                result.Add(newMenuObject);

                var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(databaseMenu.Id);
           
                foreach (DSDinerMax3000.MenuItemRow menuItemRow in dtMenuItems.Rows)
                {
                    newMenuObject.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
            }

            return result;
        }

        private void AddMenuItem(string name, object description, object price)
        {
            throw new NotImplementedException();
        }

        public void AddMenuItem(string Title, string Description, Double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item);
        }

        public string Name;
        public List<MenuItem> items;
    }
}
