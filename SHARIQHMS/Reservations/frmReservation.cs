using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using logClass;
using inrClass;
using System.Data.SqlClient;
using MetroFramework.Interfaces;
using MetroFramework;
using System.Globalization;
using cbmprocessor;
using nDate;

namespace SHARIQHMS.Reservations
{
    public partial class frmReservation : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        //
        SqlConnection conloadmeals = null;
        SqlCommand cmdloadmeals = null;
        SqlDataReader rdrloadmeals = null;
        //
        SqlConnection conloadchkroom = null;
        SqlCommand cmdloadchkroom = null;
        SqlDataReader rdrloadchkroom = null;
        //
        SqlConnection conloadreservation = null;
        SqlCommand cmdloadreservation = null;
        SqlDataReader rdrloadreservation = null;
        //
        SqlConnection conchk = null;
        SqlCommand cmdchk = null;
        SqlDataReader rdrchk = null;
        //
        SqlConnection conloadr = null;
        SqlCommand cmdloadr = null;
        SqlDataReader rdrloadr = null;
        //
        SqlConnection conloadcust = null;
        SqlCommand cmdloadcust = null;
        SqlDataReader rdrloadcust = null;
        //
        SqlConnection concount = null;
        SqlCommand cmdcount = null;
        SqlDataReader rdrcount = null;
        //
        SqlConnection conloadstatic = null;
        SqlCommand cmdloadstatic = null;
        SqlDataReader rdrloadstatic = null;
        //
        SqlConnection conloadrooms = null;
        SqlCommand cmdloadrooms = null;
        SqlDataReader rdrloadrooms = null;
        //
        SqlConnection conloadser = null;
        SqlCommand cmdloadser = null;
        SqlDataReader rdrloadser = null;
        //
        SqlConnection conupdstatic = null;
        SqlCommand cmdupdstatic = null;
        //
        SqlConnection conupdop = null;
        SqlCommand cmdupdop = null;
        //
        SqlConnection conupddet = null;
        SqlCommand cmdupddet = null;
        //
        SqlConnection conupdserdet = null;
        SqlCommand cmdupdserdet = null;
        //
        SqlConnection conupdafterchecked = null;
        SqlCommand cmdupdafterchecked = null;
        //
        SqlConnection conupdmeals = null;
        SqlCommand cmdupdmeals = null;
        #endregion Database string and connection
        Boolean IsLocked = false;
        Boolean isReservation = false;
        Boolean isCheckedin = false;
        Boolean isConfirm = false;
        // room add edit delete functions
        Boolean foredit = false;
        Boolean foraction = false;
        Boolean IsMale = false;
        Boolean isCancel = false;
        Boolean fload = false;
        Boolean ctag = false;
        Boolean umeter = false;
        Boolean isCheckedout = false;
        decimal mealstotal = 0;
        string restaurantid;
        int rescount = 0;
        string acc_code, user_name, nowdate, checkoutDate, checkinDate, ui_code, auth_code, usr_action, ref_code, res_date, rettype;

        public frmReservation(string acccode, string authcode, string uicode, string username, string action,string refcode)
        {
            InitializeComponent();
            acc_code = acccode;
            auth_code = authcode;
            ui_code = uicode;
            user_name = username;
            auth_code = authcode;
            usr_action = action;
            ref_code = refcode;
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            ctag = true;
            loadreservations();
            loadcust();
            loadroomsno();
            #region action implement
            if (usr_action == "New Reservation")
            {
                // load as per new reservation or fresh
                isReservation = true;
                isCheckedin = false;
                isCancel = false;
                //
                #region load date & time
                nowdate = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
                dtpCheckin.CustomFormat = "dd/MM/yy hh:mm tt";
                dtpCheckin.Format = DateTimePickerFormat.Custom;
                dtpCheckin.Text = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
                dtpCheckout.CustomFormat = "dd/MM/yy hh:mm tt";
                dtpCheckout.Format = DateTimePickerFormat.Custom;
                nowd nd = new nowd();
                nd.nowdate();
                dtpCheckout.Text = nd.dateout.ToString("dd/MM/yy hh:mm tt");
                #endregion load date & Time
            }
            else if (usr_action == "Reservation" || usr_action == "Checkin" || usr_action == "Checkout" || usr_action == "Cancel" && usr_action!="New Reservation")
            {
                if (ref_code == "")
                { MessageBox.Show("SYSTEM_LOAD_ERR_1");}
                else {
                    // load reservation number
                    cboxrefno.Text = ref_code;
                    #region loadstatic det ser
                    fload = false;
                    //isCancel = false;
                    //isCheckedin = false;
                    //isReservation = false;
                    //loadstatic();
                    //loadrooms();
                    //loadservice();
                    //if (isCancel == true)
                    //{
                    //    MetroMessageBox.Show(this, "This selected reservation (" + cboxrefno.Text + ") is Canceled");
                    //    cboxaction.Text = "Cancel";
                    //}
                    //else
                    //{
                    //    btnNewReservation.Text = "&Close";
                    //    EnableComboBoxes(this.Controls);
                    //    Enabledtp(this.Controls);
                    //    EnableTextBoxes(this.Controls);
                    //    cboxrefno.Enabled = false;
                    //    txtbRemarks.ReadOnly = false;
                    //    btnAddRoom.Enabled = true;
                    //    btnRoomEdit.Enabled = true;
                    //    btnRoomDel.Enabled = true;
                    //    btnServiceAdd.Enabled = true;
                    //    btnServiceEdit.Enabled = true;
                    //    btnServiceDel.Enabled = true;
                    //    txtbAdvance.Enabled = true;
                    //    txtbReceivedTotal.Enabled = true;
                    //    txtbDiscount.Enabled = true;
                    //}
                    fload = true;
                    #endregion loadstatic det ser
                }
            }
            #endregion action implement
            #region load date & time
            nowdate = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            dtpCheckin.CustomFormat = "dd/MM/yy hh:mm tt";
            dtpCheckin.Format = DateTimePickerFormat.Custom;
            dtpCheckin.Text = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            dtpCheckout.CustomFormat = "dd/MM/yy hh:mm tt";
            dtpCheckout.Format = DateTimePickerFormat.Custom;
            //nowd nd = new nowd();
            //nd.nowdate();
            //dtpCheckout.Text = nd.dateout.ToString("dd/MM/yy hh:mm tt");
            #endregion load date & Time
        }

        #region load data events & Counter
        public void getrtype(string rtype)
        {
            conchk = new SqlConnection(csh);
            cmdchk = null;
            try
            {
                cmdchk = new SqlCommand("select * from room_mast where m_del='0' AND rno='" + rtype + "'", conchk);
                conchk.Open();
                rdrchk = cmdchk.ExecuteReader();
                rdrchk.Read();
                {
                    rettype = ((string)rdrchk["rcat"]);
                    restaurantid = ((string)rdrchk["resint"]);
                }
                conchk.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conchk.Close();
            }
        }

        public void insertreservationstatic()
        {
            countreservation();
            res_date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
            #region get formated date
            string dcon = dtpCheckin.Text;
            DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            checkinDate = dt.ToString("MM/dd/yyyy HH:mm:ss.fff");
            //
            string dcon2 = dtpCheckout.Text;
            DateTime dt2 = DateTime.ParseExact(dcon2, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
            checkoutDate = dt2.ToString("MM/dd/yyyy HH:mm:ss.fff");
            #endregion get formated date
            // get date of now
            //string curdate = DateTime.Now.ToString("yyMMdd");
            string curdate = DateTime.Now.ToString("MMdd");
            string finalresno = curdate + rescount;
            cboxrefno.Text = finalresno;
            inrcini insres = new inrcini();
            if (cboxgender.Text == "Male")
            {
                IsMale = true;
            }
            if (cboxaction.Text == "Reservation" || cboxaction.Text == "" && isCancel == false)
            {
                isCheckedin = false;
                isConfirm = false;
                isReservation = true;
                isCancel = false;
            }
            IsLocked = false;
            // // //
            try
            {
                insres.insert_reservation_static(DateTime.Now.ToString("MMdd") + rescount, cboxaction.Text, res_date, isCheckedin,isCheckedout, isConfirm, isCancel, cboxaction.Text, txtbpromo.Text, checkinDate, checkoutDate, txtbcname.Text, txtbfname.Text, txtblname.Text, txtbphone.Text, txtbfaminfo.Text, IsMale, cboxNationality.Text, cboxCNIC.Text, txtbaddress.Text, 0, 0, 0, 0, 0, 0, 0, txtbRemarks.Text, IsLocked, ui_code, "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(insres.errorcode + ex.ToString());
                return;
            }
            cboxrefno.Items.Add(finalresno);
        }

        public void cancelation(string referno)
        {
            if (isCheckedin == false) // cross check
            {
                #region update operational rooms
                conupdop = new SqlConnection(csh);
                cmdupdop = null;
                try
                {
                    cmdupdop = new SqlCommand("update operational_room set room_status='Ready' , isIssuable='True' , current_refno='' where current_refno='" + referno + "' AND m_del='0'", conupdop);
                    conupdop.Open();
                    cmdupdop.ExecuteNonQuery();
                    conupdop.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conupdop.Close();
                }
                #endregion update operational rooms
                #region update static
                conupdstatic = new SqlConnection(csh);
                cmdupdstatic = null;
                try
                {
                    cmdupdstatic = new SqlCommand("update reservation_static set isCancel='True' , res_type='Cancel' , res_status='Cancel'  where res_no='" + referno + "' AND m_del='0'", conupdstatic);
                    conupdstatic.Open();
                    cmdupdstatic.ExecuteNonQuery();
                    conupdstatic.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conupdstatic.Close();
                }
                #endregion update static
                #region update det
                conupddet = new SqlConnection(csh);
                cmdupddet = null;
                try
                {
                    cmdupddet = new SqlCommand("update reservation_det set isCancel='True' where res_no='" + referno + "' AND m_del='0'", conupddet);
                    conupddet.Open();
                    cmdupddet.ExecuteNonQuery();
                    conupddet.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conupddet.Close();
                }
                #endregion update det
                #region update serdet
                conupdserdet = new SqlConnection(csh);
                cmdupdserdet = null;
                try
                {
                    cmdupdserdet = new SqlCommand("update reservation_serdet set isCancel='True' where res_no='" + referno + "' AND m_del='0'", conupdserdet);
                    conupdserdet.Open();
                    cmdupdserdet.ExecuteNonQuery();
                    conupdserdet.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conupdserdet.Close();
                }
                #endregion update serdet
            }
            else { MessageBox.Show("Unexpeceted Error..!\nChecked In DocFound"); }
        }

        public void loadstatic()
        {
            conloadstatic = new SqlConnection(csh);
            cmdloadstatic = null;
            try
            {
                cmdloadstatic = new SqlCommand("select * from reservation_static where m_del='0' AND res_no='" + cboxrefno.Text + "'", conloadstatic);
                conloadstatic.Open();
                rdrloadstatic = cmdloadstatic.ExecuteReader();
                rdrloadstatic.Read();
                {
                    #region load dates
                    dtpCheckin.Text = ((DateTime)rdrloadstatic["checkin_date"]).ToString("dd/MM/yy hh:mm tt");
                    dtpCheckout.Text = ((DateTime)rdrloadstatic["checkout_date"]).ToString("dd/MM/yy hh:mm tt");
                    res_date = ((DateTime)rdrloadstatic["res_date"]).ToString("dd/MM/yy hh:mm tt");
                    #endregion load dates
                    #region load reservation
                    txtbcname.Text = ((string)rdrloadstatic["cname"]);
                    txtbfname.Text = ((string)rdrloadstatic["fname"]);
                    txtblname.Text = ((string)rdrloadstatic["lname"]);
                    txtbphone.Text = ((string)rdrloadstatic["contact"]);
                    txtbfaminfo.Text = ((string)rdrloadstatic["faminfo"]);
                    IsMale = (Boolean)rdrloadstatic["isMale"];
                    isCancel = (Boolean)rdrloadstatic["isCancel"];
                    txtbaddress.Text = ((string)rdrloadstatic["address"]);
                    if (IsMale == true)
                    {
                        cboxgender.Text = "Male";
                    }
                    else
                    {
                        cboxgender.Text = "Female";
                    }
                    cboxNationality.Text = ((string)rdrloadstatic["cnationality"]);
                    cboxCNIC.Text = ((string)rdrloadstatic["idcard"]);
                    txtbRemarks.Text = ((string)rdrloadstatic["remarks"]);
                    txtbRoomTotal.Text = ((Int32)rdrloadstatic["rooms_tot"]).ToString();
                    txtbMealsTotal.Text = ((decimal)rdrloadstatic["meals_tot"]).ToString();
                    txtbAdvance.Text = ((decimal)rdrloadstatic["advanced"]).ToString();
                    txtbServiceTotal.Text = ((decimal)rdrloadstatic["services_tot"]).ToString();
                    txtbGrandTotal.Text = ((decimal)rdrloadstatic["bill_total"]).ToString();
                    txtbReceivedTotal.Text = ((decimal)rdrloadstatic["received_amount"]).ToString();
                    txtbDiscount.Text = ((decimal)rdrloadstatic["discount"]).ToString();
                    IsLocked = (Boolean)rdrloadstatic["islocked"];
                    if (IsLocked == true)
                    {
                        btnUpdateReservation.Enabled = false;
                        btnCheckOut.Enabled = false;
                    }
                    else
                    {
                        btnUpdateReservation.Enabled = true;
                        btnCheckOut.Enabled = true;
                    }
                    isCheckedin = (Boolean)rdrloadstatic["isCheckedIn"];
                    isCheckedout = (Boolean)rdrloadstatic["isCheckedout"];
                    if (isCheckedin == true && isCheckedout == false)
                    {
                        btnCheckOut.Text = "Check Out !";
                        dtpCheckin.Enabled = false;
                    }
                    else if (isCheckedin==false && isCheckedout == true)
                    {
                        btnCheckOut.Text = "Check Out !";
                        cboxaction.Text = "Check Out";
                        dtpCheckin.Enabled = true;
                    }
                    else if (isCheckedin == false && isCheckedout == false)
                    {
                        btnCheckOut.Text = "Check In !";
                        dtpCheckin.Enabled = false;
                    }
                    //
                    if (isCancel == true)
                    {
                        cboxaction.Text = "Cancel";
                        cboxaction.Enabled = false;
                    }
                    else
                    {
                        cboxaction.Text = ((string)rdrloadstatic["res_type"]);
                        cboxaction.Enabled = true;
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

        public void loadmealssum(string rno)
        {
            mealstotal = 0;
            conloadmeals = new SqlConnection(csr);
            cmdloadmeals = null;
            try
            {
                cmdloadmeals = new SqlCommand("select tables.name AS name,Tables.id AS tableid,tickets.TotalAmount AS totalamount,tickets.TicketNumber AS ticketsno , tickets.LocationName as locationname from Tables INNER JOIN tickets on Tables.Name=tickets.LocationName where tables.id='" + restaurantid + "'", conloadmeals);
                conloadmeals.Open();
                rdrloadmeals = cmdloadmeals.ExecuteReader();
                while (rdrloadmeals.Read() == true)
                {
                    mealstotal += ((decimal)rdrloadmeals["totalamount"]);
                }
                conloadmeals.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                mealstotal = 0;
                conloadmeals.Close();
            }
        }

        public void updatemealssum(int id, decimal m)
        {
            conupdmeals = new SqlConnection(csh);
            cmdupdmeals = null;
            try
            {
                cmdupdmeals = new SqlCommand("update reservation_det set room_meals="+m+" where id='"+id+"'", conupdmeals);
                conupdmeals.Open();
                cmdupdmeals.ExecuteNonQuery();
                conupdmeals.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conupdmeals.Close();
            }
        }

        public void loadrooms()
        {
            lstvRoom.Items.Clear();
            conloadrooms = new SqlConnection(csh);
            cmdloadrooms = null;
            try
            {
                cmdloadrooms = new SqlCommand("select * from reservation_det where m_del='0' AND res_no='" + cboxrefno.Text + "'", conloadrooms);
                conloadrooms.Open();
                rdrloadrooms = cmdloadrooms.ExecuteReader();
                while (rdrloadrooms.Read() == true)
                {
                    string rcheckinDate = Convert.ToString(((DateTime)rdrloadrooms["rcheckin_date"]).ToString("dd/MM/yy hh:mm tt"));
                    string rcheckoutDate = Convert.ToString(((DateTime)rdrloadrooms["rcheckout_date"]).ToString("dd/MM/yy hh:mm tt"));
                    getrtype((string)rdrloadrooms["room_no"]);
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add((string)rdrloadrooms["room_no"]);
                    lst.SubItems.Add(rettype);
                    lst.SubItems.Add((string)rdrloadrooms["rguestname"]);
                    lst.SubItems.Add((string)rdrloadrooms["rguestidcard"]);
                    lst.SubItems.Add((string)rdrloadrooms["rguestphone"]);
                    lst.SubItems.Add(rcheckinDate);
                    lst.SubItems.Add(rcheckoutDate);
                    lst.SubItems.Add(((decimal)rdrloadrooms["rdayrate"]).ToString());
                    lst.SubItems.Add(((Int32)rdrloadrooms["rdays"]).ToString());
                    lst.SubItems.Add((((decimal)rdrloadrooms["rdayrate"]) * (Convert.ToDecimal(((Int32)rdrloadrooms["rdays"])))).ToString());
                    if ((Boolean)rdrloadrooms["isCheckedIn"] == false)
                    {
                        lst.SubItems.Add(((decimal)rdrloadrooms["room_meals"]).ToString());
                    }
                    else
                    {
                        loadmealssum(restaurantid);
                        lst.SubItems.Add(mealstotal.ToString());
                        updatemealssum((Int32)rdrloadrooms["id"], mealstotal);
                    }

                    if ((Boolean)rdrloadrooms["isCheckedIn"] == false && (Boolean)rdrloadrooms["ischeckedout"] == false && (Boolean)rdrloadrooms["isCancel"] == false)
                    {
                        lst.SubItems.Add("Reserved");
                    }
                    else if ((Boolean)rdrloadrooms["isCheckedIn"] == true && (Boolean)rdrloadrooms["ischeckedout"] == false && (Boolean)rdrloadrooms["isCancel"] == false)
                    {
                        lst.SubItems.Add("Checked In");
                    }
                    else if ((Boolean)rdrloadrooms["isCheckedIn"] == false && (Boolean)rdrloadrooms["ischeckedout"] == true && (Boolean)rdrloadrooms["isCancel"] == false)
                    {
                        lst.SubItems.Add("Checked out");
                    }
                    lstvRoom.Items.Add(lst);
                }
                conloadrooms.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadrooms.Close();
            }
            txtbMealsTotal.Text = amttotmeals().ToString();
            txtbRoomTotal.Text = amttotroom().ToString();
            //roomcount();
        }

        public void loadservice()
        {
            lstvService.Items.Clear();
            conloadser = new SqlConnection(csh);
            cmdloadser = null;
            try
            {
                cmdloadser = new SqlCommand("select * from reservation_serdet where m_del='0' AND res_no='" + cboxrefno.Text + "'", conloadser);
                conloadser.Open();
                rdrloadser = cmdloadser.ExecuteReader();
                while (rdrloadser.Read() == true)
                {
                    ListViewItem lstservice = new ListViewItem();
                    lstservice.SubItems.Add((string)rdrloadser["services_desc"]);
                    lstservice.SubItems.Add(((DateTime)rdrloadser["ser_date"]).ToString("dd/MM/yy hh:mm tt"));
                    lstservice.SubItems.Add(((decimal)rdrloadser["serRate"]).ToString());
                    lstservice.SubItems.Add(((Int32)rdrloadser["serQty"]).ToString());
                    lstservice.SubItems.Add(Convert.ToString((decimal)rdrloadser["serRate"] * Convert.ToDecimal(((Int32)rdrloadser["serQty"]))));
                    lstservice.SubItems.Add((string)rdrloadser["room_no"]);
                    lstvService.Items.Add(lstservice);
                }
                conloadser.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadser.Close();
            }
            txtbServiceTotal.Text = amttotser().ToString();
        }

        public void loadroomsno()
        {
            conloadr = new SqlConnection(csh);
            cmdloadr = null;
            try
            {
                cmdloadr = new SqlCommand("select * from reservation_det where m_del='0' AND res_no='" + cboxrefno.Text + "'", conloadr);
                conloadr.Open();
                rdrloadr = cmdloadr.ExecuteReader();
                while (rdrloadr.Read() == true)
                {
                    cboxrno.Items.Add((string)rdrloadr["room_no"]);
                }
                conloadr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadr.Close();
            }
        }

        public void loadreservations()
        {
            cboxrefno.Items.Clear();
            conloadreservation = new SqlConnection(csh);
            cmdloadreservation = null;
            try
            {
                cmdloadreservation = new SqlCommand("select res_no from reservation_static WHERE m_del='0' ORDER BY id", conloadreservation);
                conloadreservation.Open();
                rdrloadreservation = cmdloadreservation.ExecuteReader();
                while (rdrloadreservation.Read() == true)
                {
                    cboxrefno.Items.Add((string)rdrloadreservation["res_no"]);
                }
                conloadreservation.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadreservation.Close();
            }
        }

        public void loadcust()
        {
            cboxCNIC.Items.Clear();
            cboxNationality.Items.Clear();
            conloadcust = new SqlConnection(csh);
            cmdloadcust = null;
            try
            {
                cmdloadcust = new SqlCommand("select custid,nationality from cust_mast WHERE m_del='0'", conloadcust);
                conloadcust.Open();
                rdrloadcust = cmdloadcust.ExecuteReader();
                while (rdrloadcust.Read() == true)
                {
                    cboxCNIC.Items.Add((string)rdrloadcust["custid"]);
                    cboxNationality.Items.Add((string)rdrloadcust["nationality"]);
                }
                conloadcust.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadcust.Close();
            }
        }

        public void countreservation()
        {
            concount = new SqlConnection(csh);
            cmdcount = null;
            try
            {
                cmdcount = new SqlCommand("select Count(id) AS Count from reservation_static", concount);
                concount.Open();
                rdrcount = cmdcount.ExecuteReader();
                rdrcount.Read();
                {
                    rescount = ((Int32)rdrcount["count"]);
                }
                concount.Close();
                rescount += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                concount.Close();
            }
        }
        #endregion load data events

        #region list view total
        public decimal amttotroom()
        {
            int i = 0;
            decimal j = 0;
            decimal l = 0;
            i = 0;
            j = 0;
            l = 0;
            try
            {
                j = lstvRoom.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    l = l + Convert.ToDecimal(lstvRoom.Items[i].SubItems[10].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return l;
        }

        public decimal amttotmeals()
        {
            int i = 0;
            decimal j = 0;
            decimal l = 0;
            i = 0;
            j = 0;
            l = 0;
            try
            {
                j = lstvRoom.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    l = l + Convert.ToDecimal(lstvRoom.Items[i].SubItems[11].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return l;
        }
        public int roomcount()
        {
            int i = 0;
            int j = 0;
            int l = 0;
            i = 0;
            j = 0;
            l = 0;
            try
            {
                j = lstvRoom.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    l = l + Convert.ToInt32(lstvRoom.Items[i].SubItems[4].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return l;
        }

        public decimal amttotser()
        {
            int i = 0;
            decimal j = 0;
            decimal l = 0;
            i = 0;
            j = 0;
            l = 0;
            try
            {
                j = lstvService.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    l = l + Convert.ToDecimal(lstvService.Items[i].SubItems[5].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return l;
        }
        #endregion list view total

        #region misc working
        // combobox
        private void ClearComboBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                ComboBox tb = ctrl as ComboBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearComboBoxes(ctrl.Controls);
            }
        }
        private void EnableComboBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                ComboBox tb = ctrl as ComboBox;
                if (tb != null)
                    tb.Enabled =true;
                else
                    EnableComboBoxes(ctrl.Controls);
            }
        }
        private void DisableComboBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                ComboBox tb = ctrl as ComboBox;
                if (tb != null)
                    tb.Enabled = false;
                else
                    DisableComboBoxes(ctrl.Controls);
            }
        }
        // textbox
        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }

        private void EnableTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Enabled = true;
                else
                    EnableTextBoxes(ctrl.Controls);
            }
        }

        private void DisableTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Enabled = false;
                else
                    DisableTextBoxes(ctrl.Controls);
            }
        }

        // date time picker
        private void Enabledtp(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                DateTimePicker tb = ctrl as DateTimePicker;
                if (tb != null)
                    tb.Enabled = true;
                else
                    Enabledtp(ctrl.Controls);
            }
        }

        private void disabledtp(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                DateTimePicker tb = ctrl as DateTimePicker;
                if (tb != null)
                    tb.Enabled = false;
                else
                    disabledtp(ctrl.Controls);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //
            if (keyData == (Keys.Control | Keys.S))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    btnUpdateReservation.PerformClick();
                }
            }
            else if (keyData == (Keys.Control | Keys.P))
            {
                btnPrint.PerformClick();
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    btnAddRoom.PerformClick();
                }
            }
            else if (keyData == (Keys.F1))
            {
                cboxrefno.Focus();
                cboxrefno.DroppedDown = true;
            }
            else if (keyData == (Keys.F2))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    txtbcname.Focus();
                }
            }
            else if (keyData == (Keys.F3))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    txtbSerDesc.Focus();
                }
            }
            else if (keyData == (Keys.F4))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    txtbSerDesc.Focus();
                }
            }
            else if (keyData == (Keys.F5))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    btnAddRoom.Focus();
                }
            }
            else if (keyData == (Keys.F6))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    txtbAdvance.Focus();
                }
            }
            else if (keyData == (Keys.F7))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    txtbRemarks.Focus();
                }
            }
            else if (keyData == (Keys.F7))
            {
                if (btnNewReservation.Text == "&New Reservation")
                { }
                else
                {
                    txtbRemarks.Focus();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion misc working

        #region Services and rooms selection operations and customer 
        private void cboxrefno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxrefno.Text != "")
            {
                #region loadstatic det ser
                fload = false;
                isCancel = false;
                isCheckedin = false;
                isReservation = false;
                loadstatic();
                loadrooms();
                loadservice();
                loadroomsno();
                if (isCancel == true)
                {
                    MetroMessageBox.Show(this, "This selected reservation (" + cboxrefno.Text + ") is Canceled");
                    cboxaction.Text = "Cancel";
                }
                else
                {
                    btnNewReservation.Text = "&Close";
                    EnableComboBoxes(this.Controls);
                    Enabledtp(this.Controls);
                    EnableTextBoxes(this.Controls);
                    if (isCheckedin == true)
                    {
                        dtpCheckin.Enabled = false;
                        cboxaction.Text = "Check In";
                        timer1.Enabled = true;
                        umeter = true;
                    }
                    cboxrefno.Enabled = false;
                    txtbRemarks.ReadOnly = false;
                    btnAddRoom.Enabled = true;
                    btnRoomEdit.Enabled = true;
                    btnRoomDel.Enabled = true;
                    btnServiceAdd.Enabled = true;
                    btnServiceEdit.Enabled = true;
                    btnServiceDel.Enabled = true;
                    txtbAdvance.Enabled = true;
                    txtbReceivedTotal.Enabled = true;
                    txtbDiscount.Enabled = true;
                }
                fload = true;
                #endregion loadstatic det ser
            }
        }

        private void cboxaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fload == true)
            {
                if (cboxaction.Text == "Cancel")
                {
                    if (isCancel == true)
                    {

                    }
                    else
                    {
                        DialogResult dialogresult = MessageBox.Show("RESERVATION " + cboxrefno.Text + " Cancel? ", "Are You Sure to cancel reservation no " + cboxrefno.Text + "?", MessageBoxButtons.YesNo);
                        if (dialogresult == DialogResult.Yes)
                        {
                            cancelation(cboxrefno.Text);
                            isCancel = true;
                            btnNewReservation.PerformClick();
                        }
                        else if (dialogresult == DialogResult.No)
                        {

                        }
                    }
                }
            }
            else if (fload == false)
            {

            }
        }

        private void txtbRoomTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow numbers (-) (.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmReservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ctag == false)
            {
                e.Cancel = true;
                MetroMessageBox.Show(this, "STOP !\nPlease Save/Close your working.");
                return;
            }
        }

        private void frmReservation_Enter(object sender, EventArgs e)
        {

        }

        private void pnlCinfo_Enter(object sender, EventArgs e)
        {
            Panel gb = (Panel)sender;
            if (gb.Name == "pnlGinfo" || gb.Name == "pnlCinfo" || gb.Name == "pnlSinfo" || gb.Name == "pnlRinfo" || gb.Name == "pnlPayment" || gb.Name == "pnlRemarks")
            {
                gb.BackColor = Color.LightGray;
            }
        }

        private void pnlGinfo_Leave(object sender, EventArgs e)
        {
            Panel gb = (Panel)sender;
            if (gb.Name == "pnlGinfo" || gb.Name == "pnlCinfo" || gb.Name == "pnlSinfo" || gb.Name == "pnlRinfo" || gb.Name == "pnlPayment" || gb.Name == "pnlRemarks")
            {
                gb.BackColor = Color.Gainsboro;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (isCancel == true)
            {
                MessageBox.Show("Reservation No " + cboxrefno.Text + " is Cancel.");
                return;
            }
            if (isCheckedin == true)
            {
                foraction = true;
            }
            else
            {
                foraction = false;
            }
            foredit = false;
            checkinDate = Convert.ToString(Convert.ToDateTime(dtpCheckin.Text).ToString("dd/MM/yy hh:mm tt"));
            checkoutDate = Convert.ToString(Convert.ToDateTime(dtpCheckout.Text).ToString("dd/MM/yy hh:mm tt"));
            frmRoomPickup frmp = new frmRoomPickup(acc_code, auth_code, ui_code, foraction, foredit, checkinDate, checkoutDate, IsLocked, cboxrefno.Text);
            frmp.ShowDialog();
            if (frmp.user_action == true)
            {
                if (frmp.cboxrno.Text != "")
                {
                    getrtype(frmp.cboxrno.Text);
                }
                else
                {
                    MessageBox.Show("System Error Code RPNULL101" + e.ToString());
                    return;
                }

                //
                conloadrooms = new SqlConnection(csh);
                cmdloadrooms = null;
                try
                {
                    cmdloadrooms = new SqlCommand("select * from reservation_det where m_del='0' AND res_no='" + cboxrefno.Text + "' AND room_no='" + frmp.cboxrno.Text + "'", conloadrooms);
                    conloadrooms.Open();
                    rdrloadrooms = cmdloadrooms.ExecuteReader();
                    while (rdrloadrooms.Read() == true)
                    {
                        string rcheckinDate = Convert.ToString(((DateTime)rdrloadrooms["rcheckin_date"]).ToString("dd/MM/yy hh:mm tt"));
                        string rcheckoutDate = Convert.ToString(((DateTime)rdrloadrooms["rcheckout_date"]).ToString("dd/MM/yy hh:mm tt"));
                        getrtype((string)rdrloadrooms["room_no"]);
                        ListViewItem lst = new ListViewItem();
                        lst.SubItems.Add((string)rdrloadrooms["room_no"]);
                        lst.SubItems.Add(rettype);
                        lst.SubItems.Add((string)rdrloadrooms["rguestname"]);
                        lst.SubItems.Add((string)rdrloadrooms["rguestidcard"]);
                        lst.SubItems.Add((string)rdrloadrooms["rguestphone"]);
                        lst.SubItems.Add(rcheckinDate);
                        lst.SubItems.Add(rcheckoutDate);
                        lst.SubItems.Add(((decimal)rdrloadrooms["rdayrate"]).ToString());
                        lst.SubItems.Add(((Int32)rdrloadrooms["rdays"]).ToString());
                        lst.SubItems.Add((((decimal)rdrloadrooms["rdayrate"]) * (Convert.ToDecimal(((Int32)rdrloadrooms["rdays"])))).ToString());
                        lst.SubItems.Add(((decimal)rdrloadrooms["room_meals"]).ToString());
                        if ((Boolean)rdrloadrooms["isCheckedIn"] == false)
                        {
                            lst.SubItems.Add("Reserved");
                        }
                        else
                        {
                            lst.SubItems.Add("Checked In");
                        }
                        lstvRoom.Items.Add(lst);
                    }
                    conloadrooms.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conloadrooms.Close();
                }
                txtbMealsTotal.Text = amttotmeals().ToString();
                txtbRoomTotal.Text = amttotroom().ToString();
                //roomcount();

            }
            else if (frmp.user_action == false)
            {
                MetroMessageBox.Show(this, "You have press Cancel");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (umeter == true)
            {
                dtpCheckout.Text = DateTime.Now.ToString("dd/MM/yy hh:mm tt");
            }
            
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            if (btnNewReservation.Text == "&Close")
            {
                nowd nd = new nowd();
                nd.seldate(dtpCheckin.Value);
                dtpCheckout.Text = nd.dateout.ToString("dd/MM/yy hh:mm tt");
            }
        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            if (btnNewReservation.Text == "&Close")
            {
                if (isCheckedin == false)
                {
                    checkoutDate = Convert.ToString(Convert.ToDateTime(dtpCheckout.Text).ToString("dd/MM/yy hh:mm tt"));
                    cbmprocessor.cbmprocessor cbm = new cbmprocessor.cbmprocessor();
                    cbm.daycounter(dtpCheckin.Value, dtpCheckout.Value);
                    lblnodays.Text = cbm.days.ToString();
                }
            }
        }

        private void btnRoomEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Update Software");
        }

        private void btnRoomDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Update Software");
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Update Software");
        }

        private void btnFindCust_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Update Software");
        }
        #endregion Services and rooms selection operations and customer 

        #region buttons
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ctag == false)
            {
                MetroMessageBox.Show(this, "STOP !\nPlease Save/Close your working.");
                return;
            }
            else if (ctag == true)
            {
                this.Close();
            }
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (isReservation == true || isCancel == true || isCheckedin == false)
            {
                MetroMessageBox.Show(this, "Reservation No " + cboxrefno.Text + " is not checkedin yet.\nUnable to add services, or addon's.");
            }
            else if (isCheckedin == true && isCancel == false)
            {
                #region check for requried fields
                if (txtbSerDesc.Text == "") { MetroMessageBox.Show(this, "Kindly Enter Description."); return; }
                if (txtbSerQty.Text == "" || txtbSerQty.Text == "0") { MetroMessageBox.Show(this, "Kindly Enter Quantity Greater than 0."); return; }
                if (txtbSerRate.Text == "" || txtbSerRate.Text == "0") { MetroMessageBox.Show(this, "Kindly Enter Rate Greater than 0."); return; }
                if (cboxrno.Text == "") { MetroMessageBox.Show(this, "Kindly select Room."); return; }
                #endregion check for required fields
                inrcini ins = new inrcini();
                try
                {
                    ins.insert_reservation_serdet(cboxrefno.Text, isCancel, Convert.ToDateTime(res_date).ToString("yyyy/MM/dd HH:mm:ss.fff"), Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")), cboxrno.Text, txtbSerDesc.Text, Convert.ToDecimal(txtbSerRate.Text), Convert.ToInt32(txtbSerQty.Text), ui_code, "0");
                }
                catch (Exception)
                {
                    MessageBox.Show("SerIns" + ins.errorcode.ToString());
                    return;
                }
                ListViewItem lsti = new ListViewItem();
                lsti.SubItems.Add(txtbSerDesc.Text);
                lsti.SubItems.Add(Convert.ToString(DateTime.Now.ToString("dd/MM/yy hh:mm tt")));
                lsti.SubItems.Add(txtbSerRate.Text);
                lsti.SubItems.Add(txtbSerQty.Text);
                lsti.SubItems.Add(Convert.ToString(Convert.ToDecimal(txtbSerRate.Text) * Convert.ToDecimal(txtbSerQty.Text)));
                lsti.SubItems.Add(cboxrno.Text);
                lstvService.Items.Add(lsti);
                txtbServiceTotal.Text = amttotser().ToString();
            }
        }

        private void btnServiceEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Update Software");
        }

        private void btnServiceDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Update Software");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (btnCheckOut.Text == "Check In !")
            {
                #region Check list before CheckedIn
                if (isCancel == true) { MetroMessageBox.Show(this, "Reservation Cancelled:\n Kindly Create new reservation."); return; }
                if (isCheckedin == true) { MetroMessageBox.Show(this, "Unexpected Error RES-CHIN"); return; }
                if (txtbfname.Text == "" || txtbfaminfo.Text == "" || cboxCNIC.Text == "" || cboxNationality.Text == "") { MetroMessageBox.Show(this, "Kindly proivde complete information of Customer."); return; }
                if (lstvRoom.Items.Count < 1) { MetroMessageBox.Show(this, "Kindly select atleast one room."); return; }
                if (btnNewReservation.Text != "&Close") { MetroMessageBox.Show(this, "Kindly Select or Enter reservation no."); return; }
                if (cboxrefno.Text == "") { MetroMessageBox.Show(this, "Kindly Select provide reservation no."); }
                #endregion Check list before CheckedIn
                btnUpdateReservation.PerformClick();
                frmCheckinDialog frmchking = new frmCheckinDialog(cboxrefno.Text);
                frmchking.ShowDialog();
                if (frmchking.actioncancel == true)
                {
                    // do nothing //
                }
                else if (frmchking.actioncancel == false)
                {
                    isCheckedin = true;
                    isReservation = false;
                    isCancel = false;
                    dtpCheckin.Text = frmchking.checkedindatetime;
                    timer1.Enabled = true;
                    umeter = true;
                    btnCheckOut.Text = "Check Out !";
                }
            }
            else if (btnCheckOut.Text == "Check Out !")
            {
                // check out goest here
                if (isCheckedin==true && cboxrefno.Text != "" & isCancel!=true)
                {
                    #region Check list before CheckedIn
                    if (isCancel == true) { MetroMessageBox.Show(this, "Reservation Cancelled:\n Kindly Create new reservation."); return; }
                    if (txtbfname.Text == "" || txtbfaminfo.Text == "" || cboxCNIC.Text == "" || cboxNationality.Text == "") { MetroMessageBox.Show(this, "Kindly proivde complete information of Customer."); return; }
                    if (lstvRoom.Items.Count < 1) { MetroMessageBox.Show(this, "Kindly select atleast one room."); return; }
                    if (btnNewReservation.Text != "&Close") { MetroMessageBox.Show(this, "Kindly Select or Enter reservation no."); return; }
                    if (cboxrefno.Text == "") { MetroMessageBox.Show(this, "Kindly Select provide reservation no."); }
                    #endregion Check list before CheckedIn
                    btnUpdateReservation.PerformClick();
                    frmCheckinDialog frmchking = new frmCheckinDialog(cboxrefno.Text);
                    frmchking.ShowDialog();
                    if (frmchking.actioncancel == true)
                    {
                        // do nothing //
                    }
                    else if (frmchking.actioncancel == false)
                    {
                        isCheckedin = true;
                        isReservation = false;
                        isCancel = false;
                        dtpCheckin.Text = frmchking.checkedindatetime;
                        timer1.Enabled = true;
                        umeter = true;
                        btnCheckOut.Text = "Check Out !";
                    }
                }
            }

        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            if (btnNewReservation.Text == "&New Reservation")
            {
                #region to make ready fresh record
                ctag = false;
                lstvRoom.Items.Clear();
                lstvService.Items.Clear();
                ClearTextBoxes(this.Controls);
                ClearComboBoxes(this.Controls);
                EnableComboBoxes(this.Controls);
                Enabledtp(this.Controls);
                EnableTextBoxes(this.Controls);
                cboxrefno.Enabled = false;
                txtbRemarks.ReadOnly = false;
                txtbAdvance.Text = "0";
                txtbBalance.Text = "0";
                txtbDiscount.Text = "0";
                txtbGrandTotal.Text = "0";
                txtbMealsTotal.Text = "0";
                txtbRoomTotal.Text = "0";
                txtbServiceTotal.Text = "0";
                txtbReceivedTotal.Text = "0";
                btnCheckOut.Text = "Check In !";
                cboxaction.Text = "Reservation";
                isCancel = false;
                isConfirm = false;
                isCheckedin = false;
                isReservation = false;
                btnAddRoom.Enabled = true;
                btnRoomEdit.Enabled = true;
                btnRoomDel.Enabled = true;
                btnServiceAdd.Enabled = true;
                btnServiceEdit.Enabled = true;
                btnServiceDel.Enabled = true;
                IsLocked = false;
                insertreservationstatic();
                btnNewReservation.Text = "&Close";
                txtbAdvance.Enabled = true;
                txtbReceivedTotal.Enabled = true;
                txtbDiscount.Enabled = true;
                #endregion to make ready fresh record
            }
            else if (btnNewReservation.Text == "&Close")
            {
                DisableComboBoxes(this.Controls);
                DisableTextBoxes(this.Controls);
                disabledtp(this.Controls);
                cboxrefno.Enabled = true;
                txtbRemarks.ReadOnly = false;
                btnAddRoom.Enabled = false;
                btnRoomEdit.Enabled = false;
                btnRoomDel.Enabled = false;
                btnServiceAdd.Enabled = false;
                btnServiceEdit.Enabled = false;
                btnServiceDel.Enabled = false;
                isCancel = false;
                isReservation = false;
                isCheckedin = false;
                isConfirm = false;
                ctag = true;
                btnCheckOut.Text = "Check In !";
                btnNewReservation.Text = "&New Reservation";
                umeter = false;
                timer1.Enabled = false;
            }
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (cboxrefno.Text == "")
            {
                // do nothing
            }
            else if (cboxrefno.Text != "")
            {
                if (isCheckedin == false || isReservation == true && isCancel == false)
                {
                    if (btnNewReservation.Text == "&Close")
                    {
                        if (cboxaction.Text == "Reservation" || cboxaction.Text == "")
                        {
                            isCheckedin = false;
                            isConfirm = false;
                            isReservation = true;
                        }
                        else if (cboxaction.Text == "Cancel")
                        {
                            isCancel = true;
                            cancelation(cboxrefno.Text);
                            MessageBox.Show("STOP! \nReservation is Canceled. Reference No " + cboxrefno.Text + " is Canceled.");
                            return;
                        }
                        // // // // 
                        #region reservation | checkin/checkout can be change / modify
                        #region get formated date
                        string dcon = dtpCheckin.Text;
                        DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
                        checkinDate = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");
                        //
                        string dcon2 = dtpCheckout.Text;
                        DateTime dt2 = DateTime.ParseExact(dcon2, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
                        checkoutDate = dt2.ToString("yyyy/MM/dd HH:mm:ss.fff");
                        #endregion get formated date
                        // get date of now
                        inrcini insres = new inrcini();
                        if (cboxgender.Text == "Male")
                        {
                            IsMale = true;
                        }
                        else
                        {
                            IsMale = false;
                        }

                        IsLocked = false;
                        // // //
                        try
                        {
                            insres.update_reservation_static(cboxrefno.Text, cboxaction.Text
                                , res_date, isCheckedin,isCheckedout, isConfirm, isCancel, cboxaction.Text, txtbpromo.Text,
                                checkinDate, checkoutDate, txtbcname.Text, txtbfname.Text, txtblname.Text,
                                txtbphone.Text, txtbfaminfo.Text, IsMale, cboxNationality.Text,
                                cboxCNIC.Text, txtbaddress.Text, Convert.ToInt32(txtbRoomTotal.Text),
                                Convert.ToDecimal(txtbMealsTotal.Text), Convert.ToDecimal(txtbServiceTotal.Text),
                                Convert.ToDecimal(txtbAdvance.Text), Convert.ToDecimal(txtbGrandTotal.Text),
                                Convert.ToDecimal(txtbReceivedTotal.Text),
                                Convert.ToDecimal(txtbDiscount.Text), txtbRemarks.Text, IsLocked,
                                ui_code, "0");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(insres.errorcode + ex.ToString());
                        }
                        #endregion reservation | checkin/checkout can be change / modify
                    }
                    else if (btnNewReservation.Text == "&New Reservation")
                    {
                        // do this
                    }
                }
                else if (isCheckedin == true || isCancel == false)
                {
                    #region only checkout date can be modify
                    #region get formated date
                    string dcon = dtpCheckin.Text;
                    DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
                    checkinDate = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");
                    //
                    string dcon2 = dtpCheckout.Text;
                    DateTime dt2 = DateTime.ParseExact(dcon2, "dd/MM/yy hh:mm tt", CultureInfo.InvariantCulture);
                    checkoutDate = dt2.ToString("yyyy/MM/dd HH:mm:ss.fff");
                    #endregion get formated date
                    #region static update
                    Decimal billtotal = Convert.ToDecimal(txtbRoomTotal.Text) + Convert.ToDecimal(txtbMealsTotal.Text) + Convert.ToDecimal(txtbServiceTotal.Text) - Convert.ToDecimal(txtbAdvance.Text);
                    conupdafterchecked = new SqlConnection(csh);
                    cmdupdafterchecked = null;
                    try
                    {
                        cmdupdafterchecked = new SqlCommand("update reservation_static set checkout_date='" + checkoutDate + "' , cname='" +
                            txtbcname.Text + "' , fname='" + txtbfname.Text + "' , lname='" + txtblname.Text + "' , contact='" +
                            txtbphone.Text + "' , faminfo='" + txtbfaminfo.Text + "' , isMale='True' , cnationality='" +
                            cboxNationality.Text + "' , idcard='" + cboxCNIC.Text + "' , address='" + txtbaddress.Text + "' , rooms_tot=" +
                            Convert.ToDecimal(txtbRoomTotal.Text) + " , meals_tot=" +
                            Convert.ToDecimal(txtbMealsTotal.Text) + " , services_tot=" +
                            Convert.ToDecimal(txtbServiceTotal.Text) + " , advanced=" +
                            Convert.ToDecimal(txtbAdvance.Text) + " , bill_total=" +
                            billtotal + " , received_amount=" + Convert.ToDecimal(txtbReceivedTotal.Text) + " , discount=" +
                            Convert.ToDecimal(txtbDiscount.Text) + " , remarks=N'" + txtbRemarks.Text + "' where res_no='" +
                            cboxrefno.Text + "' AND isCheckedIn='True'", conupdafterchecked);
                        conupdafterchecked.Open();
                        cmdupdafterchecked.ExecuteNonQuery();
                        conupdafterchecked.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conupdafterchecked.Close();
                    }
                    #endregion static update
                    #region det update
                    conloadchkroom = new SqlConnection(csh);
                    cmdloadchkroom = null;
                    try
                    {
                        cmdloadchkroom = new SqlCommand("select * from reservation_det where m_del='0' AND isCheckedin='True' AND res_no='"+cboxrefno.Text+"'", conloadchkroom);
                        conloadchkroom.Open();
                        rdrloadchkroom = cmdloadchkroom.ExecuteReader();
                        while (rdrloadchkroom.Read() == true)
                        {
                            // // // //
                        }
                        conloadchkroom.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conloadchkroom.Close();
                    }
                    conupdafterchecked = new SqlConnection(csh);
                    cmdupdafterchecked = null;
                    try
                    {
                        cmdupdafterchecked = new SqlCommand("update reservation_det set rcheckout_date='" + checkoutDate + "' where res_no='" + cboxrefno.Text + "' AND isCheckedin='True'", conupdafterchecked);
                        conupdafterchecked.Open();
                        cmdupdafterchecked.ExecuteNonQuery();
                        conupdafterchecked.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conupdafterchecked.Close();
                    }
                    #endregion det update
                    #endregion only checkout date can be modify
                }
                else if (isCancel == true)
                {
                    MetroMessageBox.Show(this, "Reservation No " + cboxrefno.Text + " is Canceled./nCannot Update/Modify/Delete/Add");
                    return;
                }
                else if (isCheckedin == false && IsLocked == true)
                {
                    MetroMessageBox.Show(this, "Stop! contact administrator");
                }
            }
        }
        #endregion buttons

    }
}