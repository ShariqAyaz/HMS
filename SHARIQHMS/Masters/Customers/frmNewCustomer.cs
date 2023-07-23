using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using inrClass;
using counterClass;
using System.Globalization;
using System.Data.SqlClient;
using logClass;

namespace SHARIQHMS.Masters.Customers
{
    public partial class frmNewCustomer : Form
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection conloadc = null;
        SqlCommand cmdloadc = null;
        SqlDataReader rdrloadc = null;
        #endregion Database string and connections
        string dateofb;
        string ui_code = "";
        public frmNewCustomer(string uicode)
        {
            InitializeComponent();
            ui_code = uicode;
        }

        private void txtbcustname_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (tb.Name == "txtbcustname")
                {
                    if (tb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Customer Name";
                        toolTip1.Show("Enter Customer Name", tb, 2500);
                    }
                    else
                    {
                        txtbcompname.Text = tb.Text;
                        txtbfaminfo.Focus();
                    }
                }
                else if (tb.Name == "txtbfaminfo") // 2
                {
                    if (tb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Father/Husband Name";
                        toolTip1.Show("Enter Father or Husband Name", tb, 2500);
                    }
                    else
                    {
                        dtp1.Focus();
                    }
                }
                else if (tb.Name == "txtbcompname") // 4
                {
                    if (tb.Text == "")
                    {
                        tb.Text = txtbcustname.Text;
                        txtbprofession.Focus();
                    }
                    else
                    {
                        txtbprofession.Focus();
                    }
                }
                else if (tb.Name == "txtbprofession") // 5
                {
                    if (tb.Text == "")
                    {
                        tb.Text = "n/a";
                        txtbphone1.Focus();
                    }
                    else
                    {
                        txtbphone1.Focus();
                    }
                }
                else if (tb.Name == "txtbphone1")
                {
                    if (tb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Mobile Number";
                        toolTip1.Show("Enter Mobile Number", tb, 2500);
                    }
                    else
                    {
                        txtbphone2.Focus();
                    }
                }
                else if (tb.Name == "txtbphone2")
                {
                    if (tb.Text == "")
                    {
                        tb.Text = "n/a";
                        txtbaddress.Focus();
                    }
                    else
                    {
                        txtbaddress.Focus();
                    }
                }
                else if (tb.Name == "txtbaddress") // 8
                {
                    if (tb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Address";
                        toolTip1.Show("Enter Customer Address", tb, 2500);
                    }
                    else
                    {
                        cboxcustid.Focus();
                    }
                }
                else if (tb.Name == "txtbemail") // 11
                {
                    if (tb.Text == "")
                    {
                        tb.Text = "n/a";
                        btnAdd.Focus();
                    }
                    else
                    {
                        btnAdd.Focus();
                    }
                }
            }
        }

        private void cboxcustid_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (cb.Name == "cboxcustid") // 9
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "CNIC/Passport";
                        toolTip1.Show("Enter CNIC or Passport", cb, 2500);
                    }
                    else
                    {
                        cboxnationality.Focus();
                    }
                }
                else if (cb.Name == "cboxnationality") // 10
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Nationality";
                        toolTip1.Show("Enter Nationality", cb, 2500);
                    }
                    else
                    {
                        txtbemail.Focus();
                    }
                }
            }
        }

        private void dtp1_KeyDown(object sender, KeyEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (dtp.Name == "dtp1") // 3
                {
                    if (dtp.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Date Of Birth";
                        toolTip1.Show("Enter Date Of Birth", dtp, 2500);
                    }
                    else
                    {
                        txtbcompname.Focus();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Authority Check
            #endregion Authority Check
            #region make sure required fields are available
            if (txtbcustname.Text == "") { MessageBox.Show("Please Enter Customer Name"); return; }
            if (txtbfaminfo.Text == "") { MessageBox.Show("Please Enter Father or Husband Name"); return; }
            if (txtbcompname.Text == "") { txtbcompname.Text = txtbcustname.Text; }
            if (txtbphone1.Text == "") { MessageBox.Show("Please Enter Phone Number"); return; }
            if (txtbaddress.Text == "") { MessageBox.Show("Please Enter Address"); return; }
            if (cboxcustid.Text == "") { MessageBox.Show("Enter Customer ID / Name"); return; }
            if (cboxnationality.Text == "") { MessageBox.Show("Enter Customer ID / Name"); return; }
            #endregion make sure required fields are available
            #region processdate
            string dcon = dtp1.Text;
            DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy", CultureInfo.InvariantCulture);
            dateofb = dt.ToString("yyyy/MM/dd");
            #endregion processdate
            #region insert cust
            // init classes
            log_ex log = new log_ex();
            counzini custcount = new counzini();
            inrcini insertcust = new inrcini();
            custcount.custcounter();
            string getcid = custcount.custcount.ToString();
            try
            {
                insertcust.insert_mast_cust(getcid, txtbcompname.Text, txtbcustname.Text, txtbfaminfo.Text, dateofb, txtbphone1.Text, txtbphone2.Text, "", cboxcustid.Text, cboxnationality.Text, txtbemail.Text, "", txtbaddress.Text, txtbprofession.Text, "", "", "", ui_code, "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(insertcust.errorcode + " \n" + ex.ToString());
                log.insert_log_err(ui_code,insertcust.errorcode,"2","0");
            }
            #endregion insert cust
            #region log the success event
            log.insert_log_event(ui_code, "Successfully Entered new customer: " +getcid, "2", "0");
            #endregion log the success event
            this.Close();
        }

        private void loadc()
        {
            conloadc = new SqlConnection(csh);
            cmdloadc = null;
            cmdloadc = new SqlCommand("select custid,nationality from cust_mast where m_del='0'", conloadc);
            conloadc.Open();
            rdrloadc = cmdloadc.ExecuteReader();
            while (rdrloadc.Read()==true)
            {
                cboxcustid.Items.Add((string)rdrloadc["custid"]);
                cboxnationality.Items.Add((string)rdrloadc["nationality"]);
            }
            conloadc.Close();
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            loadc();
            DateTime.Now.ToString("dd/MM/yy");
            dtp1.CustomFormat = "dd/MM/yy";
        }
    }
}
