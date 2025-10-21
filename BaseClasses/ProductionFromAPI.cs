using System.Text.Json.Serialization;

namespace SequorTest.BaseClasses
{
    public class ProductionFromAPI
    {
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("order")]
        public string Order { get; set; } = string.Empty;

        [JsonPropertyName("productionDate")]
        public string ProductionDate { get; set; }

        [JsonPropertyName("productionTime")]
        public string ProductionTime { get; set; }

        [JsonPropertyName("quantity")]
        public double Quantity { get; set; }

        [JsonPropertyName("materialCode")]
        public string MaterialCode { get; set; } = string.Empty;

        [JsonPropertyName("cycleTime")]
        public double CycleTime { get; set; }

        [JsonPropertyName("materials")]
        public List<OrderMaterial> materials = new List<OrderMaterial>();
    }

    public class InputOrders
    {
        public List<ProductionFromAPI> orders { get; set; }
    }
}
