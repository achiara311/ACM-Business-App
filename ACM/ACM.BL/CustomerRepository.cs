using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository() //creates relationship between customer and address repositories
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //code that retrieves the defined customer

            //Temporary hard coded values to return 
            //a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            Console.WriteLine($"Name: {customer}.ToString()");
            return customer;
        }
        

        public bool Save(Customer customer)
        {
            //code that saves the passed-in customer
            return true;
        }
    }
}
