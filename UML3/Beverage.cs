using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class  Beverage: MenuItem
    {

        public Beverage(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool IsAlcoholic) : base(Number, name, description, price, type, isVegan, isOrganic)
        {
            isAlcoholic = IsAlcoholic;
        }
        public bool isAlcoholic { get; set; }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $"{(isAlcoholic == true ? "indeholder alkohol" : " ")}  "; ;
        }

    }
}