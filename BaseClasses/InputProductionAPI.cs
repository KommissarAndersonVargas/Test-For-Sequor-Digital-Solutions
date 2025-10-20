using System.Text.Json.Serialization;

namespace SequorTest.BaseClasses
{
    public class InputProductionAPI
    {
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("order")]
        public string Order { get; set; } = string.Empty;

        [JsonPropertyName("productionDate")]
        public DateTime ProductionDate { get; set; }

        [JsonPropertyName("productionTime")]
        public TimeSpan ProductionTime { get; set; }

        [JsonPropertyName("quantity")]
        public double Quantity { get; set; }

        [JsonPropertyName("materialCode")]
        public string MaterialCode { get; set; } = string.Empty;

        [JsonPropertyName("cycleTime")]
        public double CycleTime { get; set; }
    }

    public class ProductionResponse
    {
        public List<InputProductionAPI> productions { get; set; }
    }
}
