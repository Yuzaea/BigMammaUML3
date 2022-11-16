using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public  class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> _menuItems;


        public MenuCatalog()
        {
            _menuItems=new List<IMenuItem>();
        }
        public int Count
        {
            get { return _menuItems.Count; }
        }

        public void Add(IMenuItem aMenuItem)
        {
            IMenuItem foundMenuItem = Search(aMenuItem.Number);
            if (foundMenuItem == null)
            {
                _menuItems.Add(aMenuItem);
            }

        }

        public void Delete(int number)
        {
            IMenuItem item = Search(number);
            _menuItems.Remove(item);
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.IsOrganic == true)
                    Console.WriteLine(item);
                return _menuItems;
            }
            return null;
        }
        //Skal være en liste

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.IsVegan == true)
                    Console.WriteLine(item);
                    return _menuItems;
            }
            return null;
        }
        //Skal være en liste

        public IMenuItem MostExpensiveMenuItem()
        {
            foreach (IMenuItem item in _menuItems)
            {
                _menuItems.Max(t => t.Price);
                return item;

            }
            return null;
        }

        public void PrintBeveragesMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintPizzasMenu()
        {
            foreach (Pizza pizza in _menuItems)
            {
                Console.WriteLine(_menuItems);
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (Topping topping in _menuItems)
            {
                Console.WriteLine(topping);
            }
        }

        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.Number == number)
                    return item;
            }
            return null;
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            IMenuItem foundMenuItem = Search(theMenuItem.Number);
            if (foundMenuItem == null)
            {
            }
        }
    }
}
