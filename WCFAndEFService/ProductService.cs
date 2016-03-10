using Contracts;
using System;
using System.Linq;

namespace WCFAndEFService
{
    public class ProductService : IProductService
    {
        public bool DiscontinueProduct(int pId)
        {
            throw new NotImplementedException();
        }

        public ProductsData GetProductID(int id)
        {
            ProductsData product = null;
            using (var context = new NorthwindEntities1())
            {
                var productEntity = (from p in context.Products
                                     where p.ProductID == id
                                     select p).FirstOrDefault();
                if(productEntity != null)
                {
                    product = TranslateProductEntityToProduct(productEntity);
                }
                else
                {
                    throw new Exception(string.Format("Invalid productID {0}", id));
                }
            }
            return product;
        }

        public bool InsertNewProduct(ProductsData p)
        {
            throw new NotImplementedException();
        }

        private ProductsData TranslateProductEntityToProduct(Product productEntity)
        {
            ProductsData p = new ProductsData()
            {
                Discontinued = productEntity.Discontinued,
                ProductID = productEntity.ProductID,
                ProductName = productEntity.ProductName,
                QuantityPerUnit = productEntity.QuantityPerUnit,
                UnitPrice = (decimal)productEntity.UnitPrice
            };
            return p;
        }
    }
}
