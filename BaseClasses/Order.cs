namespace SequorTest.BaseClasses
{
    public class Order
    {
        public string order { get; set; }
        public double quantity { get; set; }
        public string productCode { get; set; }
        public string productDescription { get; set; }
        public string image { get; set; }
        public double cycleTime { get; set; }

        public List<OrderMaterial> materials = new List<OrderMaterial>();

        public Order(string order, double quantity, string productCode, string productDescription, string image, double cycleTime, List<OrderMaterial> materials)
        {
            this.order = order;
            this.quantity = quantity;
            this.productCode = productCode;
            this.productDescription = productDescription;
            this.image = image;
            this.cycleTime = cycleTime;
            this.materials = materials;
        }
    }
}
