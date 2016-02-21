using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCFAndEFService
{
    public class ProductService : IProductService
    {
        public bool DiscontinueProduct(int pId)
        {
            throw new NotImplementedException();
        }

        public Products GetProductID(int id)
        {
            Products product = null;
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

        public bool InsertNewProduct(Products p)
        {
            throw new NotImplementedException();
        }

        private Products TranslateProductEntityToProduct(Product productEntity)
        {
            Products p = new Products()
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
