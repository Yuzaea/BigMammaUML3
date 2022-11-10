using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class MenuItem : IMenuItem
    {
        public MenuItem(string name, string price)
        {
            Name = name;
        }

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }
        private List<Pasta> _pasta;
        private List<Pizza> _pizza;
        public int Number => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MenuType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsVegan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsOrganic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual string PrintInfo()
        {
            return null;
        }
    }

}
