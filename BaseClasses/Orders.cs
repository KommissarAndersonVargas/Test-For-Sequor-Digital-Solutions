using SequorTest.APIs;

namespace SequorTest.BaseClasses
{
    public class Orders
    {
        public static List<Order> orders = new List<Order>();

        public static List<Order> GetOrdersList()
        {
            try 
            {
                //SetOrdersList(ManagementProctionsAPI.GetOrders());
                //return orders;

                var ordersList = ManagementProctionsAPI.GetOrdersFromAPI();
                return ordersList;
            }

            catch (Exception) 
            {
                MessageBox.Show("Error durrin the Desserialization", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
           
        }
    }
}
