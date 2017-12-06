using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WCF_PurchaseModule.DALs
{
    public class dalPO
    {
        public static DataSet GetPurchaseOrder(string PONO)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PONO", typeof(String));
            dt.Columns.Add("DocDate", typeof(DateTime));

            dt.Rows.Add(new object[] { "P00001", DateTime.Now });
            dt.Rows.Add(new object[] { "P00002", DateTime.Now });
            dt.Rows.Add(new object[] { "P00003", DateTime.Now });

            dt.AcceptChanges();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
