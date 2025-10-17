using Newtonsoft.Json;
using SequorTest.BaseClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SequorTest.APIs
{
    public static class ManagementProctionsAPI
    {
        public static List<Order> GetOrders()
        {
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
    }
}
