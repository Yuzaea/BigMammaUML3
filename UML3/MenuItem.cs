using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class MenuItem : IMenuItem
    {
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
