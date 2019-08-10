using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositiory_Pattern.Models.DAL
{
    interface IProductRepository
    {
        IEnumerable<Product_Table> GetProducts();
        Product_Table GetProductById(int ProductId);
        void InsertProduct(Product_Table product_);
        void UpdateProduct(Product_Table product_);
        void DeleteProduct(int ProductId);
        void SaveChanges();
    }
}
