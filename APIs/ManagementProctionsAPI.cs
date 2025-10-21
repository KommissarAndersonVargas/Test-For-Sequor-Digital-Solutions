using Newtonsoft.Json;
using SequorTest.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Windows.Forms;

namespace SequorTest.APIs
{
    public static class ManagementProctionsAPI
    {
        public static bool IsAPiWorking;
        public static List<Order> GetOrders()
        {
            GetOrdersFromAPI();
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

        public static bool SendProductionSync(ProductionFromAPI model)
        {
            try
            {
                string url = "https://localhost:7092/Production/SetProduction";
                string json = JsonConvert.SerializeObject(model);

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    IsAPiWorking = true;
                    MessageBox.Show("The date was sent!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    IsAPiWorking = false;
                    MessageBox.Show($"Error during sent: {response.StatusCode}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }

        public static bool WasDataSent()
        {
            return IsAPiWorking;
        }

        public static List<Order> GetOrdersFromAPI()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7092");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    string endpoint = "GetOrders";

                  
                    HttpResponseMessage response = client.GetAsync(endpoint).GetAwaiter().GetResult();
                    string jsonFile = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();


                    var wrapper = JsonConvert.DeserializeObject<OrdersList>(jsonFile);
                    var list = wrapper?.orders ?? new List<Order>();
                    return list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter dados da API: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Order>();
            }
        }

    }
}
