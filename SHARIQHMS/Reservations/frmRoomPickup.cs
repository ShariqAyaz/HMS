using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using System.Data.SqlClient;
using logClass;
using inrClass;
using System.Globalization;


namespace SHARIQHMS.Reservations
{
    public partial class frmRoomPickup : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        // load available room
        SqlConnection conloadr = null; 
        SqlCommand cmdloadr = null;
        SqlDataReader rdrloadr = null;
        //
        SqlConnection congetres = null;
        SqlCommand cmdgetres = null;
        SqlDataReader rdrgetres = null;
        //
        SqlConnection conupdres = null;
        SqlCommand cmdupdres = null;
        //
        SqlConnection conchkresid = null;
        SqlCommand cmdchkresid = null;
        SqlDataReader rdrchkresid = null;
        //
        SqlConnection conresid = null;
        SqlCommand cmdresid = null;
        SqlDataReader rdrresid = null;
        #endregion Database string and connection
        public Boolean user_action = false;
        public Boolean get_action = false;
        public Boolean get_edit = false;
        string get_indate,get_outdate;
        public string getresno,resdate = "";
        public Boolean isLocked, res_isChecked,formload,isCancel = false;
        string acc_code, room_restaurantid, checkoutDate, checkinDate, ui_code, auth_code;

        private void txtbRate_Click(object sender, EventArgs e)
        {

        }

        private void txtbRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow numbers (-) (.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkboxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAll.Checked == true)
            {
                for (int i = 0; i < lstvRoom.Items.Count; i++)
                {
                    lstvRoom.Items[i].Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < lstvRoom.Items.Count; i++)
                {
                    lstvRoom.Items[i].Checked = false;
                }
            }
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckout.Text = Convert.ToString(Convert.ToDateTime(dtpCheckin.Text).AddDays(+1).ToString("dd/MM/yy hh:mm tt"));
            checkinDate = Convert.ToString(Convert.ToDateTime(dtpCheckin.Text).ToString("dd/MM/yy hh:mm tt"));
        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            checkoutDate = Convert.ToString(Convert.ToDateTime(dtpCheckout.Text).ToString("dd/MM/yy hh:mm tt"));
            cbmprocessor.cbmprocessor cbm = new cbmprocessor.cbmprocessor();
            cbm.daycounter(dtpCheckin.Value, dtpCheckout.Value);
            lblnodays.Text = cbm.days.ToString();
        }

        private void cboxrno_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadavailableroom_r(cboxrno.Text);
        }

        private void lstvRoom_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (formload == true)
            {
                if (lstvRoom.CheckedIndices.Count < 0)
                {

                }
                else
                {

                }
            }
            else if (formload == false)
            {

            }
        }

        public void loadavailableroom_r(string rno)
        {
            formload = false;
            //dtpCheckin.Text = get_indate;
            //dtpCheckout.Text = get_outdate;
            #region get formated date
            string dcon = dtpCheckin.Text;
            DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            string getindate = dt.ToString("yyyy/MM/dd");
            //
            string dcon2 = dtpCheckout.Text;
            DateTime dt2 = DateTime.ParseExact(dcon2, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            string getoutdate = dt2.ToString("yyyy/MM/dd") + " 00:00:00.000";// HH:mm:ss.fff");
            #endregion get formated date
            conloadr = new SqlConnection(csh);
            cmdloadr = null;
            try
            {
                lstvRoom.Items.Clear();
                cmdloadr = new SqlCommand("select * from operational_room where isIssuable='True' AND m_del='0' AND date BETWEEN '" + getindate + "' AND '" + getoutdate + "' AND room_no='"+rno+"' ORDER BY room_no", conloadr);
                conloadr.Open();
                rdrloadr = cmdloadr.ExecuteReader();
                while (rdrloadr.Read() == true)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add((string)rdrloadr["room_no"]);
                    lst.SubItems.Add((((DateTime)rdrloadr["date"]).ToString("dd/MM/yy")) + "-" + (string)rdrloadr["room_status"]);
                    lst.Text = ((DateTime)rdrloadr["date"]).ToString("dd/MM/yy") + " " + (string)rdrloadr["room_no"] + " Is " + (string)rdrloadr["room_status"];
                    lstvRoom.Items.Add(lst);
                }
                conloadr.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString());
                conloadr.Close();
            }
            formload = true;
        }

        public frmRoomPickup(string acccode, string authcode, string uicode, Boolean getaction,Boolean getedit, string getindate,string getoutdate,Boolean is_Locked,string res_no)
        {
            InitializeComponent();
            acc_code = acccode;
            auth_code = authcode;
            ui_code = uicode;
            get_action = getaction;
            get_edit = getedit;
            get_indate = getindate;
            get_outdate = getoutdate;
            getresno = res_no;
            isLocked = is_Locked;
        }

        public void loadavailableroom()
        {
            #region get formated date
            string dcon = get_indate;
            DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            string getindate = dt.ToString("yyyy/MM/dd");
            //
            string dcon2 = get_outdate;
            DateTime dt2 = DateTime.ParseExact(dcon2, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            string getoutdate = dt2.ToString("yyyy/MM/dd");
            #endregion get formated date
            conloadr = new SqlConnection(csh);
            cmdloadr = null;
            try
            {
                cmdloadr = new SqlCommand("select * from operational_room where isIssuable='True' AND m_del='0' AND date BETWEEN '"+getindate+"' AND '"+getoutdate+"' ORDER BY room_no", conloadr);
                conloadr.Open();
                rdrloadr = cmdloadr.ExecuteReader();
                while (rdrloadr.Read()==true)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add((string)rdrloadr["room_no"]);
                    lst.SubItems.Add((((DateTime)rdrloadr["date"]).ToString("dd/MM/yy"))+"-"+(string)rdrloadr["room_status"]);
                    lst.Text = ((DateTime)rdrloadr["date"]).ToString("dd/MM/yy") + " " + (string)rdrloadr["room_no"]+" Is "+ (string)rdrloadr["room_status"];
                    lstvRoom.Items.Add(lst);
                }
                conloadr.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString());
                conloadr.Close();
            }
        }

        public void loadrooms()
        {
            conloadr = new SqlConnection(csh);
            cmdloadr = null;
            try
            {
                cmdloadr = new SqlCommand("select * from room_mast where m_del='0'", conloadr);
                conloadr.Open();
                rdrloadr = cmdloadr.ExecuteReader();
                while (rdrloadr.Read()==true)
                {
                    cboxrno.Items.Add((string)rdrloadr["rno"]);
                }
                conloadr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadr.Close();
            }
        }

        private void frmRoomPickup_Load(object sender, EventArgs e)
        {
            formload = false;
            #region load date & time
            dtpCheckin.CustomFormat = "dd/MM/yy hh:mm tt";
            dtpCheckin.Format = DateTimePickerFormat.Custom;
            dtpCheckout.CustomFormat = "dd/MM/yy hh:mm tt";
            dtpCheckout.Format = DateTimePickerFormat.Custom;
            dtpCheckin.Text = get_indate;
            dtpCheckout.Text = get_outdate;
            #endregion load date & Time
            loadavailableroom();
            if (get_edit == false)
            {
                #region add new room settings

                #endregion add new room settings
            }
            else
            {
                #region edit room settings

                #endregion edit room settings
            }
            //
            user_action = false;
            if (get_action == true)
            {
                dtpCheckin.Enabled = true;
                dtpCheckout.Enabled = true;
            }
            else if (get_action == false)
            {
                dtpCheckin.Enabled = true;
                dtpCheckout.Enabled = true;
            }
            #region load rooms with status

            #endregion   load rooms with status
            #region get reservation basic info
            congetres = new SqlConnection(csh);
            cmdgetres = null;
            try
            {
                cmdgetres = new SqlCommand("select * from reservation_static where m_del='0' AND res_no='" + getresno + "'", congetres);
                congetres.Open();
                rdrgetres = cmdgetres.ExecuteReader();
                rdrgetres.Read();
                {
                    resdate = ((DateTime)rdrgetres["res_date"]).ToString("dd/MM/yy hh:mm tt");
                    txtbfname.Text = ((string)rdrgetres["fname"]) + " " + ((string)rdrgetres["lname"]);
                    txtbphone.Text = ((string)rdrgetres["contact"]);
                    txtbaddress.Text = ((string)rdrgetres["address"]);
                    cboxCNIC.Text = ((string)rdrgetres["idcard"]);
                    //
                    if ((Boolean)rdrgetres["IsCheckedIn"] == true)
                    {
                        res_isChecked = true;
                        dtpCheckin.Enabled = false;
                        cboxaction.Text = "Check In";
                        cboxaction.Enabled = false;
                    }
                    else if ((Boolean)rdrgetres["IsCheckedIn"] == false)
                    {
                        dtpCheckin.Enabled = true;
                        res_isChecked = false;
                        cboxaction.Text = "Reservation";
                        cboxaction.Enabled = false;
                    }
                }
                congetres.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                congetres.Close();
            }
            #endregion get reservation basic info
            #region load rooms all
            loadrooms();
            #endregion load rooms all
            formload = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region make sure required fields
            if (lstvRoom.Items.Count < 1 || lstvRoom.CheckedIndices.Count < 1)
            {
                MetroMessageBox.Show(this, "Please select atlease one room OR press Cancel buton.");
                return;
            }
            if (cboxrno.Text == "")
            {
                MetroMessageBox.Show(this, "Please select room OR press Cancel buton.");
                return;
            }
            if (txtbRate.Text == "" || txtbRate.Text == "0" || txtbRate.Text == "0.0" || txtbRate.Text == "0.00")
            {
                MetroMessageBox.Show(this, "Kindly Enter Rate / PerDay. Must be Greater than Zero 0.");
                return;
            }
            #endregion make sure required fiels

            #region get formated date
            string dcon = dtpCheckin.Text;
            DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            checkinDate = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");
            //
            string dcon2 = dtpCheckout.Text;
            DateTime dt2 = DateTime.ParseExact(dcon2, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            checkoutDate = dt2.ToString("yyyy/MM/dd HH:mm:ss.fff");
            //
            string dcon3 = resdate;
            DateTime dt3 = DateTime.ParseExact(dcon3, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            resdate = dt3.ToString("yyyy/MM/dd HH:mm:ss.fff");

            #endregion get formated date
            user_action = true;
            var abc = lstvRoom.CheckedIndices;
            foreach (var item in abc)
            {
                #region get restaurant id from room
                getrestaurantid(lstvRoom.Items[Convert.ToInt32(item)].SubItems[1].Text);
                #endregion get restaurant id from room
                if (res_isChecked == true)
                {
                    #region update restarutant struct
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
                        MessageBox.Show(ex.ToString());
                        conupdres.Close();
                    }
                    #endregion update restaurant struct
                    #region update operational database
                    conupdres = null;
                    conupdres = new SqlConnection(csh);
                    cmdupdres = null;
                    try
                    {   //MM/dd/yyyy HH:mm:ss.fff
                        cmdupdres = new SqlCommand("update operational_room set room_status='Reserved' , isIssuable='False' , isCheckedIn='" + res_isChecked + "' , current_refno='" + getresno + "' where room_no='" + lstvRoom.Items[Convert.ToInt32(item)].SubItems[1].Text + "' AND date BETWEEN '" + Convert.ToDateTime(checkinDate).ToString("yyyy/MM/dd") + "' AND '" + Convert.ToDateTime(checkoutDate).ToString("yyyy/MM/dd") + "'", conupdres);
                        conupdres.Open();
                        cmdupdres.ExecuteNonQuery();
                        conupdres.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conupdres.Close();
                    }
                    #endregion update operational database
                }
                else
                {
                    #region update operational database
                    string datetrimin = Convert.ToDateTime(checkinDate).ToString("yyyy/MM/dd ");
                    string outtime = "14:00:00.000";
                    string datetrimout = Convert.ToDateTime(checkoutDate).ToString("yyyy/MM/dd ");

                    conupdres = null;
                    conupdres = new SqlConnection(csh);
                    cmdupdres = null;
                    try
                    {
                        cmdupdres = new SqlCommand("update operational_room set room_status='Reserved' , isIssuable='False' , isCheckedIn='" + res_isChecked + "' , current_refno='" + getresno + "' where room_no='" + lstvRoom.Items[Convert.ToInt32(item)].SubItems[1].Text + "' AND date BETWEEN '" + Convert.ToDateTime(datetrimin + outtime).ToString("yyyy/MM/dd HH:mm:ss.fff") + "' AND '" + Convert.ToDateTime(datetrimout).AddDays(+0).ToString("yyyy/MM/dd HH:mm:ss.fff") + "'", conupdres);
                        conupdres.Open();
                        cmdupdres.ExecuteNonQuery();
                        conupdres.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conupdres.Close();
                    }
                    #endregion update operational database
                }
                //this.Close();
            }
            #region get res det
            inrcini detinsert = new inrcini();
            try
            {
                detinsert.insert_reservation_det(getresno, resdate, res_isChecked,false,isCancel, checkinDate, checkoutDate, cboxrno.Text, txtbfname.Text, cboxCNIC.Text, txtbphone.Text,txtbaddress.Text, Convert.ToDecimal(txtbRate.Text), Convert.ToInt32(lblnodays.Text),0, isLocked, ui_code, "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(detinsert.errorcode + ex.ToString());
            }
            #endregion get res det
            this.Close();
        }

        public void getrestaurantid(string rno)
        {
            room_restaurantid = "";
            conchkresid = new SqlConnection(csh);
            cmdchkresid = null;
            try
            {
                cmdchkresid = new SqlCommand("select * from room_mast where m_del='0' AND rno='"+rno+"'", conchkresid);
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            user_action = false;
            this.Close();
        }

    }
}
