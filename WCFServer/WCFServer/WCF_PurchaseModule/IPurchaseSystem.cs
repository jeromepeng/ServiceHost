using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_PurchaseModule
{
    // NOTE: If you change the interface name "IPurchaseSystem" here, you must also update the reference to "IPurchaseSystem" in Web.config.
    [ServiceContract]
    public interface IPurchaseSystem
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        DataSet PO_GetPurchaseOrder(string PONO);
    }
}
