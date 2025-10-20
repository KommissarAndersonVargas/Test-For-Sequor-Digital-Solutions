using System.Xml.Linq;

namespace SequorTest.BaseClasses
{
    public class MaterialInfo : BaseInfo
    {
        public MaterialInfo(string order, string name, string descricao, string quantity)
        {
            this.Ordem = order;
            this.Name = name;
            this.Descricao = descricao;
            this.Quantity = quantity;
        }
    }
}
