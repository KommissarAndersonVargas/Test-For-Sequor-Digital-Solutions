using Newtonsoft.Json;
using SequorTest.BaseClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace SequorTest.APIs
{
    public static class ManagementProctionsAPI
    {
        public static List<Order> GetOrders()
        {
            GetProductionFromAPI();

            try
            {
                string path = Path.Combine(@"C:\Users\Usuario\source\repos\SequorTest\Files\OrdersExample.json");

                if (!File.Exists(path))
                {
                    throw new Exception("The JSON file was not found.");
                }

                string json = File.ReadAllText(path);
                var orders = JsonConvert.DeserializeObject<List<Order>>(json);

                return orders ?? new List<Order>();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error during the JSON reading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Order>();
            }
        }

        public static async void GetProductionFromAPI()
        {
             HttpClient client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("https://localhost:7092");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                //string email = "testeteste@sequor.com.br"; //MUDAR
                // string endpoint = $"Production/GetProduction?email={Uri.EscapeDataString(email)}";
 
                string endpoint = $"GetOrders";
                HttpResponseMessage response = await client.GetAsync(endpoint);
                var jsonFile = await response.Content.ReadAsStringAsync();
                MessageBox.Show(jsonFile);

                ProductionResponse responseObj = JsonConvert.DeserializeObject<ProductionResponse>(jsonFile);

                var ordersList = responseObj.productions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exceção: {ex.Message}");
            }
        }
    }
}
