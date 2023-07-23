using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using logClass;
using inrClass;
using System.Data.SqlClient;
using System.Globalization;

namespace SHARIQHMS.Reservations
{
    public partial class frmCheckinDialog : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        //
        SqlConnection conupdstatic = null;
        SqlCommand cmdupdstatic = null;
        //
        SqlConnection conloadstatic = null;
        SqlCommand cmdloadstatic = null;
        SqlDataReader rdrloadstatic = null;
        //
        SqlConnection conloadrooms = null;
        SqlCommand cmdloadrooms = null;
        SqlDataReader rdrloadrooms = null;
        //
        SqlConnection conupdres = null;
        SqlCommand cmdupdres = null;
        //
        //
        SqlConnection conchkresid = null;
        SqlCommand cmdchkresid = null;
        SqlDataReader rdrchkresid = null;
        //
        #endregion Database string and connection
        public string checkedindatetime,nowdate,getcheckindate,getcheckoutdate,room_restaurantid;
        string refno;
        public Boolean actioncancel,isCancel,isCheckedin,isCheckedout = false;

        public frmCheckinDialog(string ref_no)
        {
            InitializeComponent();
            refno = ref_no;
        }

        private void tilecancel_Click(object sender, EventArgs e)
        {
            actioncancel = true;
            this.Close();
        }

        public void getrestaurantid(string rno)
        {
            room_restaurantid = "";
            conchkresid = new SqlConnection(csh);
            cmdchkresid = null;
            try
            {
                cmdchkresid = new SqlCommand("select * from room_mast where m_del='0' AND rno='" + rno + "'", conchkresid);
                conchkresid.Open();
                rdrchkresid = cmdchkresid.ExecuteReader();
                rdrchkresid.Read();
                {
                    room_restaurantid = ((string)rdrchkresid["resint"]);
                }
                conchkresid.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conchkresid.Close();
            }
        }

        private void tileCheckin_Click(object sender, EventArgs e)
        {
            #region check for required fields
            if (chklstb.CheckedIndices.Count < 1)
            {
                MessageBox.Show("Kindly Select Rooms");
                return;
            }
            #endregion check for required fields
            #region get formated date
            string dcon = dtpCheckin.Text;
            DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            getcheckindate = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");
            //
            getcheckoutdate = Convert.ToDateTime(getcheckindate).AddHours(+5).ToString("yyyy/MM/dd HH:mm:ss.fff");
            #endregion get formated date
            if (isCheckedin==true && isCheckedout == false)
            {
                #region Static Update
                conupdstatic = new SqlConnection(csh);
                cmdupdstatic = null;
                try
                {
                    if (chkboxrooms.Checked == true)
                    {
                        cmdupdstatic = new SqlCommand("update reservation_static set isCheckedin='False', IsCheckedout='True' , checkin_date='" + getcheckindate + "' , checkout_date='" + getcheckoutdate + "' where m_del='0' AND res_no='" + refno + "' ", conupdstatic);
                    }
                    else
                    {
                        cmdupdstatic = new SqlCommand("update reservation_static set isCheckedin='True' , checkin_date='" + getcheckindate + "' , checkout_date='" + getcheckoutdate + "' where m_del='0' AND res_no='" + refno + "' ", conupdstatic); 
                    }
                    conupdstatic.Open();
                    cmdupdstatic.ExecuteNonQuery();
                    conupdstatic.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("StaticUPD-Failded\n" + ex.ToString());
                    conupdstatic.Close();
                    return;
                }
                #endregion static update
                var checkeditem = chklstb.CheckedIndices;
                foreach (var item in checkeditem)
                {
                    #region det update
                    conupdstatic = new SqlConnection(csh);
                    cmdupdstatic = null;
                    try
                    {
                        cmdupdstatic = new SqlCommand("update reservation_det set isCheckedin='False' , IsCheckedout='True' , rcheckin_date='" + getcheckindate + "' , rcheckout_date='" + getcheckoutdate + "' where m_del='0' AND res_no='" + refno + "' AND room_no='" + chklstb.Items[Convert.ToInt32(item)] + "'", conupdstatic);
                        conupdstatic.Open();
                        cmdupdstatic.ExecuteNonQuery();
                        conupdstatic.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("det-UPD-Failded\n" + ex.ToString());
                        conupdstatic.Close();
                        return;
                    }
                    #endregion det update
                    #region update restarutant struct
                    getrestaurantid(chklstb.Items[Convert.ToInt32(item)].ToString());
                    conupdres = new SqlConnection(csr);
                    cmdupdres = null;
                    try
                    {
                        cmdupdres = new SqlCommand("update Tables set Name='" + "-" + txtbfname.Text.Replace("-"+txtbfname.Text,"") + "' where id='" + room_restaurantid + "'", conupdres);
                        conupdres.Open();
                        cmdupdres.ExecuteNonQuery();
                        conupdres.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("restaurantupdfailed" + ex.ToString());
                        conupdres.Close();
                        return;
                    }
                    #endregion update restaurant struct
                    #region update operational database
                    conupdres = null;
                    conupdres = new SqlConnection(csh);
                    cmdupdres = null;
                    try
                    {
                        cmdupdres = new SqlCommand("update operational_room set room_status='Checkedout' , isIssuable='True' , isCheckedIn='False' , since_checkin=NULL where room_no='" + chklstb.Items[Convert.ToInt32(item)].ToString() + "' AND current_refno='" + refno + "'", conupdres);
                        conupdres.Open();
                        cmdupdres.ExecuteNonQuery();
                        conupdres.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("operational_room" + ex.ToString());
                        conupdres.Close();
                        return;
                    }
                    #endregion update operational database
                }
                actioncancel = false;
                this.Close();
                this.Hide();
            }
            else if(isCheckedin == false && isCheckedout == false)
            {
                #region Static Update
                conupdstatic = new SqlConnection(csh);
                cmdupdstatic = null;
                try
                {
                    cmdupdstatic = new SqlCommand("update reservation_static set isCheckedin='True' , checkin_date='" + getcheckindate + "' , checkout_date='" + getcheckoutdate + "' where m_del='0' AND res_no='" + refno + "' ", conupdstatic);
                    conupdstatic.Open();
                    cmdupdstatic.ExecuteNonQuery();
                    conupdstatic.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("StaticUPD-Failded\n" + ex.ToString());
                    conupdstatic.Close();
                    return;
                }
                #endregion static update
                var checkeditem = chklstb.CheckedIndices;
                foreach (var item in checkeditem)
                {
                    #region det update
                    conupdstatic = new SqlConnection(csh);
                    cmdupdstatic = null;
                    try
                    {
                        cmdupdstatic = new SqlCommand("update reservation_det set isCheckedin='True' , rcheckin_date='" + getcheckindate + "' , rcheckout_date='" + getcheckoutdate + "' where m_del='0' AND res_no='" + refno + "' AND room_no='" + chklstb.Items[Convert.ToInt32(item)] + "'", conupdstatic);
                        conupdstatic.Open();
                        cmdupdstatic.ExecuteNonQuery();
                        conupdstatic.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("det-UPD-Failded\n" + ex.ToString());
                        conupdstatic.Close();
                        return;
                    }
                    #endregion det update
                    #region update restarutant struct
                    getrestaurantid(chklstb.Items[Convert.ToInt32(item)].ToString());
                    conupdres = new SqlConnection(csr);
                    cmdupdres = null;
                    try
                    {
                        cmdupdres = new SqlCommand("update Tables set Name=Name+'" + "-" + txtbfname.Text + "' where id='" + room_restaurantid + "'", conupdres);
                        conupdres.Open();
                        cmdupdres.ExecuteNonQuery();
                        conupdres.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("restaurantupdfailed" + ex.ToString());
                        conupdres.Close();
                        return;
                    }
                    #endregion update restaurant struct
                    #region update operational database
                    conupdres = null;
                    conupdres = new SqlConnection(csh);
                    cmdupdres = null;
                    try
                    {
                        cmdupdres = new SqlCommand("update operational_room set room_status='Checkedin' , isIssuable='False' , isCheckedIn='True' , since_checkin='" + getcheckindate + "' where room_no='" + chklstb.Items[Convert.ToInt32(item)].ToString() + "' AND current_refno='" + refno + "'", conupdres);
                        conupdres.Open();
                        cmdupdres.ExecuteNonQuery();
                        conupdres.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("operational_room" + ex.ToString());
                        conupdres.Close();
                        return;
                    }
                    #endregion update operational database
                }
                actioncancel = false;
                this.Close();
                this.Hide();
            }
        }

        private void chkboxrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxrooms.Checked == true)
            {
                for (int i = 0; i < chklstb.Items.Count; i++)
                {
                    chklstb.SetItemChecked(i, true);
                }
            }
            else if (chkboxrooms.Checked == false)
            {
                for (int i = 0; i < chklstb.Items.Count; i++)
                {
                    chklstb.SetItemChecked(i, false);
                }
            }
        }

        private void frmCheckinDialog_Load(object sender, EventArgs e)
        {
            this.Text = refno + " | Reservation Check In";
            cboxrefno.Text = refno;
            #region load date & time
            nowdate = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            dtpCheckin.CustomFormat = "dd/MM/yy hh:mm tt";
            dtpCheckin.Format = DateTimePickerFormat.Custom;
            dtpCheckin.Text = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            #endregion load date & Time
            loadstatic();
            loadrooms();
        }

        public void loadstatic()
        {
            conloadstatic = new SqlConnection(csh);
            cmdloadstatic = null;
            try
            {
                cmdloadstatic = new SqlCommand("select * from reservation_static where m_del='0' AND res_no='" + refno + "' AND isCheckedin='False' AND isCheckedout='False'", conloadstatic);
                conloadstatic.Open();
                rdrloadstatic = cmdloadstatic.ExecuteReader();
                rdrloadstatic.Read();
                {
                    #region load reservation
                    txtbcname.Text = ((string)rdrloadstatic["cname"]);
                    txtbfname.Text = ((string)rdrloadstatic["fname"]);
                    txtbphone.Text = ((string)rdrloadstatic["contact"]);
                    isCancel = (Boolean)rdrloadstatic["isCancel"];
                    isCheckedin = (Boolean)rdrloadstatic["isCheckedIn"];
                    isCheckedout = (Boolean)rdrloadstatic["isCheckedOut"];
                    if (isCheckedin == true)
                    {
                        tileCheckin.Text = "Check out";
                    }
                    else
                    {

                    }
                    //
                    if (isCancel == true)
                    {
                        MessageBox.Show("Unexpected Error\nSTOP!\nReport software administrator error.");
                        return;
                    }
                    else if (isCancel == false)
                    {

                    }
                    #endregion load reservation
                }
                conloadstatic.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadstatic.Close();
            }
        }

        private void dtpCheckin_Leave(object sender, EventArgs e)
        {
            if (dtpCheckin.Value < Convert.ToDateTime(nowdate).AddHours(-3))
            {
                nowdate = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
                dtpCheckin.Text = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            }
        }

        public void loadrooms()
        {
            chklstb.Items.Clear();
            conloadrooms = new SqlConnection(csh);
            cmdloadrooms = null;
            try
            {
                cmdloadrooms = new SqlCommand("select * from reservation_det where m_del='0' AND res_no='" + refno + "'", conloadrooms);
                conloadrooms.Open();
                rdrloadrooms = cmdloadrooms.ExecuteReader();
                while (rdrloadrooms.Read() == true)
                {
                    string rcheckinDate = Convert.ToString(((DateTime)rdrloadrooms["rcheckin_date"]).ToString("dd/MM/yy hh:mm tt"));
                    string rcheckoutDate = Convert.ToString(((DateTime)rdrloadrooms["rcheckout_date"]).ToString("dd/MM/yy hh:mm tt"));
                    chklstb.Items.Add((string)rdrloadrooms["room_no"]);
                }
                conloadrooms.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadrooms.Close();
            }
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckin.Value < Convert.ToDateTime(nowdate).AddHours(-3))
            {
                //nowdate = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
                //dtpCheckin.Text = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            }
        }

        private void frmCheckinDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (actioncancel == false)
            {
                e.Cancel = true;
                return;
            }
        }

    }
}
