using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    
    class Shop
    {
        public double Totalincome { get; set; }
        private Object[] product;
        public Shop()
        {
            product = new object[0];
        }
        public void Add(Object obj)
        {

            Array.Resize(ref product, product.Length + 1);
            product[product.Length - 1] = obj;
            Console.WriteLine("Elave olundu");

        }
    }
   
}
