using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pizza : MenuItem
    {
        public Pizza(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(Number, name, description, price, type, isVegan, isOrganic) 
        {
            DeepPan = deepPan;
        }


        public bool DeepPan { get; set; }


        
        public override string PrintInfo()
        {
            return base.PrintInfo() + $"deep {  (DeepPan== true ? "Er deeppan" : "normal") }  ";
        }

    }
}
