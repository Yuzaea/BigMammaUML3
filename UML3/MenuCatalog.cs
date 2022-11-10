using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public  class MenuCatalog : IMenuCatalog
    {

        public int Count => throw new NotImplementedException();

        public void Add(IMenuItem aMenuItem)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            throw new NotImplementedException();
        }
    }
}
