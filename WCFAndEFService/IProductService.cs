using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFAndEFService
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Products GetProductID(int d);
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
