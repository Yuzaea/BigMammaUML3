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


        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }
        public int Number { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }
                 
    public virtual string PrintInfo()
        {
            return $"Number: {Number}. Name: {Name}. Description: {Description}. Price: {Price}. Type: {Type}. {(IsVegan== true ? "It is Vegan" : "It's not vegan")} .{(IsOrganic==true ? " It is Organic" : " It's not organic")}.  ";
        }



    }

}
