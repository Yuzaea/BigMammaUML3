using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    internal class Topping:MenuItem
    {

        public Topping(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, string pastaType) : base(Number, name, description, price, type, isVegan, isOrganic)
        {

        }
        public override string PrintInfo()
        {
            return base.PrintInfo();
        }

    }
}