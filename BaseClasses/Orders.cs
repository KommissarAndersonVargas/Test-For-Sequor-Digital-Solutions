using SequorTest.APIs;

namespace SequorTest.BaseClasses
{
    public class Orders
    {
        public static List<Order> orders = new List<Order>();

        public static void SetOrdersList(List<Order> _orders)
        {
            foreach(var anOrder in _orders)
            {
                orders.Add(anOrder);
            }
        }

        public static List<Order> GetOrdersList()
        {
            try 
            {
                SetOrdersList(ManagementProctionsAPI.GetOrders());
                return orders;
            }

            catch (Exception) 
            {
                MessageBox.Show("Error durrin the Desserialization", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
           
        }
    }
}
