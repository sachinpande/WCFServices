using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFAndEFService
{
    [ServiceContract]
    public interface IProductService
    {
        /// <summary>
        /// Get product by passing in productId
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        [OperationContract]
        Products GetProductID(int d);

        /// <summary>
        /// Insert new product in the DB
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [OperationContract]
        bool InsertNewProduct(Products p);

        /// <summary>
        /// Discontinue an existing product from the DB
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        [OperationContract]
        bool DiscontinueProduct(int pId);
    }

    [DataContract]
    public class Products
    {
        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public string QuantityPerUnit { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public bool Discontinued { get; set; }

    }
}
