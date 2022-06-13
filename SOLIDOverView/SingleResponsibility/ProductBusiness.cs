using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class ProductBusiness
    {

        public int Add(string name, decimal price)
        {
            //db'ye eklenecek ADO.NET gibi kodlar yazılıyor........
            DbHelper dbHelper = new DbHelper();
            var parameters = new Dictionary<string, object>();
            var product = new Product(name, price);

            parameters.Add("@ProductName", product.Name);
            parameters.Add("@Price", product.Price);

            return dbHelper.Execute("", parameters);
        }
    }
}
