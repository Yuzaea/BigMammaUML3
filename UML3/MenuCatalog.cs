using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public  class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> _items;

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(IMenuItem aMenuItem)
        {
            IMenuItem foundMenuItem = Search(aMenuItem.Number);
            if (foundMenuItem == null)
                _items.Add(aMenuItem);
        }

        public void Delete(int number)
        {
            IMenuItem item = Search(number);
            _items.Remove(item);
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            foreach (IMenuItem item in _items)
            {
                if (item.IsOrganic == true)
                    Console.WriteLine(item);
                return _items;
            }
            return null;
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            foreach (IMenuItem item in _items)
            {
                if (item.IsVegan == true)
                    Console.WriteLine(item);
                    return _items;
            }
            return null;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            throw new NotImplementedException();
        }

        public void PrintBeveragesMenu()
        {
            foreach (Beverage Beverage in _items)
            {
                Console.WriteLine(Beverage);
            }
        }

        public void PrintPizzasMenu()
        {
            foreach (Pizza pizza in _items)
            {
                Console.WriteLine(pizza);
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (Topping topping in _items)
            {
                Console.WriteLine(topping);
            }
        }

        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in _items)
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
