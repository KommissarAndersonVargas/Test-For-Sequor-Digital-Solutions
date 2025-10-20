using SequorTest.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequorTest.Factories
{
    public class BaseClasesFactory
    {
        public static BaseInfo MaterialInfoFactory(string order, string name, string descricao, string quantity)
        {
            return new MaterialInfo(order, name, descricao, quantity);
        }
    }
}
