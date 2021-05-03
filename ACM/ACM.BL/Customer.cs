using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer:EntityBase, ILoggable
    {
        public Customer():this(0) //instantiates AddressList as well
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            this.AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) //if there is only a first name, the fullName is initially null
                {
                    if (!string.IsNullOrWhiteSpace(fullName))//so we set fullName to FirstName
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }


        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {this.EntityState.ToString()}";
      
        public override string ToString()
        {
            return FullName;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))//if LastName values is null or whitespace
                //return false
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))//if EmailAddress is null or whitespace
                //return false
                isValid = false;

            return isValid;
        }

       
    }
}
