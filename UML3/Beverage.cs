using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    internal class Beverage : MenuItem
    {
        public Beverage(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic) : base(Number, name, description, price, type, isVegan, isOrganic) { }
        public override string PrintInfo()
        {
            return $"number{Number} name{Name} description{Description} price{Price} type{Type} vegan{IsVegan} organic{IsOrganic}";
        }
    }
}