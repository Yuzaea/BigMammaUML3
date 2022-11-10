using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pizza : MenuItem
    {
        public Pizza(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic) : base(Number, name, description, price, type, isVegan, isOrganic) { }
  






public bool DeepPan { get; set; }


        public bool isVegan { get; set; }


        public bool isOrganic { get; set; }

        public override string PrintInfo()
        {
            return $"number{Number} name{Name} description{Description} price{Price} type{Type} vegan{IsVegan} organic{IsOrganic}";
        }

    }
}
