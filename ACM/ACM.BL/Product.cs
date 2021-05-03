using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product:EntityBase,ILoggable
    {
        

        public Product()
        {

        }


        public Product(int productId)
        {
            this.ProductId = productId;
        }

        private string _productName;
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName //ProductName in this class will now always 
            //insert appropriate spaces in the name
        {
            get
            {
                return _productName.InsertSpacesInWords();
            }
            set
            {
                _productName = value;
            }
        }

        public string Log() => $"{ProductId}: Product: {ProductName} Status: {this.EntityState.ToString()}";
        public override string ToString()
        {
            return ProductName; //returning instance property as string when debugging
        }


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))//if ProductName values is null or have whitespace
                //return false
                isValid = false;
            if (CurrentPrice == null)//if CurrentPrice is null 
                //return false
                isValid = false;

            return isValid;
        }

       
    }
}
