using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repositiory_Pattern.Models.DAL
{
    public class ProductRepository:IProductRepository
    {
        private DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public void DeleteProduct(int ProductId)
        {
            Product_Table product_ = _dataContext.Product_Table.Find(ProductId);
            _dataContext.Product_Table.Remove(product_);
        }

        public Product_Table GetProductById(int ProductId)
        {
            return _dataContext.Product_Table.Find(ProductId);
        }

        public IEnumerable<Product_Table> GetProducts()
        {
            return _dataContext.Product_Table.ToList();
        }

        public void InsertProduct(Product_Table product_)
        {
            _dataContext.Product_Table.Add(product_);
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }

        public void UpdateProduct(Product_Table product_)
        {
            _dataContext.Entry(product_).State = System.Data.Entity.EntityState.Modified;
        }
    }
}