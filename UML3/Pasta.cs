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
        public string PastaType { get; set; }
        public Pasta(int Number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, string pastaType) : base(Number, name, description, price, type, isVegan, isOrganic)
        {
            PastaType = pastaType;
        }


        public override string PrintInfo()
        {
            return base.PrintInfo() + $"{PastaType}";
        }

    }
}
