using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId) //retrieves Order object by the order id
        {
            Order order = new Order(orderId);

            //code that retrieves the defined customer

            //Temporary hard coded values to return 
            //a populated customer
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,4,14,10,00,00,
                    new TimeSpan(7,0,0));
            }
            Console.WriteLine($"{order.ToString()}"); //refer to Order class for ToStringMethod
            return order;
        }


        public bool Save(Order order)
        {
            //code that saves the passed-in customer
            return true;
        }
    }
}
