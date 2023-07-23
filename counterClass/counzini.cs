using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace counterClass
{
    public class counzini
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        // insert customer counter
        SqlConnection concustcount = null;
        SqlDataReader rdrcustcount = null;
        SqlCommand cmdcustcount = null;
        #endregion Database string and connection

        public string errcode = "";
        public int custcount = 0;
        public void custcounter()
        {
            concustcount = new SqlConnection(csh);
            cmdcustcount = null;
            try
            {
                cmdcustcount = new SqlCommand("select count(id) AS count from cust_mast", concustcount);
                concustcount.Open();
                rdrcustcount = cmdcustcount.ExecuteReader();
                rdrcustcount.Read();
                {
                    custcount = ((Int32)rdrcustcount["count"]);
                }
                concustcount.Close();
            }
            catch (Exception ex)
            {
                errcode = "custcount_CUST_custcountORD \n" + ex.ToString();
                concustcount.Close();
            }
            custcount += 1;
        }
    }
}
