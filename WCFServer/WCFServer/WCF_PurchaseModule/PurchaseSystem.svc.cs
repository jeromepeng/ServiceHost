using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using WCF_PurchaseModule.DALs;
using System.EnterpriseServices;

namespace WCF_PurchaseModule
{
    // NOTE: If you change the class name "PurchaseSystem" here, you must also update the reference to "PurchaseSystem" in Web.config.
    public class PurchaseSystem : IPurchaseSystem
    {
        public void DoWork()
        {
        }

        [Description("获取采购订单")]
        public DataSet PO_GetPurchaseOrder(string PONO)
        {
            return dalPO.GetPurchaseOrder(PONO);
        }
    }
}
