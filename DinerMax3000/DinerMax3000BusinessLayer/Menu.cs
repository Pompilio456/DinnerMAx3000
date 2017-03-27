using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DinerMax3000.Business.dsDinerMax3000TableAdapters; //esto es si tubiera conectada la DB

namespace DinerMax3000BusinessLayer
{
    public class Menu
    {
        public string Name;
        public List<MenuItem> Items;
        public Menu()
        {
            Items = new List<MenuItem>();
        }
        //esto es si tubiera conectada la DB
        /*
        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach (dsDinerMax3000.MenuRow menuRow in dtMenuRows)
            {
                Menu currentMenu = new Menu;
                currentMenu.Name = menuRow.Name;
                allMenus.Add(currentMenu);
                var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach (dsDinerMax3000.MenuItemRow menuItemRow in deMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name,menuItemRow.Description,menuItemRow.Price)
                }
            }
            return allMenus;
        }
        */
        public void AddMenuItem(string title , string description, double price)
        {
            MenuItem item = new MenuItem();
            item.Titile = title;
            item.Description = description;
            item.Price = price;
            Items.Add(item);

          

        }



    }
}
