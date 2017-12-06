using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WCFClient.WCF_PurchaseSystem;


namespace WCFClient
{
    public partial class frmCallWCF : Form
    {
        public frmCallWCF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseSystemClient client = new PurchaseSystemClient();
            DataSet ds = client.PO_GetPurchaseOrder("XXX");
            dataGridView1.DataSource = ds.Tables[0];
            client.Close();
        }
    }
}
