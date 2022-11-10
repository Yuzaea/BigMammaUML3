using BigMammaUML3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BigMammaUML3
{
    public class Pasta : MenuItem
    {
    public Pasta(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic) : base (Number, name, description, price, type, isVegan, isOrganic) { }
        public override string PrintInfo()
        {
            return $"number{Number} name{Name} description{Description} price{Price} type{Type} vegan{IsVegan} organic{IsOrganic}";
        }
    }
}