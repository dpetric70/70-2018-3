using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MenuItemBuisiness
    {
        private readonly MenuItemRepository menuItemRepository;

        public MenuItemBuisiness()
        {
            this.menuItemRepository = new MenuItemRepository();
        }

        public List<MenuItem> getMenuItemsByPrice(decimal min, decimal max)
        {
            List<MenuItem> list = new List<MenuItem>();
            List<MenuItem> allItems = this.menuItemRepository.GetAllMenuItems();

            foreach (MenuItem m in allItems)
            {
                if(m.Price>min && m.Price < max)
                {
                    list.Add(m);
                }
            }
            return list;
                
         }
        public bool insertMenuItem(MenuItem x)
        {
            if (this.menuItemRepository.InsertMenuItem(x) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
