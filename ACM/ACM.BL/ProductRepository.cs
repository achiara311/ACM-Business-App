using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId) //retrieves customer object by the customer id
        {
            //Retrieve creates an instance of the Product class
            Product product = new Product(productId);

            //code that retrieves the defined customer

            //Temporary hard coded values to return 
            //a populated customer
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }


        public bool Save(Product product)
        {
            //code that saves the passed-in customer
            bool success = true;

            if(product.HasChanges) //if product has no changes, skip all the way to the else
                //statement at the bottom; no need to save.
            {
                if(product.IsValid)//if there are changes, Validate method will be called
                    //which is in the getter in the EntityBase  class
                {
                    if(product.IsNew)//if the product has changed & is valid...
                    {
                        //Call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
