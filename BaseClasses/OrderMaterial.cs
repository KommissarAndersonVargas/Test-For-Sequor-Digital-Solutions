namespace SequorTest.BaseClasses
{
    public class OrderMaterial
    {
        public string materialCode { get; set; }

        public string materialDescription { get; set; }

        public OrderMaterial(string materialCode, string materialDescription)
        {
            this.materialCode = materialCode;
            this.materialDescription = materialDescription;
        }
    }
}
