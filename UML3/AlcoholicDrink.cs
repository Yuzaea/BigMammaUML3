using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    internal class AlcoholicDrink : MenuItem
    {

        public AlcoholicDrink(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic,bool IsAlcoholic) : base(Number, name, description, price, type, isVegan, isOrganic)
        {
            isAlcoholic = IsAlcoholic;
        }
        public bool isAlcoholic { get; set; }


        public override string PrintInfo()
        {
            return base.PrintInfo() + $"deep {(isAlcoholic == true ? "indeholder alkohol" : " ")}  "; ;
        }

    }
}