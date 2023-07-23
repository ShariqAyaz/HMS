using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace inrClass
{
    public class inrcini
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        // insert customer master
        SqlConnection concustmast = null;
        SqlCommand cmdcustmast = null;
        // Insert room master
        SqlConnection conroommast = null;
        SqlCommand cmdroommast = null;
        // Insert attribute master
        SqlConnection conattrmast = null;
        SqlCommand cmdattrmast = null;
        // Insert attribute profile
        SqlConnection conattrprof = null;
        SqlCommand cmdattrprof = null;
        #endregion Database string and connection

        public string errorcode = "";

        // Customer Inserts
        public void insert_mast_cust(string cid,string compname,string custname,string faminfo,string dob,string phone1,string phone2,string phone3,string custid,string nationality,string cemail,string billtoemail,string address,string profession,string ctag,string cotherinfo,string remarks,string uid,string m_del)
        {
            try
            {
                concustmast = new SqlConnection(csh);
                cmdcustmast = null;
                cmdcustmast = new SqlCommand("INSERT INTO cust_mast(cid,compname,custname,faminfo,dob,phone1,phone2,phone3,custid,nationality,cemail,billtoemail,address,profession,ctag,cotherinfo,remarks,uid,m_del) values('"+cid+"','"+compname+"','"+custname+"','"+faminfo+"','"+dob+"','"+phone1+"','"+phone2+"','"+phone3+"','"+custid+"','"+nationality+"','"+cemail+"','"+billtoemail+"','"+address+"','"+profession+"','"+ctag+"','"+cotherinfo+"','"+remarks+"','"+uid+"','"+m_del+"')", concustmast);
                concustmast.Open();
                cmdcustmast.ExecuteNonQuery();
                concustmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_CUST_INRCINI \n" + ex.ToString();
                concustmast.Close();
                throw;
            }
        }

        // Room Insert
        public void insert_mast_room(string rno,string location,string floor,string attrprofile,string rcat,string resint,string desc,string uid,string m_del)
        {
            try
            {
                conattrmast = new SqlConnection(csh);
                cmdattrmast = null;
                cmdattrmast = new SqlCommand("INSERT INTO room_mast(rno,location,floor,attrprofile,rcat,resint,rdesc,uid,m_del) values('"+rno+"','"+location+"','"+floor+"','"+attrprofile+"','"+rcat+"','"+resint+"','"+desc+"','"+uid+"','"+m_del + "')", conattrmast);
                conattrmast.Open();
                cmdattrmast.ExecuteNonQuery();
                conattrmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_ROOM_INRCINI \n" + ex.ToString();
                conattrmast.Close();
                throw;
            }
        }

        public void insert_room_operational(string room_no,string room_status,Boolean isIssueable,string current_refno,Boolean isCheckedIn,string since_checkin,string room_instruction,string uid,string m_del)
        {
            try
            {
                conattrmast = new SqlConnection(csh);
                cmdattrmast = null;
                cmdattrmast = new SqlCommand("INSERT INTO operational_room(room_no,room_status, isIssuable,current_refno, isCheckedIn,since_checkin,room_instruction,uid,m_del) values('"+room_no+"','"+room_status+"','"+ isIssueable+"','"+current_refno+"','"+ isCheckedIn+"',"+since_checkin+",'"+room_instruction+"','"+uid+"','"+m_del+"')", conattrmast);
                conattrmast.Open();
                cmdattrmast.ExecuteNonQuery();
                conattrmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_ROOM_INRCINI \n" + ex.ToString();
                conattrmast.Close();
                throw;
            }
        }

        // attribute Insert
        public void insert_mast_attribute(string name,string men, string cat, string uid,string m_del)
        {
            try
            {
                conattrmast = new SqlConnection(csh);
                cmdattrmast = null;
                cmdattrmast = new SqlCommand("INSERT INTO attribute_mast(name,men,cat,uid,m_del) values('" + name + "','" + men + "','" + cat + "','" + uid+ "','" + m_del + "')", conattrmast);
                conattrmast.Open();
                cmdattrmast.ExecuteNonQuery();
                conattrmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_ROOM_INRCINI \n" + ex.ToString();
                conattrmast.Close();
                throw;
            }
        }

        // attribute profile insert
        public void insert_mast_attributeprof(string profname, string attname, string uid, string m_del)
        {
            try
            {
                concustmast = new SqlConnection(csh);
                cmdcustmast = null;
                cmdcustmast = new SqlCommand("INSERT INTO attribute_prof(profname,attname,uid,m_del) values('"+profname+ "','" + attname + "','" + uid + "','" + m_del +"')", concustmast);
                concustmast.Open();
                cmdcustmast.ExecuteNonQuery();
                concustmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_ATTRPROF_INRCINI \n" + ex.ToString();
                concustmast.Close();
                throw;
            }
        }

        // create static head. reservation no creation
        public void insert_reservation_static(string res_no,string res_type,string res_date,Boolean IsCheckedIn,Boolean isCheckedout, Boolean IsConfirm,Boolean IsCancel,string res_status,string promocode,string checkin_date,string checkout_date
            ,string cname,string fname,string lname,string contact,string faminfo,Boolean IsMale,string cnationality,string idcard,string address,int rooms_tot,decimal meals_tot,decimal services_tot,decimal advanced,decimal bill_total
            ,decimal received_amount,decimal discount,string remarks,Boolean isLocked,string uid,string m_del)
        {
            try
            {
                concustmast = new SqlConnection(csh);
                cmdcustmast = null;
                cmdcustmast = new SqlCommand("INSERT INTO reservation_static(res_no,res_type,res_date,IsCheckedIn,IsCheckedOut,IsConfirm,IsCancel,res_status,promocode,checkin_date,checkout_date,cname,fname,lname,contact,faminfo,isMale,cnationality,idcard,address,rooms_tot,meals_tot,services_tot,advanced,bill_total,received_amount,discount,remarks,isLocked,uid,m_del) values('"+res_no+"','"+res_type+"','"+res_date+"','"+IsCheckedIn+"','"+ isCheckedout + "','"+IsConfirm+ "','" + IsCancel + "','" + res_status+"','"+promocode+"','"+checkin_date+"','"+checkout_date+"','"+cname+"','"+fname+"','"+lname+"','"+contact+"','"+faminfo+"','"+IsMale+"','"+cnationality+"','"+idcard+"','"+address+"',"+rooms_tot+","+meals_tot+","+services_tot+","+advanced+","+bill_total+","+received_amount+","+ discount + ",'"+remarks+"','"+isLocked+"','"+uid+"','"+m_del+"')", concustmast);
                concustmast.Open();
                cmdcustmast.ExecuteNonQuery();
                concustmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_RESERSTATIC_INRCINI \n" + ex.ToString();
                concustmast.Close();
                throw;
            }
        }

        // create details reservation room details create here
        public void insert_reservation_det(string res_no, string res_date,Boolean IsCheckedIn, Boolean isCheckedout, Boolean IsCancel, string rcheckin_date, string rcheckout_date,string room_no,string rguestname,string rguestidcard,string rguestphone
            ,string rguestadd, decimal rdayrate,int rdays,decimal room_meals,Boolean isLocked,string uid,string m_del)
        {
            try
            {
                concustmast = new SqlConnection(csh);
                cmdcustmast = null;
                cmdcustmast = new SqlCommand("INSERT INTO reservation_det(res_no,res_date,IsCheckedIn,IsCheckedOut,IsCancel,rcheckin_date,rcheckout_date,room_no,rguestname,rguestidcard,rguestphone,rguestadd,rdayrate,rdays,room_meals,isLocked,uid,m_del) values('" + res_no+"','"+res_date+"','"+IsCheckedIn+ "','"+isCheckedout+"','" + IsCancel + "','" + rcheckin_date+"','"+rcheckout_date+"','"+room_no+"','"+rguestname+"','"+rguestidcard+"','"+rguestphone+"','"+ rguestadd + "',"+rdayrate+","+rdays+","+room_meals+ ",'" + isLocked + "','" + uid + "','" + m_del + "')", concustmast);
                concustmast.Open();
                cmdcustmast.ExecuteNonQuery();
                concustmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_RESERVATION_DET_INRCINI \n" + ex.ToString();
                concustmast.Close();
                throw;
            }
        }

        public void insert_reservation_serdet(string res_no, Boolean IsCancel, string res_date,string ser_date,string room_no,string services_desc,decimal serRate,int serQty,string uid,string m_del)
        {
            try
            {
                concustmast = new SqlConnection(csh);
                cmdcustmast = null;
                cmdcustmast = new SqlCommand("INSERT INTO reservation_serdet(res_no,IsCancel,res_date,ser_date,room_no,services_desc, serRate,serQty,uid,m_del) values('"+res_no+"','"+IsCancel+"','"+res_date+"','"+ser_date+"','"+room_no+"','"+services_desc+"',"+serRate+","+serQty+",'"+uid+"','"+m_del+"')", concustmast);
                concustmast.Open();
                cmdcustmast.ExecuteNonQuery();
                concustmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "INSERT_RESERVATION_DET_INRCINI \n" + ex.ToString();
                concustmast.Close();
                throw;
            }
        }

        // create static head. reservation no creation
        public void update_reservation_static(string res_no, string res_type, string res_date, Boolean IsCheckedIn, Boolean isCheckedout, Boolean IsConfirm,Boolean IsCancel, string res_status, string promocode, string checkin_date, string checkout_date
            , string cname, string fname, string lname, string contact, string faminfo, Boolean IsMale, string cnationality, string idcard,string address, int rooms_tot, decimal meals_tot, decimal services_tot, decimal advanced, decimal bill_total
            , decimal received_amount, decimal discount, string remarks, Boolean isLocked, string uid, string m_del)
        {
            try
            {
                concustmast = new SqlConnection(csh);
                cmdcustmast = null;
                cmdcustmast = new SqlCommand("update reservation_static set address='"+address+"' , res_type='" + res_type + "' , IsConfirm='" + IsConfirm + "', IsCancel='"+IsCancel+"' , res_status='" + res_status + "' , promocode='" + promocode + "' , checkin_date='" + checkin_date + "' , checkout_date='" + checkout_date + "' , cname='" + cname + "' , fname='" + fname + "' , lname='" + lname + "' , contact='" + contact + "' , faminfo='" + faminfo + "' , isMale='" + IsMale + "' , cnationality='" + cnationality + "' , idcard='" + idcard + "' , rooms_tot=" + rooms_tot + " , meals_tot=" + meals_tot + " , services_tot=" + services_tot + " , advanced=" + advanced + " , bill_total=" + bill_total + " , received_amount=" + received_amount + " , discount="+discount+" , remarks='" + remarks + "' WHERE res_no='"+res_no+"' ", concustmast);
                concustmast.Open();
                cmdcustmast.ExecuteNonQuery();
                concustmast.Close();
            }
            catch (Exception ex)
            {
                errorcode = "UPD_RESERSTATIC_INRCINI \n" + ex.ToString();
                concustmast.Close();
                throw;
            }
        }

    }
}