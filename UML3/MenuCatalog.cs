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
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            throw new NotImplementedException();
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            throw new NotImplementedException();
        }

        public void PrintBeveragesMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintPizzasMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintToppingsMenu()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
