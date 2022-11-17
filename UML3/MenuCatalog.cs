using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            IMenuItem item = Search(number);
            _menuItems.Remove(item);
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem item in _menuItems)
            {
                if (item.IsOrganic == true)
                    list.Add(item);
            }
            return list;
        }
        //Skal være en liste

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem item in _menuItems)
            {
                if (item.IsVegan == true)
                list.Add(item);
            }
            return list;
        }
        //Skal være en liste

        public IMenuItem MostExpensiveMenuItem()
        {
            //double pleasework = double.MinValue;
            //int t = 0;
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            //foreach (IMenuItem item in _menuItems)
            //{
            //    t++;
            //    if (item.Price > pleasework)
            //    {
            //        //pleasework = _menuItems.Max(t => t.Price);
            //        //pleasework = item.Price;
            //        int value = item.Number;
            //        return _menuItems[value];
            //    }
            //    //if (t == _menuItems.Count)

            //}
            //return null;
            // This is sooo sad ):
            // Overcomplicated it as hell )::::::: sadge

            var pleasework = _menuItems.MaxBy(x => x.Price);
            return pleasework;
        }

        public void PrintBeveragesMenu()
        {
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            foreach (IMenuItem Beverage in _menuItems)
            {
                Console.WriteLine(Beverage.PrintInfo());
            }
        }

        public void PrintPizzasMenu()
        {
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            foreach (IMenuItem pizza in _menuItems)
            {
                Console.WriteLine(pizza.PrintInfo());
            }
        }

        public void PrintToppingsMenu()
        {
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            foreach (IMenuItem topping in _menuItems)
            {
                Console.WriteLine(topping.PrintInfo());
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
            if (_menuItems.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            IMenuItem foundMenuItem = Search(theMenuItem.Number);
            if (foundMenuItem == null)
            {
            }
        }
    }
}
