using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace logClass
{
    public class log_ex
    {
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection conlog = null;
        SqlCommand cmdlog = null;
        SqlConnection conerr = null;
        SqlCommand cmderr = null;
        //
        public string errcode;
        public void insert_log_event(string uid, string OperationDesc, string mcode, string mid)
        {
            conlog = new SqlConnection(csh);
            cmdlog = null;
            try
            {
                cmdlog = new SqlCommand("insert into act_log(uid,OperationDesc,mcode,mid) values('"+uid + "','" + OperationDesc + "','" + mcode + "','" + mid+"')", conlog);
                conlog.Open();
                cmdlog.ExecuteNonQuery();
                conlog.Close();
            }
            catch (Exception)
            {
                conlog.Close();
            }
        }

        public void insert_log_err(string uid, string errDesc, string mcode, string mid)
        {
            conerr = new SqlConnection(csh);
            cmderr = null;
            try
            {
                cmderr = new SqlCommand("insert into err_log(uid,errDesc,mcode,mid) values('" + uid +"', '" + errDesc+"', '"+mcode+"','"+ mid +"')", conerr);
                conerr.Open();
                cmderr.ExecuteNonQuery();
                conerr.Close();
            }
            catch (Exception)
            {
                conerr.Close();
                throw;
                
            }
        }
    }
}
